using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeFunctionHook.value
{
    public struct RGBColor
    {
        public RGBColor(int RA, int GA, int BA)
        {
            R = RA;
            G = GA;
            B = BA;
        }
        public int R;
        public int G;
        public int B;
    }
}
