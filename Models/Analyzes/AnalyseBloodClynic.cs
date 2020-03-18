using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorMicroservice.Models.Analyzes
{
    public class AnalyseBloodClynic
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public double Hemoglobin { get; set; }
        public double Erythrocyte { get; set; }
        public double Leukocyte { get; set; }
        public double Platelet { get; set; }
    }
}
