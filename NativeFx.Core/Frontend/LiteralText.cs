namespace NativeFx.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a literal text string.
/// </summary>
public class LiteralText : IText
{
    /// <summary>
    /// Initialises a new instance of the <see cref="LiteralText"/> class.
    /// </summary>
    /// <param name="value">The value.</param>
    public LiteralText(string value)
    {
        Value = value;
    }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public string Value { get; set; }

    /// <inheritdoc />
    public void Add()
    {
        Natives.AddTextComponentSubstringPlayerName(Value);
    }
}
