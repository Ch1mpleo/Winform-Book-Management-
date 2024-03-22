using Repositories.Entities;

namespace Repositories
{
    public class BookCategoryDTO
    {
        BookManagementDBContext db = new BookManagementDBContext();
        public List<BookCategory> GetAll()
        {
            return db.BookCategories.ToList();
        }
    }
}
