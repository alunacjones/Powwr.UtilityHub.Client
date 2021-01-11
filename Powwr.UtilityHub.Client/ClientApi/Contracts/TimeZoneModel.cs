namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class TimeZoneModel
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("timeZoneId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneId { get; set; }

        public static TimeZoneModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<TimeZoneModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}