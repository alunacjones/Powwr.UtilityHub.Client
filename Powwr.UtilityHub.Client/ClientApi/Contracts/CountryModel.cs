namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CountryModel
    {
        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        public static CountryModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<CountryModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}