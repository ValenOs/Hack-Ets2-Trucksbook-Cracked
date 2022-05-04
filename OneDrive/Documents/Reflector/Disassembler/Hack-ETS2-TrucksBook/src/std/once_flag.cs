namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=8), NativeCppClass]
    internal struct once_flag
    {
        private long <alignment member>;
    }
}

