namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class UserModelBase : IEquatable<UserModelBase>
    {
        [JsonProperty("email", Required = Required.Always)]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }
        [JsonProperty("fullName", Required = Required.Always)]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FullName { get; set; }

        [JsonProperty("userId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; protected set; }

        public static UserModelBase FromJson(string data)
        {
            return JsonConvert.DeserializeObject<UserModelBase>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <inheritdoc />
        public bool Equals(UserModelBase other)
        {
            if (ReferenceEquals(null, other))
                return false;
            
            return ReferenceEquals(this, other) || Equals(UserId, other.UserId);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || (obj is UserModelBase other && Equals(other));
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return UserId.GetHashCode();
            }
        }

        public static bool operator ==(UserModelBase left, UserModelBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserModelBase left, UserModelBase right)
        {
            return !Equals(left, right);
        }
    }
}