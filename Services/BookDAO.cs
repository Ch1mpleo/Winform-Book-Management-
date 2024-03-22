using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookDAO
    {
        //Ko chơi trực tiếp với DB mà thông qua thằng DTO
        BookDTO dto = new BookDTO();
        Book book = new Book();

        public List<Book> GetAllBooks()
        {
            return dto.GetBooks();
        }
        public bool CheckValidateID(int id)
        {
            return book.BookId == id;
        }
        public List<Book> Search(string keyword)
        {
            return dto.GetBooks().Where(
                x => x.BookName.ToString().ToLower().Contains(keyword.ToLower()) || 
                x.Description.ToString().ToLower().Contains(keyword.ToLower())).ToList();
        }
        public void AddBook(Book book)
        {
            dto.Create(book);
        }
        public void UpdateBook(Book book)
        {
            dto.Update(book);
        }
        public void DeleteBook(int id)
        {
            dto.Delete(id);
        }
    }
}
