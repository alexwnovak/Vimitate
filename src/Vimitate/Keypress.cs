namespace Vimitate;

public record struct Keypress
{
    public Key Key { get; } = Key.None;
    public ModifierKeys Modifiers { get; init; } = ModifierKeys.None;

    public Keypress(Key key)
        : this(key, ModifierKeys.None)
    {
    }

    public Keypress(Key key, ModifierKeys modifiers)
    {
        Key = key;
        Modifiers = modifiers;
    }

    public bool AltOption() => Modifiers.HasFlag(ModifierKeys.AltOption);
    public bool Control() => Modifiers.HasFlag(ModifierKeys.Control);
    public bool Shift() => Modifiers.HasFlag(ModifierKeys.Shift);
}
