namespace UtilityHub.Client.ClientApi.Contracts
{
    using System.CodeDom.Compiler;
    using System.IO;

    [GeneratedCode("NSwag", "13.9.4.0 (NJsonSchema v10.3.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public class FileParameter
    {
        public FileParameter(Stream data)
            : this(data, null, null)
        {
        }

        public FileParameter(Stream data, string fileName)
            : this(data, fileName, null)
        {
        }

        public FileParameter(Stream data, string fileName, string contentType)
        {
            Data = data;
            FileName = fileName;
            ContentType = contentType;
        }

        public string ContentType { get; private set; }

        public Stream Data { get; private set; }

        public string FileName { get; private set; }
    }
}