namespace Vimitate;

/// <summary>
/// Specifies the set of modifier keys. These keys are typically held down while
/// another key is pressed, and don't represent a key press on their own. This is
/// a "flags" enum, so multiple values may be present.
/// </summary>
[Flags]
public enum ModifierKeys
{
    /// <summary>
    /// No modifier keys are pressed.
    /// </summary>
    None,

    /// <summary>
    /// The Alt/Option key is pressed. Note that on Windows, this is Alt, and
    /// Option on macOS.
    /// </summary>
    AltOption,

    /// <summary>
    /// The Control key is pressed.
    /// </summary>
    Control,

    /// <summary>
    /// The Shift key is pressed.
    /// </summary>
    Shift,
}
