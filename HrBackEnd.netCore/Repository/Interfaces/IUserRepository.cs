using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrBackEnd.netCore.Entitys;

namespace HrBackEnd.netCore.Repository.Interfaces
{
    public interface IUserRepository
    {
        void SaveUser(User newUser);
    }
}
