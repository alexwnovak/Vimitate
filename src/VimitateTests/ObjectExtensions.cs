namespace VimitateTests;

internal static class ObjectExtensions
{
    public static Key ConvertToKey(this object obj)
    {
        if (obj is null)
        {
            throw new ArgumentNullException(nameof(obj), "Object parameter must not be null");
        }

        string name = obj.ToString();

        if (!Enum.TryParse(name, out Key key))
        {
            throw new FormatException(@$"Could not covert value ""{name}"" to Key instance");
        }

        return key;
    }
}
