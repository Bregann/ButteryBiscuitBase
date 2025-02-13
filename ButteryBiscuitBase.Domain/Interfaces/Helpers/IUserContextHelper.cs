using ButteryBiscuitBase.Domain.Data.Database.Models;

namespace ButteryBiscuitBase.Domain.Interfaces.Helpers
{
    public interface IUserContextHelper
    {
        string GetUserId();
        string GetUserFirstName();
        User GetUser();
    }
}
