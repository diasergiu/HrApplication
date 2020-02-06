using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrBackEnd.netCore.Entitys
{
    public class CandidateProjectSession
    {
        public int idCandidate { get; set; }
        public int idProjectSession { get; set; }

        public Candidate candidateNavigator { get; set; }
        public ProjectSession projectSessionNavigator { get; set; }
    }
}
