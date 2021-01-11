namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BrokerageNameIdModel
    {
        [JsonProperty("brokerageId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerageId { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        public static BrokerageNameIdModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<BrokerageNameIdModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}