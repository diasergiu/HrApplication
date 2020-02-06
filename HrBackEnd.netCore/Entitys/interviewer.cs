using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;   
using System.Threading.Tasks;

namespace HrBackEnd.netCore.Entitys
{
    public class Interviewer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idInterviewer { get; set; }
        public string interviewerName { get; set; }
       
        public ICollection<CandidateInterviewer> candidatesInterviewerNavigator { get;set; }
    }
}
