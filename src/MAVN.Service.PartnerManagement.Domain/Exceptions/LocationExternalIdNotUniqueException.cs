using System;

namespace MAVN.Service.PartnerManagement.Domain.Exceptions
{
    public class LocationExternalIdNotUniqueException : Exception
    {
        public LocationExternalIdNotUniqueException(string message)
        : base(message)
        {

        }
    }
}
