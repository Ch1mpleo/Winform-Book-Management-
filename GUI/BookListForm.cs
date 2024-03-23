using Repositories.Entities;
using Services;

namespace GUI
{
    public partial class ListBookForm : Form
    {
        BookDAO dao = new BookDAO();
        public Book? selected = null;   //chờ ai đó ấn nút grid view 
                                        //và gán dòng đó cho biến để dễ dàng mang qua lại giữa detail và list 

        public ListBookForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm để refresh lại form
        /// </summary>
        public void RefreshForm()
        {
            var result = dao.GetAllBooks();
            dtgBookList.DataSource = null;
            dtgBookList.DataSource = result;
        }

        /// <summary>
        /// Mỗi lần bật form, form sẽ load theo hàm này -> click 2 lần vào form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBookForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            //Giấu cột BookCategoryId vì ko cần thiết
            dtgBookList.Columns["BookCategoryId"].Visible = false;
        }

        private void dtgBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshForm();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) && (string.IsNullOrEmpty(txtDescription.Text)))
            {
                MessageBox.Show("Please enter the keyword to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var searchName = dao.Search(txtName.Text.Trim());
            var searchDescription = dao.Search(txtDescription.Text.Trim());

            //Nếu search 1 khác search 2 thì gộp 2 list lại
            if (searchName != searchDescription)
            {
                searchName.AddRange(searchDescription);
            }
            dtgBookList.DataSource = null;
            dtgBookList.DataSource = searchName;

            // Nếu ko có sách
            if (dtgBookList.Rows.Count == 0)
            {
                MessageBox.Show("No book is displayed! Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookDetailForm bookDetail = new BookDetailForm();
            bookDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgBookList.SelectedRows.Count > 0)  //Kiểm tra xem user có chọn dòng nào không
            {
                //Lấy ra cuốn sách đang chọn và ép kiểu Book
                selected = (Book)dtgBookList.SelectedRows[0].DataBoundItem;
                dao.DeleteBook(selected.BookId);
                MessageBox.Show("Delete successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Gọi lại để cập nhật form sau khi đã xóa
                RefreshForm();
            }
        }
        private void dtgBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgBookList.SelectedRows.Count > 0)
            {
                selected = (Book)dtgBookList.SelectedRows[0].DataBoundItem;
                //với mỗi row trong grid là 1 obj nên ta có thể ép kiểu về book
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                BookDetailForm bd = new BookDetailForm();
                bd.selectedBook = selected; //truyền dòng đã chọn qua form detail thông qua biến selectedBook 
                bd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a book to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }


    }
}
