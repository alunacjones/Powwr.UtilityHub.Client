namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class SupplierIndexModel : SupplierModelBase
    {
        [JsonProperty("countryName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        public static SupplierIndexModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<SupplierIndexModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}