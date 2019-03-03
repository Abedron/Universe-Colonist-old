namespace Tooling.DefinitionLoaderTool
{
    public class DefinitionVo
    {
        public string Uri { get; set; }
        public string Path { get; set; }

        public DefinitionVo(string uri, string path)
        {
            Uri = uri;
            Path = path;
        }
    }
}
