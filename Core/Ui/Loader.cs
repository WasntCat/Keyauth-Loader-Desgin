using System;
using System.Drawing;
using System.Windows.Forms;

namespace PublicLoaderDesgin.Core.Ui
{
    public partial class Loader : Form
    {
        #region Form
        public Loader()
        {
            InitializeComponent();
        }
        private void Loader_Load(object sender, EventArgs e)
        {
            this.Size = new Size(785, 450);

            label1.Text = Environment.UserName;


            Login login = new Login();

            label11.Text = login.AuthCheck.user_data.hwid;
            label12.Text = login.AuthCheck.user_data.ip;
        }
        #endregion


        #region Panel Selector Button
        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;

            DownloadLoadPanel.Visible = false;
            LoggerPanel.Visible = false;
            SettingsPanel.Visible = false;

            Logger.Text += " [+] Opened Home Panel" + Environment.NewLine;
        }
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DownloadLoadPanel.Location = new Point(55, 87);
            DownloadLoadPanel.Visible = true;

            HomePanel.Visible = false;
            LoggerPanel.Visible = false;
            SettingsPanel.Visible = false;

            Logger.Text += " [+] Opened Download Panel" + Environment.NewLine;
        }

        // Logger Panel Button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoggerPanel.Location = new Point(55, 87);
            LoggerPanel.Visible = true;


            HomePanel.Visible = false;
            DownloadLoadPanel.Visible = false;
            SettingsPanel.Visible = false;

            Logger.Text += " [+] Opened Logger Panel" + Environment.NewLine;
        }

        // Settings Panel Button
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SettingsPanel.Location = new Point(151, 87);
            SettingsPanel.Visible = true;


            HomePanel.Visible = false;
            DownloadLoadPanel.Visible = false;
            LoggerPanel.Visible = false;

            Logger.Text += " [+] Opened Settings Panel" + Environment.NewLine;
        }

        private void CloseBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinBt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Load Software Button
        private void dwn1_Click(object sender, EventArgs e)
        {
            Logger.Text += " [+] Starting to Load Software [1]" + Environment.NewLine;
        }
        private void dwn2_Click(object sender, EventArgs e)
        {
            Logger.Text += " [+] Starting to Load Software [2]" + Environment.NewLine;
        }
        private void dwn3_Click(object sender, EventArgs e)
        {
            Logger.Text += " [+] Starting to Load Software [3]" + Environment.NewLine;
        }
        #endregion

    }
}
