using Repositories.Entities;
using Services;
using System.Net;
using System.Windows.Forms;

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
                dtpPublicationDate.Value = selectedBook.PublicationDate;

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
            Book b = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Author = txtAuthor.Text,
                Price = double.Parse(txtPrice.Text),
                BookCategoryId = int.Parse(cbCategory.SelectedValue.ToString()),
            };

            //gửi xuống DB thông qua service
            if (selectedBook == null)
            {
                bookDAO.AddBook(b);
                MessageBox.Show("Add successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bookDAO.UpdateBook(b);
                MessageBox.Show("Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            //cho dù new/edit thì xong phỉa tắt màn hình detail
            Close();
            //đóng màn hình detail thì phải F5 cái lưới grid
            //Bên main form phải refresh lưới ở ngay sau chỗ gọi detail
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

