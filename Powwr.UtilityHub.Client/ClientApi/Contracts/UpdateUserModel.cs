namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UpdateUserModel
    {
        public UpdateUserModel(UserModel user)
        {
            var json = user.ToJson();
            JsonConvert.PopulateObject(json, this);
        }
        
        [JsonProperty("fullName", Required = Required.Always)]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FullName { get; set; }

        [JsonProperty("isAdminUser", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdminUser { get; set; }
        [JsonProperty("userId", Required = Required.Always)]
        [Required]
        public Guid UserId { get; set; }

        public static UpdateUserModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UpdateUserModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}