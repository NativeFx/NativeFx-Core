namespace NativeFx.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents an instance that has a handle.
/// </summary>
/// <remarks>
/// <note type="warning">
/// Handleables should be validated for each game tick if the entity is not created or known to be valid in that tick. A call to
/// invalid handleables will result in exception, or in some cases, even game crash or improper behaviour of handleables.
/// </note>
/// <para>
/// Instances in the game engine are represented by handles to expose via C-like API.
/// </para>
/// </remarks>
public interface IHandleable
{
    /// <summary>
    /// Gets the handle of this instance.
    /// </summary>
    int Handle { get; }

    /// <summary>
    /// Determines whether or not this instance still represents a valid instance in the game.
    /// </summary>
    /// <returns><see langword="true"/> if this instance is valid; otherwise, <see langword="false"/>.</returns>
    bool IsValid();
}
