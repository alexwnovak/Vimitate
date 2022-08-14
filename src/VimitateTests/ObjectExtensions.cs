namespace VimitateTests;

internal static class ObjectExtensions
{
    public static Keypress ConvertToKeypress(this object obj)
    {
        string name = obj.ToString()!;

        // First, try to parse the string to see if it's a direct enum name

        if (Enum.TryParse(name, out Key key))
        {
            return new Keypress(key);
        }

        // Now try to parse modifiers

        if (TryParseComplex(name, out var keypress))
        {
            return keypress;
        }

        throw new FormatException(@$"Could not covert value ""{name}"" to Key instance");
    }

    private static bool TryParseComplex(string name, out Keypress keypress)
    {
        if (name.Contains('+'))
        {
            var parts = name.Split('+');

            Key key = Key.None;
            ModifierKeys modifiers = ModifierKeys.None;

            foreach (string part in parts)
            {
                // See if this part can be parsed to a key

                if (!Enum.TryParse(part, out key))
                {
                    // See if it's a modifier

                    if (!Enum.TryParse(part, out ModifierKeys thisModifier))
                    {
                        // It was neither
                        throw new FormatException(@$"Could not covert value ""{name}"" to Key instance");
                    }

                    // It was a modifier

                    modifiers |= thisModifier;
                }
            }

            keypress = new Keypress(key, modifiers);
            return true;
        }

        keypress = new Keypress();
        return false;
    }
}
