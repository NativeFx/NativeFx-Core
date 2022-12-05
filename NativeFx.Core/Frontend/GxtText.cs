namespace NativeFx.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GxtText : IText
{
    public GxtText(string value)
    {
        Value = value;
    }

    public string Value { get; set; }

    public void Add()
    {
        Natives.AddTextComponentSubstringTextLabel(Value);
    }
}
