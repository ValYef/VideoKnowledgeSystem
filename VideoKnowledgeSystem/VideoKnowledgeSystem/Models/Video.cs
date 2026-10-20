using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKnowledgeSystem.Models
{
    public class Video
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public DateTime UploadedAt { get; set; }

        public ProcessingStatus Status { get; set; }
    }
    public enum ProcessingStatus
    {
        Uploaded,
        ExtractingFrames,
        OCRProcessing,
        VisionProcessing,
        Completed,
        Failed
    }
}
