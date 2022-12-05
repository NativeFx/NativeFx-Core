namespace NativeFx.Frontend;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a long piece of text.
/// </summary>
public class LongText : IText, IList<string>
{
    private readonly List<string> _strings = new();

    /// <inheritdoc />
    public string this[int index]
    {
        get => ((IList<string>)_strings)[index]; set
        {
            if (index > 9)
            {
                throw new InvalidOperationException("You can only have up to 10 strings.");
            }

            ((IList<string>)_strings)[index] = value;
        }
    }

    /// <inheritdoc />
    public int Count => (_strings).Count;

    /// <inheritdoc />
    public bool IsReadOnly => false;

    public void Add(string text)
    {
        if (_strings.Count >= 10)
        {
            throw new InvalidOperationException("You cannot have more than 10 strings.");
        }

        _strings.Add(text);
    }

    /// <inheritdoc />
    public void Add()
    {
        foreach (var str in _strings)
        {
            Natives.AddTextComponentSubstringPlayerName(str);
        }
    }

    /// <inheritdoc />
    public void Clear()
    {
        _strings.Clear();
    }

    /// <inheritdoc />
    public bool Contains(string item)
    {
        return (_strings).Contains(item);
    }

    /// <inheritdoc />
    public void CopyTo(string[] array, int arrayIndex)
    {
        (_strings).CopyTo(array, arrayIndex);
    }

    /// <inheritdoc />
    public IEnumerator<string> GetEnumerator()
    {
        return ((IEnumerable<string>)_strings).GetEnumerator();
    }

    /// <inheritdoc />
    public int IndexOf(string item)
    {
        return ((IList<string>)_strings).IndexOf(item);
    }

    /// <inheritdoc />
    public void Insert(int index, string item)
    {
        if (index > 9)
        {
            throw new InvalidOperationException("You can only have up to 10 strings.");
        }

        ((IList<string>)_strings).Insert(index, item);
    }

    /// <inheritdoc />
    public bool Remove(string item)
    {
        return (_strings).Remove(item);
    }

    /// <inheritdoc />
    public void RemoveAt(int index)
    {
        ((IList<string>)_strings).RemoveAt(index);
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_strings).GetEnumerator();
    }
}
