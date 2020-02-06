using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrBackEnd.netCore.Entitys
{
    public class ProjectSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProjectSession { get; set; }
        public DateTime startDateSession { get; set; }
        public DateTime endDateSession { get; set; }

        public int idProject { get; set; }

        public Project projectNavigator { get; set; }

        public ICollection<CandidateProjectSession> candidatesProjectSessionNavigator { get; set; }
        
    }
}