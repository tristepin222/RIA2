namespace Analyser.API.Models
{
    public class AnalyserParam
    {
        public string RemoteFullPath { get; set; }
        public int MaxLabels { get; set; }
        public int MinConfidenceLevel { get; set; }
    }
}
