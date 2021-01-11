namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public class BrokerageEditModel : BrokerageModelBase
    {
        [JsonProperty("brokerageSuppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BrokerageSupplierModel> BrokerageSuppliers { get; set; }
        [JsonProperty("isCreated", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCreated { get; set; }

        public static BrokerageEditModel FromJson(string data)
        {
            return JsonConvert.DeserializeObject<BrokerageEditModel>(data);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}