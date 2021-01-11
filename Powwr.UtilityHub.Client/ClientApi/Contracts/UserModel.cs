namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserModel : UserModelBase
    {
        [JsonProperty("brokerages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserBrokerageModel> Brokerages { get; set; }

        [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; }

        [JsonProperty("identityRoles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> IdentityRoles { get; set; }

        [JsonProperty("isAdminUser", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdminUser { get; set; }

        [JsonProperty("isDeactivated", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeactivated { get; set; }

        [JsonProperty("isLockedOut", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLockedOut { get; set; }

        [JsonProperty("lastUpdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; }
        [JsonProperty("lockoutEnd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LockoutEnd { get; set; }

        [JsonProperty("pendingEmailValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PendingEmailValue { get; set; }

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserSupplierModel> Suppliers { get; set; }

        public static UserModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}