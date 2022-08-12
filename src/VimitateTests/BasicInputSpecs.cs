

namespace VimitateTests;

[FeatureFile("./BasicInput.feature")]
public sealed class BasicInputSpecs : Feature
{
    [When("I press the following, the text matches the expected value:")]
    public void WhenIPressTheFollowing(DataTable dataTable)
    {
        using var assertionScope = new AssertionScope();

        foreach (var row in dataTable.Rows.Skip(1))
        {
            string keyString = row.Cells.ElementAt(0).Value;
            Key key = Enum.Parse<Key>(keyString);

            var engine = new VimEngine();
            engine.KeyPress(key);

            string expected = row.Cells.ElementAt(1).Value;
            engine.GetState().Text.Should().Be(expected);
        }
    }
}