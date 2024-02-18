using Google.Cloud.Vision.V1;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Analyser.API.Models;

namespace Analyser.API.Services
{
    public class GoogleLabelDetectorImpl : ILabelDetector
    {
        ImageAnnotatorClient client;
        public GoogleLabelDetectorImpl()
        {
            client = ImageAnnotatorClient.Create();
        }
        public async Task<IImageData> Analyze(string imageString, int labelAmount = 10, int minConfidenceAmount = 90)
        {
            List<string> labels = new List<string>();
            List<float> confidences = new List<float>();
            Image image = Image.FromFile(imageString);
            IReadOnlyList<EntityAnnotation> results = await client.DetectLabelsAsync(image, maxResults: labelAmount);
            int index = 0;
            foreach (EntityAnnotation result in results)
            {
                if (result.Score * 100 >= minConfidenceAmount && index <= labelAmount)
                {
                    confidences.Add(result.Score * 100);
                    labels.Add(result.Description);
                }
                index++;
            }
            return new GoogleImageData(imageString, labels.ToArray(), confidences.ToArray());
        }
    }
}