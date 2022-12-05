﻿namespace NativeFx.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IAsset
{
    bool IsLoaded { get; }

    void Load();
    void Dismiss();
}