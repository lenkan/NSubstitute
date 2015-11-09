using System;
#if NET35 || NET4 || NET45
using System.Runtime.Serialization;
#endif

namespace NSubstitute.Exceptions
{
    [Serializable]
    public class MissingSequenceNumberException : SubstituteException
    {
        public MissingSequenceNumberException() { }
#if NET35 || NET4 || NET45
        protected MissingSequenceNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
    }
}
