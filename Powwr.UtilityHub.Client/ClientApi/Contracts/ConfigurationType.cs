namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Runtime.Serialization;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ConfigurationType
    {
        [EnumMember(Value = @"SupplierBrokerage")]
        SupplierBrokerage = 0,

        [EnumMember(Value = @"Supplier")] Supplier = 1,

        [EnumMember(Value = @"Brokerage")] Brokerage = 2
    }
}