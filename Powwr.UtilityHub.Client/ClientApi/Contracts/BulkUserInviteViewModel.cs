namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BulkUserInviteViewModel
    {
        [JsonProperty("inviteSettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UserInviteContextModel InviteSettings { get; set; }
        [JsonProperty("userIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> UserIds { get; set; }

        public static BulkUserInviteViewModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<BulkUserInviteViewModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}