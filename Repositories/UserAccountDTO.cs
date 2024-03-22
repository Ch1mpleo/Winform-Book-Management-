using Repositories.Entities;

namespace Repositories
{
    public class UserAccountDTO
    {
        BookManagementDBContext db = new BookManagementDBContext();
        public UserAccount? Get(string email)
        {
            return db.UserAccounts.FirstOrDefault(x => x.Email == email);
        }
    }
}
