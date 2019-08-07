using System;
using System.Runtime.Serialization;

namespace TheGarage_03_19
{
    [Serializable]
    public class CarNotInGarageException : Exception
    {
        public CarNotInGarageException()
        {
        }

        public CarNotInGarageException(string message) : base(message)
        {
        }

        public CarNotInGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}