namespace Vimitate;

public class VimEngine
{
    private InputMode _inputMode = InputMode.Normal;
    private string _text = "";

    public State GetState()
    {
        return new(_text);
    }

    public void Clear()
    {
        _text = "";
    }

    public void KeyPress(Keypress keypress)
    {
        if (_inputMode == InputMode.Normal)
        {
            if (keypress.Key == Key.I)
            {
                _inputMode = InputMode.Insert;
            }
        }
        else if (_inputMode == InputMode.Insert)
        {
            _text += keypress.ToChar();
        }
    }
}
