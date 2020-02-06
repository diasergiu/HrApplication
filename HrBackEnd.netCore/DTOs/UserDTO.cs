using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrBackEnd.netCore.DTOs
{
    public class UserDTO
    {
        public int idUser { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        //public Image profileImmage { get; set; }
    }
}
