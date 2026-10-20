using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKnowledgeSystem.Models
{
    public class KnowledgeItem
    {
        public Guid Id { get; set; }

        public Guid VideoId { get; set; }

        public TimeSpan Timestamp { get; set; }

        public string FrameType { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;

        public List<string> Keywords { get; set; } = new();

        public KnowledgeSource Source { get; set; }

        public double Confidence { get; set; }
    }
    public enum KnowledgeSource
    {
        OCR,
        Vision,
        Speech
    }
}
