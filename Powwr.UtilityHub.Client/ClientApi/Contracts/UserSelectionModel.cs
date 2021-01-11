namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserSelectionModel
    {
        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }
        [JsonProperty("userIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Guid> UserIds { get; set; }

        public static UserSelectionModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserSelectionModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}