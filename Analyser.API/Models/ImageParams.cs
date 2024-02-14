namespace Analyser.API.Models
{
    public class ImageParams
    {
        public string RemoteFullPath { get; set; }
        public int MaxLabels { get; set; }
        public int MinConfidenceLevel { get; set; }
    }
}
