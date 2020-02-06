using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrBackEnd.netCore.Entitys
{
    public class UserPrivilages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUserPrivilage { get; set; }
        public string domain { get; set; }

        public virtual ICollection<UserUserPrivilages> usersUserPrivilagesNavigator {get;set;}
    }
}