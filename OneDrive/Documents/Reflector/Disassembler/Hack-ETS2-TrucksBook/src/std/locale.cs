namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=0x10), NativeCppClass]
    internal struct locale
    {
        private long <alignment member>;
        [StructLayout(LayoutKind.Sequential, Size=8), CLSCompliant(false), NativeCppClass]
        public struct _Facet_guard
        {
            private long <alignment member>;
        }

        [StructLayout(LayoutKind.Sequential, Size=0x38), CLSCompliant(false), NativeCppClass]
        public struct _Locimp
        {
            private long <alignment member>;
        }

        [StructLayout(LayoutKind.Sequential, Size=0x10), NativeCppClass, CLSCompliant(false)]
        public struct facet
        {
            private long <alignment member>;
        }

        [StructLayout(LayoutKind.Sequential, Size=8), NativeCppClass, CLSCompliant(false)]
        public struct id
        {
            private long <alignment member>;
        }
    }
}

