namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BrokerageSupplierModel
    {
        [JsonProperty("brokerageExternalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerageExternalId { get; set; }
        [JsonProperty("brokerageId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerageId { get; set; }

        [JsonProperty(
            "brokerageLegalEntityCompanyNumber",
            Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerageLegalEntityCompanyNumber { get; set; }

        [JsonProperty("brokerageLegalEntityId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerageLegalEntityId { get; set; }

        [JsonProperty("brokerageName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerageName { get; set; }

        [JsonProperty("supplierExternalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplierExternalId { get; set; }

        [JsonProperty("supplierId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; }

        [JsonProperty(
            "supplierLegalEntityCompanyNumber",
            Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public string SupplierLegalEntityCompanyNumber { get; set; }

        [JsonProperty("supplierLegalEntityId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierLegalEntityId { get; set; }

        [JsonProperty("supplierName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplierName { get; set; }

        [JsonProperty("suppliersBrokerageId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SuppliersBrokerageId { get; set; }

        [JsonProperty("suppliersBrokerageName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SuppliersBrokerageName { get; set; }

        public static BrokerageSupplierModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<BrokerageSupplierModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}