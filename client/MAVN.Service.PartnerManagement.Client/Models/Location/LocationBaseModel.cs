﻿using System;

namespace MAVN.Service.PartnerManagement.Client.Models.Location
{
    /// <summary>
    /// Represents a location model
    /// </summary>
    public abstract class LocationBaseModel
    {
        /// <summary>
        /// The location name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The location address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Represents location's external identifier
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The contact person of the location
        /// </summary>
        public ContactPersonModel ContactPerson { get; set; }

        /// <summary>
        /// Accounting integration code
        /// </summary>
        public string AccountingIntegrationCode { get; set; }

        /// <summary>
        /// Longitude of the location
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Latitude of the location
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Country Iso3 code
        /// </summary>
        public string CountryIso3Code { get; set; }
    }
}
