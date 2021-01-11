namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class AssignBrokerageSupplierModel
    {
        [JsonProperty("brokerageId", Required = Required.Always)]
        public int BrokerageId { get; set; }

        [JsonProperty("supplierId", Required = Required.Always)]
        public int SupplierId { get; set; }

        public static AssignBrokerageSupplierModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<AssignBrokerageSupplierModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}