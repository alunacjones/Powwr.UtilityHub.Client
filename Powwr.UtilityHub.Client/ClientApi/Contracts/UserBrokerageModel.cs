namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserBrokerageModel
    {
        [JsonProperty("brokerageId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerageId { get; set; }

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("externalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("phoneNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        public static UserBrokerageModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserBrokerageModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}