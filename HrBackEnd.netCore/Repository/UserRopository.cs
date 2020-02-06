using HrBackEnd.netCore.Entitys;
using HrBackEnd.netCore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrBackEnd.netCore.Repository
{
    public class UserRopository : IUserRepository
    {
        private HRDBContext_12 _context;

        public UserRopository(HRDBContext_12 context)
        {
            this._context = context;
        }

        public void SaveUser(User newUser)
        {
            _context.Add(newUser);
            _context.SaveChanges();
        }
    }
}
