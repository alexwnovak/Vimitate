namespace Vimitate;

public static class KeyExtensions
{
    private static readonly Dictionary<Key, char> _keyTable = new Dictionary<Key, char>
    {
        // Letters
        [Key.A] = 'a',
        [Key.B] = 'b',
        [Key.C] = 'c',
        [Key.D] = 'd',
        [Key.E] = 'e',
        [Key.F] = 'f',
        [Key.G] = 'g',
        [Key.H] = 'h',
        [Key.I] = 'i',
        [Key.J] = 'j',
        [Key.K] = 'k',
        [Key.L] = 'l',
        [Key.M] = 'm',
        [Key.N] = 'n',
        [Key.O] = 'o',
        [Key.P] = 'p',
        [Key.Q] = 'q',
        [Key.R] = 'r',
        [Key.S] = 's',
        [Key.T] = 't',
        [Key.U] = 'u',
        [Key.V] = 'v',
        [Key.W] = 'w',
        [Key.X] = 'x',
        [Key.Y] = 'y',
        [Key.Z] = 'z',

        // Digits
        [Key.D0] = '0',
        [Key.D1] = '1',
        [Key.D2] = '2',
        [Key.D3] = '3',
        [Key.D4] = '4',
        [Key.D5] = '5',
        [Key.D6] = '6',
        [Key.D7] = '7',
        [Key.D8] = '8',
        [Key.D9] = '9',

        // Symbols
        [Key.Hyphen] = '-',
        [Key.Equals] = '=',
        [Key.LeftBracket] = '[',
        [Key.RightBracket] = ']',
        [Key.Backslash] = '\\',
        [Key.Semicolon] = ';',
        [Key.Apostrophe] = '\'',
        [Key.Comma] = ',',
        [Key.Period] = '.',
        [Key.ForwardSlash] = '/',
    };

    private static readonly Dictionary<Key, char> _shiftKeyTable = new Dictionary<Key, char>
    {
        // Letters
        [Key.A] = 'A',
        [Key.B] = 'B',
        [Key.C] = 'C',
        [Key.D] = 'D',
        [Key.E] = 'E',
        [Key.F] = 'F',
        [Key.G] = 'G',
        [Key.H] = 'H',
        [Key.I] = 'I',
        [Key.J] = 'J',
        [Key.K] = 'K',
        [Key.L] = 'L',
        [Key.M] = 'M',
        [Key.N] = 'N',
        [Key.O] = 'O',
        [Key.P] = 'P',
        [Key.Q] = 'Q',
        [Key.R] = 'R',
        [Key.S] = 'S',
        [Key.T] = 'T',
        [Key.U] = 'U',
        [Key.V] = 'V',
        [Key.W] = 'W',
        [Key.X] = 'X',
        [Key.Y] = 'Y',
        [Key.Z] = 'Z',

        // Digits
        [Key.D0] = ')',
        [Key.D1] = '!',
        [Key.D2] = '@',
        [Key.D3] = '#',
        [Key.D4] = '$',
        [Key.D5] = '%',
        [Key.D6] = '^',
        [Key.D7] = '&',
        [Key.D8] = '*',
        [Key.D9] = '(',

        // Symbols
        [Key.Hyphen] = '_',
        [Key.Equals] = '+',
        [Key.LeftBracket] = '{',
        [Key.RightBracket] = '}',
        [Key.Backslash] = '|',
        [Key.Semicolon] = ':',
        [Key.Apostrophe] = '\"',
        [Key.Comma] = '<',
        [Key.Period] = '>',
        [Key.ForwardSlash] = '?',
    };

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
        if (keypress.Shift() && _shiftKeyTable.TryGetValue(keypress.Key, out char value))
        {
            return value;
        }

        if (_keyTable.TryGetValue(keypress.Key, out value))
        {
            return value;
        }

        return '\0';
    }
}