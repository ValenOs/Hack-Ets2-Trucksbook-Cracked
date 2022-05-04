namespace <CrtImplementationDetails>
{
    using System;
    using System.Runtime.Serialization;
    using System.Security;

    [Serializable]
    internal class ModuleLoadExceptionHandlerException : ModuleLoadException
    {
        private const string formatString = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";
        private Exception <backing_store>NestedException;

        protected ModuleLoadExceptionHandlerException(SerializationInfo info, StreamingContext context);
        public ModuleLoadExceptionHandlerException(string message, Exception innerException, Exception nestedException);
        [SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override string ToString();

        public Exception NestedException { get; set; }
    }
}

