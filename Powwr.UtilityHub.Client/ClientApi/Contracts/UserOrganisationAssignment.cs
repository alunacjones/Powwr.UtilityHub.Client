namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserOrganisationAssignment
    {
        [JsonProperty("organisationId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrganisationId { get; set; }

        [JsonProperty("organisationPowwrId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OrganisationPowwrId { get; set; }

        [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        public static UserOrganisationAssignment FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserOrganisationAssignment>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}