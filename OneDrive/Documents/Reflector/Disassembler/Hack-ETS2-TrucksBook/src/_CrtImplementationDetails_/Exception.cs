namespace <CrtImplementationDetails>
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class Exception : Exception
    {
        public Exception(string message);
        protected Exception(SerializationInfo info, StreamingContext context);
        public Exception(string message, Exception innerException);
    }
}

