namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=40), UnsafeValueType, NativeCppClass]
    internal struct _String_val<std::_Simple_types<char32_t> >
    {
        private long <alignment member>;
        [StructLayout(LayoutKind.Explicit, Size=0x10), NativeCppClass, CLSCompliant(false), UnsafeValueType]
        public struct _Bxty
        {
            [FieldOffset(0)]
            private long <alignment member>;
        }
    }
}

