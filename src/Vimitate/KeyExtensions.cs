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
}