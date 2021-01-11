namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class CreateUserModel
    {
        [JsonProperty("brokerages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserOrganisationAssignment> Brokerages { get; set; }

        [JsonProperty("email", Required = Required.Always)]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }
        [JsonProperty("fullName", Required = Required.Always)]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FullName { get; set; }

        [JsonProperty("inviteSettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UserInviteContextModel InviteSettings { get; set; }

        [JsonProperty("sendConfirmationEmail", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendConfirmationEmail { get; set; }

        [JsonProperty("suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserOrganisationAssignment> Suppliers { get; set; }

        public static CreateUserModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<CreateUserModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}