namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    [GeneratedCode("NSwag", "13.9.4.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public class UtilityHubResponse
    {
        public UtilityHubResponse(int statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers)
        {
            StatusCode = statusCode;
            Headers = headers;
        }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }
        public int StatusCode { get; private set; }
    }
}