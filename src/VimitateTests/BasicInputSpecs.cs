

namespace VimitateTests;

[FeatureFile("./BasicInput.feature")]
public sealed class BasicInputSpecs : Feature
{
    [When("I press the following lowercase letter, it gets inserted into the text:")]
    public void WhenIPressTheFollowingLowercaseLetterItGetsInsertedIntoTheText(DataTable dataTable)
    {
        using var assertionScope = new AssertionScope();

        foreach (var row in dataTable.Rows.Skip(1))
        {
            string keyString = row.Cells.ElementAt(0).Value;
            var keypress = keyString.ConvertToKeypress();

            var engine = new VimEngine();
            engine.KeyPress(keypress);

            string expected = row.Cells.ElementAt(1).Value;
            engine.GetState().Text.Should().Be(expected);
        }
    }

    [When("I press the following key combination, it gets inserted into the text:")]
    public void WhenIPressTheFollowingKeyCombinationItGetsInsertedIntoTheText(DataTable dataTable)
    {
        using var assertionScope = new AssertionScope();

        foreach (var row in dataTable.Rows.Skip(1))
        {
            string keyString = row.Cells.ElementAt(0).Value;
            var keypress = keyString.ConvertToKeypress();

            var engine = new VimEngine();
            engine.KeyPress(keypress);

            string expected = row.Cells.ElementAt(1).Value;
            engine.GetState().Text.Should().Be(expected);
        }
    }
}