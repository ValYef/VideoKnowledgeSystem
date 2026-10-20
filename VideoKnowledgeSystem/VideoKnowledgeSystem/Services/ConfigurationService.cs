using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoKnowledgeSystem.Services
{
    public static class ConfigurationService
    {
        public static IConfiguration Configuration { get; }

        static ConfigurationService()
        {
            Configuration=new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}
