namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=4), NativeCppClass]
    internal struct atomic<long>
    {
        private int <alignment member>;
    }
}

