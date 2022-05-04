using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size=0x40), NativeCppClass]
internal struct EHExceptionRecord
{
    private long <alignment member>;
    [StructLayout(LayoutKind.Sequential, Size=0x20), CLSCompliant(false), NativeCppClass]
    public struct EHParameters
    {
        private long <alignment member>;
    }
}

