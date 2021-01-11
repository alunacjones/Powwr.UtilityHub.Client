namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UpdateUserEmailModel
    {
        [JsonProperty("email", Required = Required.Always)]
        [Required]
        public string Email { get; set; }
        [JsonProperty("userId", Required = Required.Always)]
        [Required]
        public Guid UserId { get; set; }

        public static UpdateUserEmailModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UpdateUserEmailModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}