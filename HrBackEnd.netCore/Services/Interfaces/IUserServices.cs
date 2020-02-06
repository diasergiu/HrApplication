using HrBackEnd.netCore.DTOs;

namespace HrBackEnd.netCore.Services.Interfaces
{
    public interface IUserServices
    {
        void SaveUserFromUserDTO(UserDTO user);
    }
}
