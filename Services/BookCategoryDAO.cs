using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryDAO
    {
        BookCategoryDTO dto = new BookCategoryDTO();
        public List<BookCategory> GetAllBookCategories()
        {
            return dto.GetAll();
        }
    }
}
