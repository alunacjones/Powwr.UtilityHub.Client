namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BrokerageIndexModel : BrokerageModelBase
    {
        [JsonProperty("countryName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        public static BrokerageIndexModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<BrokerageIndexModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}