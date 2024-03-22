using Repositories;
using Repositories.Entities;

namespace Services
{
    public class UserAccountDAO
    {
        UserAccountDTO dto = new UserAccountDTO();

        public UserAccount? CheckLogin(string username, string password)
        {
            UserAccount? account = dto.Get(username);
            return (account != null && account.Password == password) ? account : null;
        }
    }
}
