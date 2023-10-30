using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bulletin_Board_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool thing = UserHelper.Login(tBoxLoginUser.Text, tBoxLoginPass.Text);
            if (thing)
            {
                User u = JsonConvert.DeserializeObject<User>(File.ReadAllText(tBoxLoginUser.Text + ".json"));
                Form1 bruh = new Form1(u);
                bruh.Show();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tBoxRegPass.Text == tBoxRegConfirm.Text)
            {
                string pass = UserHelper.Md5Hash(tBoxRegPass.Text);
                bool thing = UserHelper.Register(tBoxRegUser.Text, pass);

                if (thing)
                {
                    User u = JsonConvert.DeserializeObject<User>(File.ReadAllText(tBoxRegUser.Text + ".json"));
                    Form1 bruh = new Form1(u);
                    bruh.Show();
                }
                else
                {
                    MessageBox.Show("Error registering");
                }


            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }
    }
}
