namespace VimitateTests;

[FeatureFile("./BasicInput.feature")]
public sealed class BasicInputSpecs : Feature
{
    private VimEngine _engine = new();

    [When("I press '(.*)'")]
    public void WhenIPress(char key)
    {
        var keypress = key.ConvertToKeypress();
        _engine.KeyPress(keypress);
    }

    [And("I press the following, it gets inserted into the text:")]
    public void WhenIPressTheFollowingKeyItGetsInsertedIntoTheText(DataTable dataTable)
    {
        using var assertionScope = new AssertionScope();

        foreach (var row in dataTable.Rows.Skip(1))
        {
            _engine.Clear();

            string keyString = row.Cells.ElementAt(0).Value;
            var keypress = keyString.ConvertToKeypress();

            _engine.KeyPress(keypress);

            string expected = row.Cells.ElementAt(1).Value;
            _engine.GetState().Text.Should().Be(expected);
        }
    }
}