namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserSupplierModel
    {
        [JsonProperty("externalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }
        [JsonProperty("supplierId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; }

        public static UserSupplierModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserSupplierModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}