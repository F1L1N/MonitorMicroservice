using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorMicroservice.Models.Analyzes
{
    public class Analyse
    {
        public List<AnalyseBloodBio> AnalyseBloodBio { get; set; }

        public List<AnalyseBloodClynic> AnalyseBloodClynic { get; set; }

        public List<AnalyseBloodGroup> AnalyseBloodGroup { get; set; }

        public List<AnalyseCoprogram> AnalyseCoprogram { get; set; }

        public List<AnalyseIFA> AnalyseIFA { get; set; }

        public List<AnalyseUrine> AnalyseUrine { get; set; }
    }
}
