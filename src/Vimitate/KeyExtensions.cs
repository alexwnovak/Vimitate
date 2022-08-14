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
        // Check for digits

        if (keypress.Key >= Key.D0 && keypress.Key <= Key.D9)
        {
            return keypress.Key.ToString()[1];
        }

        // Treat it like a letter

        if (keypress.Shift())
        {
            return keypress.Key.ToString()[0];
        }

        return keypress.Key.ToString().ToLower()[0];
    }
}