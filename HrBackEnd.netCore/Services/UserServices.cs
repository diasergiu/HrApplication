using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrBackEnd.netCore.DTOs;
using HrBackEnd.netCore.Entitys;
using HrBackEnd.netCore.Repository;
using HrBackEnd.netCore.Repository.Interfaces;
using HrBackEnd.netCore.Services.Interfaces;

namespace HrBackEnd.netCore.Services
{
    public class UserServices : IUserServices
    {

        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public void SaveUserFromUserDTO(UserDTO user)
        {
            User newUser = new User() {
                userName = user.userName,
                firstName = user.lastName,
                lastName = user.lastName
            };
            newUser.password = EncriptPassword(user.password);
            //newUser.profileImage = Serialize(user.ProfileImage);

            _userRepository.SaveUser(newUser);
        }

        private byte[] EncriptPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
