namespace <CrtImplementationDetails>
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    internal class OpenMPWithMultipleAppdomainsException : Exception
    {
        public OpenMPWithMultipleAppdomainsException();
        protected OpenMPWithMultipleAppdomainsException(SerializationInfo info, StreamingContext context);
    }
}

