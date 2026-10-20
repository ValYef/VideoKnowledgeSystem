using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKnowledgeSystem.Configuration
{
    public class ServicesSettings
    {
        public string Gateway { get; set; } = string.Empty;

        public string OCR { get; set; } = string.Empty;

        public string Vision { get; set; } = string.Empty;

        public string Knowledge { get; set; } = string.Empty;
    }
}
