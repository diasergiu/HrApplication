using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrBackEnd.netCore.Entitys
{
    public class CandidateInterviewer
    {
        public int idCandidate { get; set; }
        public int idInterviewer { get; set; }

        public Candidate CandidateNavigator { get; set; }
        public Interviewer InterviewerNavigator { get; set; }
    }
}
