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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            UserAccountDAO dao = new UserAccountDAO();

            //Gọi hàm CheckLogin từ DAO
            UserAccount? account = dao.CheckLogin(email, password);
            

            if (account == null)
            {
                MessageBox.Show("Please enter your username & password", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } 
            if (account != null)
            {
                if (account.Role == 1)
                {
                    MessageBox.Show("Welcome " + account.FullName + "!", "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListBookForm bookForm = new ListBookForm();
                    bookForm.ShowDialog();
                } else
                {
                    MessageBox.Show("Welcome " + account.FullName + "! \n Our service not done, please comeback when it's finished" , "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //TO-DO: Add more roles
            }
            this.Hide();
          
        }


    }
}