using Repositories.Entities;
using Services;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            UserAccountDAO dao = new UserAccountDAO();
            UserAccount account = new UserAccount();

            if (account == null)
            {
                MessageBox.Show("Invalid email or password", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Hide();
            ListBookForm bookForm = new ListBookForm();
            bookForm.ShowDialog();
        }


    }
}