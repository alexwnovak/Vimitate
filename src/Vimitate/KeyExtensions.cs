namespace Vimitate;

public static class KeyExtensions
{
    public static char ToChar(this Key key, bool uppercase)
    {
        if (uppercase)
        {
            return key.ToString()[0];
        }

        return key.ToString().ToLower()[0];
    }

    public static char ToChar(this Keypress keypress)
    {
        if (keypress.Shift())
        {
            return keypress.Key.ToString()[0];
        }

        return keypress.Key.ToString().ToLower()[0];
    }
}