namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=0x10), NativeCppClass]
    internal struct exception_ptr
    {
        private long <alignment member>;
        public static unsafe void <MarshalCopy>(exception_ptr* A_0, exception_ptr* A_1);
        public static unsafe void <MarshalDestroy>(exception_ptr* A_0);
    }
}

