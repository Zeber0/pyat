using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ptnshki
{
    class Mtds
    {
        [DllImport("Dll1.dll")]
        public extern static int newgame(int nw, int nh);
        [DllImport("Dll1.dll")]
        public extern static int wincheck(int nw, int nh);
        [DllImport("Dll1.dll")]
        public extern static int mix(int nw, int nh);
        [DllImport("Dll1.dll")]
        public extern static void move(int cx, int cy);
        [DllImport("Dll1.dll")]
        public extern static int getField([MarshalAs(UnmanagedType.LPArray), In, Out] int[] t);
        [DllImport("Dll1.dll")]
        public extern static int getFieldsize();
        [DllImport("Dll1.dll")]
        public extern static int getFieldsize2();
    }
}
