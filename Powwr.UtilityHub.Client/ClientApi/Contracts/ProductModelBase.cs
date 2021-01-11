namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class ProductModelBase : ProductModelValidationBase
    {
        [JsonProperty("name", Required = Required.Always)]
        [Required]
        public string Name { get; set; }

        public static ProductModelBase FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ProductModelBase>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}