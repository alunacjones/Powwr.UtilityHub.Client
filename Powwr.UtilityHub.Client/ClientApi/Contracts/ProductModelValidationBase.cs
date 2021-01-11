namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ProductModelValidationBase
    {
        [JsonProperty("configuration", Required = Required.Always)]
        [Required]
        public object Configuration { get; set; }
        [JsonProperty("productId", Required = Required.Always)]
        [Required]
        public string ProductId { get; set; }

        public static ProductModelValidationBase FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ProductModelValidationBase>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}