namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class SupplierModelBase
    {
        [JsonProperty("countryId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryId { get; set; }

        [JsonProperty("createdDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; }

        [JsonProperty("externalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        [JsonProperty("legalEntities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LegalEntityModel> LegalEntities { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        [Required]
        public string Name { get; set; }
        [JsonProperty("supplierId", Required = Required.Always)]
        public int SupplierId { get; set; }

        [JsonProperty("timeZoneId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneId { get; set; }

        [JsonProperty("vanityName")]
        // [Required]
        [StringLength(30, MinimumLength = 1)]
        [RegularExpression(@"^[a-z0-9]*$")]
        public string VanityName { get; set; }

        public static SupplierModelBase FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SupplierModelBase>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}