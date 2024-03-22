using Repositories.Entities;
using Services;

namespace GUI
{
    public partial class BookDetailForm : Form
    {
        BookDAO bookDAO = new BookDAO();
        BookCategoryDAO bookCategoryDAO = new BookCategoryDAO();
        public Book? selectedBook { get; set; } = null;
        //biến này dùng để kiểm tra xem form này được bật lên để add hay update

        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //Fill vào comboBox
            cbCategory.DataSource = bookCategoryDAO.GetAllBookCategories();
            cbCategory.DisplayMember = "BookGenreType";
            cbCategory.ValueMember = "BookCategoryId";

            //Check giá trị selectedBook xem có phải null hay không để biết là add hay update
            if (selectedBook != null)
            {
                lblHeader.Text = "Update Book";
                //Đúng thì fill đầy đủ data vào form
                txtBookId.Text = selectedBook.BookId.ToString();
                txtName.Text = selectedBook.BookName.ToString();
                txtAuthor.Text = selectedBook.Author.ToString();
                txtDescription.Text = selectedBook.Description.ToString();
                txtPrice.Text = selectedBook.Price.ToString();
                txtQuantity.Text = selectedBook.Quantity.ToString();
                //dtpPublicationDate.Value = selectedBook.PublicationDate;
                //To - do: add thêm fill vào dtpPublicationDate

                //fill vào comboBox
                cbCategory.SelectedValue = selectedBook.BookCategoryId;
            } 
            else
            {
                lblHeader.Text = "Add Book";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            if (selectedBook == null) //ktr nếu nó bằng null thì là add
            {
                b.BookId = selectedBook.BookId;
                b.BookName = txtName.Text;
                b.Author = txtAuthor.Text;
                b.Description = txtDescription.Text;
                //b.PublicationDate = dtpPublicationDate.Value;
                b.Price = Convert.ToDouble(txtPrice.Text);
                b.Quantity = Convert.ToInt32(txtQuantity.Text);
                b.BookCategoryId = Convert.ToInt32(cbCategory.SelectedValue);
                //gọi hàm add
                bookDAO.AddBook(b);
            } 
            else   //nếu ko thì cho nó update
            {
                bookDAO.UpdateBook(b);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
