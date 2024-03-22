using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories
{
    public class BookDTO
    {
        BookManagementDBContext db = new BookManagementDBContext();
        public List<Book> GetBooks()
        {
            return db.Books
                //TO-DO: Add thêm cột BookGenreType vào bảng Book

                .ToList();
        }
        public Book? Get(int BookId)
        {
            return db.Books.FirstOrDefault(x => x.BookId == BookId);
        }
        public void Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }
        public void Update(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
        }
        public void Delete(int BookId)
        {
            var book = db.Books.FirstOrDefault(x => x.BookId == BookId);
            db.Books.Remove(book);
            db.SaveChanges();
        }
    }
}
