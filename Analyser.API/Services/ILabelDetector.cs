using Analyser.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Analyser.API.Services
{
    public interface ILabelDetector
    {
        public abstract Task<IImageData> Analyze(string imageString, int labelAmount = 10, int minConfidenceAmount = 90);
    }
}