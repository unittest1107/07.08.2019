using System;
using System.Runtime.Serialization;

namespace TheGarage_03_19
{
    [Serializable]
    public class WrongGarageException : Exception
    {
        public WrongGarageException()
        {
        }

        public WrongGarageException(string message) : base(message)
        {
        }

        public WrongGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}