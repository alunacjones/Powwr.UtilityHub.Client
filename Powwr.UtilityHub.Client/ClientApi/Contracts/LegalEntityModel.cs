namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class LegalEntityModel
    {
        [JsonProperty("companyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("companyNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyNumber { get; set; }

        [JsonProperty("companyType", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompanyType? CompanyType { get; set; }

        [JsonProperty("dateRegistered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateRegistered { get; set; }
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("legalEntityStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public LegalEntityStatus? LegalEntityStatus { get; set; }

        [JsonProperty("owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        [JsonProperty("registeredAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object RegisteredAddress { get; set; }

        [JsonProperty("tradingAsName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TradingAsName { get; set; }

        public static LegalEntityModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LegalEntityModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}