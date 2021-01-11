namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ProductEditSupplierAssignmentModel : ProductModelValidationBase
    {
        [JsonProperty("createdDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; }
        [JsonProperty("productName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        [JsonProperty("supplierId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; }

        [JsonProperty("supplierName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplierName { get; set; }

        public static ProductEditSupplierAssignmentModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ProductEditSupplierAssignmentModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}