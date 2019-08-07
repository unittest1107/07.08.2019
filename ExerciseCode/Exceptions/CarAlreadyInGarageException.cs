using System;
using System.Runtime.Serialization;

namespace TheGarage_03_19
{
    [Serializable]
    public class CarAlreadyInGarageException : Exception
    {
        public CarAlreadyInGarageException()
        {
        }

        public CarAlreadyInGarageException(string message) : base(message)
        {
        }

        public CarAlreadyInGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}