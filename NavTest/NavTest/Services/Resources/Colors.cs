

using System;
using System.Collections.Generic;

public enum Color : byte
{
    Main,
    Tint,
    Shadow,
    Background
}

static class ColorfMethods
{
    internal static Dictionary<Color, Int32> defaultColors = new Dictionary<Color, Int32>
    {
        {Color.Main, 0x0000},
        {Color.Tint, 0xff0000},
        {Color.Shadow, 0xfefefe},
        {Color.Background, 0xffffff}
    };
}