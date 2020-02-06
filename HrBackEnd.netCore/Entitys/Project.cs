using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrBackEnd.netCore.Entitys
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProject { get; set; }
        public string projectName { get; set; }

        public ICollection<ProjectSession> projectSessionNavigator { get; set; }
    }
}