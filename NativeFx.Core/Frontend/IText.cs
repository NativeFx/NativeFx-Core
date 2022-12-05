namespace NativeFx.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a text component substring.
/// </summary>
public interface IText
{
    /// <summary>
    /// Pushes this instance to text component substring stack.
    /// </summary>
    void Add();
}
