namespace VimitateTests;

[FeatureFile("./BasicInput.feature")]
public sealed class BasicInputSpecs : Feature
{
    private readonly VimEngine _vimEngine = new();

    [When("I press 'A'")]
    public void WhenIPressA()
    {
        _vimEngine.KeyPress(Key.A);
    }

    [Then("the current text is 'A'")]
    public void ThenTheCurrentTextIsA()
    {
        _vimEngine.GetState().Text.Should().Be("A");
    }
}