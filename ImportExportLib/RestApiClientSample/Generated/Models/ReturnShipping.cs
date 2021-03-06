// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace StorageImportExport.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Specifies the return carrier and customer’s account with the carrier.
    /// </summary>
    public partial class ReturnShipping
    {
        /// <summary>
        /// Initializes a new instance of the ReturnShipping class.
        /// </summary>
        public ReturnShipping() { }

        /// <summary>
        /// Initializes a new instance of the ReturnShipping class.
        /// </summary>
        public ReturnShipping(string carrierName, string carrierAccountNumber)
        {
            CarrierName = carrierName;
            CarrierAccountNumber = carrierAccountNumber;
        }

        /// <summary>
        /// The carrier’s name.
        /// </summary>
        [JsonProperty(PropertyName = "CarrierName")]
        public string CarrierName { get; set; }

        /// <summary>
        /// The customer’s account number with the carrier.
        /// </summary>
        [JsonProperty(PropertyName = "CarrierAccountNumber")]
        public string CarrierAccountNumber { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (CarrierName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CarrierName");
            }
            if (CarrierAccountNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CarrierAccountNumber");
            }
        }
    }
}
