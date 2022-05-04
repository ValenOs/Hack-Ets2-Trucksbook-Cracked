namespace <CrtImplementationDetails>
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class ModuleLoadException : Exception
    {
        public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";

        public ModuleLoadException(string message);
        protected ModuleLoadException(SerializationInfo info, StreamingContext context);
        public ModuleLoadException(string message, Exception innerException);
    }
}

