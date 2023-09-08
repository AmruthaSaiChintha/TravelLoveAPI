using TravelLove.Models;
using Microsoft.AspNetCore.Mvc;

namespace TravelLove.Repository.RegisterUsersRepository
{
    public interface IRegisterUsersRepository
    {
        Task<ActionResult<IEnumerable<RegisterUser>>> Getusers();
        Task<ActionResult<RegisterUser>> GetRegisterUser(int id);
        Task<ActionResult<RegisterUser>> GetRegisterUserByPwd(string email, string password);
        Task<ActionResult<RegisterUser>> PostRegisterUser(RegisterUser registerUser);
        Task<ActionResult<RegisterUser>> DeleteRegisterUser(int id);
        bool RegisterUserExists(int id);
    }
}