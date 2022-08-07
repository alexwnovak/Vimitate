namespace Vimitate;

public class VimEngine
{
    private string _text = "";

    public State GetState()
    {
        return new(_text);
    }

    public void KeyPress(Key key)
    {
    }
}
