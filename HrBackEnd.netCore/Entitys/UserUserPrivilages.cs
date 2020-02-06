using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrBackEnd.netCore.Entitys
{
    public class UserUserPrivilages
    {
        public int idUser { get; set; }
        public int idUserPrivilage { get; set; }

        public bool isOnlyView { get; set; }

        public User userNavigator { get; set; }
        public UserPrivilages userPrivilagesNavigator { get; set; }
    }
}