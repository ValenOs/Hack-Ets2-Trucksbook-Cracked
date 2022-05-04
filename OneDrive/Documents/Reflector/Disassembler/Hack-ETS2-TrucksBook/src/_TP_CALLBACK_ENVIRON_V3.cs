using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size=0x48), NativeCppClass]
internal struct _TP_CALLBACK_ENVIRON_V3
{
    private long <alignment member>;
    [StructLayout(LayoutKind.Explicit, Size=4), CLSCompliant(false), NativeCppClass]
    public struct <unnamed-type-u>
    {
        [FieldOffset(0)]
        private int <alignment member>;

        [StructLayout(LayoutKind.Sequential, Size=4), NativeCppClass, CLSCompliant(false)]
        public struct <unnamed-type-s>
        {
            private int <alignment member>;
        }
    }
}

