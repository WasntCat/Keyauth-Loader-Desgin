using PublicLoaderDesgin.Core.Functions.Authentication;
using PublicLoaderDesgin.Core.Ui;
using System;
using System.IO;
using System.Windows.Forms;

namespace PublicLoaderDesgin
{
    public partial class Login : Form
    {
        #region Calls
        public api AuthCheck = new api(
        name: "",
        ownerid: "",
        secret: "",
        version: "1.0"
        );
        #endregion

        #region Form
        public Login()
        {
            InitializeComponent();      
        }
        private void Login_Load(object sender, EventArgs e)
        {
            AuthCheck.init();
        }
        #endregion

        #region Buttons
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Windows\Loader.Pub"))
            {
                string file = File.ReadAllText(@"C:\Windows\Loader.Pub");
                AuthCheck.license(file);
                if (AuthCheck.response.success)
                {

                    Loader Loader = new Loader();
                    Loader.Show();
                    this.Hide();
                }
                else
                {
                    File.Delete(@"C:\Windows\Loader.Pub");
                }
            }
        }
        private void RegistorButton_Click(object sender, EventArgs e)
        {
            AuthCheck.register(KeyInputLabel.Text, KeyInputLabel.Text, KeyInputLabel.Text);
            if (AuthCheck.response.success)
            {
                var UserKey = KeyInputLabel.Text;
                AuthCheck.license(UserKey);

                File.Create(@"C:\Windows\Loader.Pub").Dispose();
                File.WriteAllText(@"C:\Windows\Loader.Pub", UserKey);

                Loader Loader = new Loader();
                Loader.Show();
                this.Hide();
            }
            else
            {

            }
        }
        #endregion

        #region Labels
        private void GoBackText_Click(object sender, EventArgs e)
        {
            LoginButton.Visible = true;
            NewUserText.Visible = true;

            GoBackText.Visible = false;
            RegistorButton.Visible = false;
            KeyInputLabel.Visible = false;
        }
        private void NewUserText_Click(object sender, EventArgs e)
        {
            LoginButton.Visible = false;
            NewUserText.Visible = false;

            GoBackText.Visible = true;
            RegistorButton.Visible = true;
            KeyInputLabel.Visible = true;
        }
        #endregion
    }
}
