using MyTodoist.Data;
using System.Threading.Tasks;

namespace MyTodoist.IService
{
    public interface IUserRegistrationService
    {
        Task<bool> SaveUserRegistration(UserRegistration userRegistration);
    }
}
