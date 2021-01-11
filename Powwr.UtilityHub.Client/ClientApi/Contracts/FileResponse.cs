namespace UtilityHub.Client.ClientApi.Contracts
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;

    [GeneratedCode("NSwag", "13.9.4.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public class FileResponse : IDisposable
    {
        private IDisposable _client;
        private IDisposable _response;

        public FileResponse(
            int statusCode,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            Stream stream,
            IDisposable client,
            IDisposable response)
        {
            StatusCode = statusCode;
            Headers = headers;
            Stream = stream;
            _client = client;
            _response = response;
        }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        public bool IsPartial => StatusCode == 206;

        public int StatusCode { get; private set; }

        public Stream Stream { get; private set; }

        public void Dispose()
        {
            Stream.Dispose();
            if (_response != null)
                _response.Dispose();
            if (_client != null)
                _client.Dispose();
        }
    }
}