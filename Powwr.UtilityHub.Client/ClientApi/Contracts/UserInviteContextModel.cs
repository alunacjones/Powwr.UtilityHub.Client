namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserInviteContextModel
    {
        [JsonProperty("inviteBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string InviteBy { get; set; }

        [JsonProperty("organisationName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationName { get; set; }

        [JsonProperty("portfolioName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PortfolioName { get; set; }

        [JsonProperty("productName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        [JsonProperty("returnUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }
        
        public static UserInviteContextModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserInviteContextModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}