using System;
using System.Runtime.Serialization;

namespace TheGarage_03_19
{
    [Serializable]
    public class WeDoNotFixTotalLossException : Exception
    {
        public WeDoNotFixTotalLossException()
        {
        }

        public WeDoNotFixTotalLossException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLossException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLossException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}