using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace HrBackEnd.netCore.Entitys
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public byte[] password { get; set; }
        public byte[] profileImage { get; set; }
        
        public virtual ICollection<UserUserPrivilages> userUserPrivilagesNavigator { get; set; }

    }
}
