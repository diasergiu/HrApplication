using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace HrBackEnd.netCore.Entitys
{
    public class Candidate
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCandidate { get; set; }      
        public int expectedSalary { get; set; }
        public int salary { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string status { get; set; }
        public byte[] CV { get; set; }
        public byte[] coverLetter { get; set; }
        public DateTime phoneDate { get; set; }
        public DateTime interviewDate { get; set; }
        public DateTime cobyDate { get; set; }        
        public DateTime startDate { get; set; }

        [ForeignKey("JobPost")]
        public int idPostAccepted { get; set; }

        public JobPost postAcceptedNavigator { get; set; }

        public ICollection<CandidateHistory> candidateHistoriesNavigator { get; set; }
        public ICollection<CandidateProjectSession> candidateProjectsSessionsNavigator { get; set; }
        public ICollection<CandidateInterviewer> candidateInterviewersNavigator { get; set; }


    }
}
