namespace VimitateTests;

[FeatureFile("./BasicInput.feature")]
public sealed class BasicInputSpecs : Feature
{
    private readonly VimEngine _vimEngine = new();

    [When("I press (.*)")]
    public void WhenIPressA(object value)
    {
        var key = value.ConvertToKey();
        _vimEngine.KeyPress(key);
    }

    [Then(@"the current text is ""(.*)""")]
    public void ThenTheTextIsTheExpectedValue(string expectedText)
    {
        _vimEngine.GetState().Text.Should().Be(expectedText);
    }
}