using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKnowledgeSystem.Configuration
{
    public class AppSettings
    {
        public ServicesSettings Services { get; set; } = new();

        public StorageSettings Storage { get; set; } = new();

        public KnowledgeBaseSettings KnowledgeBase { get; set; } = new();
    }
}
