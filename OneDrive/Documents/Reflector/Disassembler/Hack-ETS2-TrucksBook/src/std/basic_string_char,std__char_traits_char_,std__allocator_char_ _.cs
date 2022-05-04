namespace std
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Size=40), UnsafeValueType, NativeCppClass]
    internal struct basic_string<char,std::char_traits<char>,std::allocator<char> >
    {
        private long <alignment member>;
        public static unsafe void <MarshalCopy>(basic_string<char,std::char_traits<char>,std::allocator<char> >* A_0, basic_string<char,std::char_traits<char>,std::allocator<char> >* A_1);
        public static unsafe void <MarshalDestroy>(basic_string<char,std::char_traits<char>,std::allocator<char> >* A_0);
    }
}

