using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrBackEnd.netCore.Entitys
{
    public class CandidateHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idHistory { get; set; }
        public int idCandidate { get; set; }
        // consult on how to keep the job_post in history
        public string jsonChangesHistory { get; set; }

        public Candidate candidateNavigator { get; set; }

    }
}