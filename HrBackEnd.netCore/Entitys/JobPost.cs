
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrBackEnd.netCore.Entitys
{
    public class JobPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJobPost { get; set; }
        public string jsonChangesHistory { get; set; }
        // from department x works at the domain y on platform z
        public string department { get; set; }
        public string domain { get; set; }
        public string platform { get; set; }
        
        public ICollection<Candidate> candidatesNavigator { get; set; }

    }
}