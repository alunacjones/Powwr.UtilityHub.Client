namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class GetProductConfigurationRequest
    {
        [JsonProperty("brokerageExternalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerageExternalId { get; set; }
        [JsonProperty("configurationType", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConfigurationType? ConfigurationType { get; set; }

        [JsonProperty("host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty("supplierExternalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplierExternalId { get; set; }

        [JsonProperty("urlVanityName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlVanityName { get; set; }

        public static GetProductConfigurationRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<GetProductConfigurationRequest>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}