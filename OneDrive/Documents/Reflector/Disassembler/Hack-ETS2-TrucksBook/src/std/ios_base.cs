namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=0x48), NativeCppClass]
    internal struct ios_base
    {
        private long <alignment member>;
        [StructLayout(LayoutKind.Sequential, Size=0x18), NativeCppClass]
        internal struct _Fnarray
        {
            private long <alignment member>;
        }

        [StructLayout(LayoutKind.Sequential, Size=0x18), NativeCppClass]
        internal struct _Iosarray
        {
            private long <alignment member>;
        }

        [NativeCppClass, CLSCompliant(false)]
        public enum @event
        {
        }

        [StructLayout(LayoutKind.Sequential, Size=40), NativeCppClass, CLSCompliant(false)]
        public struct failure
        {
            private long <alignment member>;
        }

        [StructLayout(LayoutKind.Sequential, Size=1), NativeCppClass, CLSCompliant(false)]
        public struct Init
        {
        }
    }
}

