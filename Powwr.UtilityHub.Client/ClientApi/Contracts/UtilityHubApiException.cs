namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    [GeneratedCode("NSwag", "13.9.4.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public class UtilityHubApiException<TResult> : UtilityHubApiException
    {
        public UtilityHubApiException(
            string message,
            int statusCode,
            string response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            TResult result,
            Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }

        public TResult Result { get; private set; }
    }

    [GeneratedCode("NSwag", "13.9.4.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public class UtilityHubApiException : Exception
    {
        public UtilityHubApiException(
            string message,
            int statusCode,
            string response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            Exception innerException)
            : base(
                message +
                "\n\nStatus: " +
                statusCode +
                "\nResponse: \n" +
                ((response == null)
                    ? "(null)"
                    : response.Substring(
                        0,
                        response.Length >= 512
                            ? 512
                            : response.Length)),
                innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        public string Response { get; private set; }
        public int StatusCode { get; private set; }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }
}