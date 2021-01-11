namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Runtime.Serialization;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum LegalEntityStatus
    {
        [EnumMember(Value = @"Active")] Active = 0,

        [EnumMember(Value = @"ActivePropsedStrikeOff")]
        ActivePropsedStrikeOff = 1,

        [EnumMember(Value = @"ConvertedClosed")]
        ConvertedClosed = 2,

        [EnumMember(Value = @"Dissolved")] Dissolved = 3,

        [EnumMember(Value = @"InAdministration")]
        InAdministration = 4,

        [EnumMember(Value = @"Liquidation")] Liquidation = 5,

        [EnumMember(Value = @"Receivership")] Receivership = 6,

        [EnumMember(Value = @"TransferredFromUK")]
        TransferredFromUK = 7,

        [EnumMember(Value = @"VoluntaryAgreement")]
        VoluntaryAgreement = 8,

        [EnumMember(Value = @"Verify")] Verify = 9,

        [EnumMember(Value = @"Open")] Open = 10,

        [EnumMember(Value = @"Closed")] Closed = 11
    }
}