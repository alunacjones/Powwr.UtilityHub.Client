namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Runtime.Serialization;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum CompanyType
    {
        [EnumMember(Value = @"Limited")] Limited = 0,

        [EnumMember(Value = @"PLC")] PLC = 1,

        [EnumMember(Value = @"LimitedLiability")]
        LimitedLiability = 2,

        [EnumMember(Value = @"Partnership")] Partnership = 3,

        [EnumMember(Value = @"Charity")] Charity = 4,

        [EnumMember(Value = @"PublicSector")] PublicSector = 5,

        [EnumMember(Value = @"NonLimited")] NonLimited = 6,

        [EnumMember(Value = @"SoleTrader")] SoleTrader = 7,

        [EnumMember(Value = @"LimitedLiabilityPartnership")]
        LimitedLiabilityPartnership = 8,

        [EnumMember(Value = @"ChurchCommunityOrganisation")]
        ChurchCommunityOrganisation = 9,

        [EnumMember(Value = @"NonProfit")] NonProfit = 10,

        [EnumMember(Value = @"MutualSociety")] MutualSociety = 11,

        [EnumMember(Value = @"RoyalCharter")] RoyalCharter = 12,

        [EnumMember(Value = @"JerseyBased")] JerseyBased = 13,

        [EnumMember(Value = @"OverseasCompany")]
        OverseasCompany = 14,

        [EnumMember(Value = @"Branch")] Branch = 15
    }
}