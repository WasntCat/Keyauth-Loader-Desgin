namespace PublicLoaderDesgin
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginButton = new System.Windows.Forms.Button();
            this.KeyInputLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewUserText = new System.Windows.Forms.Label();
            this.GoBackText = new System.Windows.Forms.Label();
            this.RegistorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.Honeydew;
            this.LoginButton.Location = new System.Drawing.Point(78, 391);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(192, 36);
            this.LoginButton.TabIndex = 28;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // KeyInputLabel
            // 
            this.KeyInputLabel.BorderColor = System.Drawing.Color.Honeydew;
            this.KeyInputLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyInputLabel.DefaultText = "";
            this.KeyInputLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyInputLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyInputLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyInputLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyInputLabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.KeyInputLabel.FocusedState.BorderColor = System.Drawing.Color.Crimson;
            this.KeyInputLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeyInputLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.KeyInputLabel.HoverState.BorderColor = System.Drawing.Color.Crimson;
            this.KeyInputLabel.Location = new System.Drawing.Point(66, 350);
            this.KeyInputLabel.Name = "KeyInputLabel";
            this.KeyInputLabel.PasswordChar = '\0';
            this.KeyInputLabel.PlaceholderForeColor = System.Drawing.Color.Honeydew;
            this.KeyInputLabel.PlaceholderText = "";
            this.KeyInputLabel.SelectedText = "";
            this.KeyInputLabel.Size = new System.Drawing.Size(216, 35);
            this.KeyInputLabel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.KeyInputLabel.TabIndex = 27;
            this.KeyInputLabel.Visible = false;
            // 
            // NewUserText
            // 
            this.NewUserText.AutoSize = true;
            this.NewUserText.ForeColor = System.Drawing.Color.Honeydew;
            this.NewUserText.Location = new System.Drawing.Point(121, 430);
            this.NewUserText.Name = "NewUserText";
            this.NewUserText.Size = new System.Drawing.Size(102, 13);
            this.NewUserText.TabIndex = 31;
            this.NewUserText.Text = "New User? Register";
            this.NewUserText.Click += new System.EventHandler(this.NewUserText_Click);
            // 
            // GoBackText
            // 
            this.GoBackText.AutoSize = true;
            this.GoBackText.ForeColor = System.Drawing.Color.Honeydew;
            this.GoBackText.Location = new System.Drawing.Point(150, 430);
            this.GoBackText.Name = "GoBackText";
            this.GoBackText.Size = new System.Drawing.Size(49, 13);
            this.GoBackText.TabIndex = 32;
            this.GoBackText.Text = "Go Back";
            this.GoBackText.Visible = false;
            this.GoBackText.Click += new System.EventHandler(this.GoBackText_Click);
            // 
            // RegistorButton
            // 
            this.RegistorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.RegistorButton.FlatAppearance.BorderSize = 0;
            this.RegistorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistorButton.ForeColor = System.Drawing.Color.Honeydew;
            this.RegistorButton.Location = new System.Drawing.Point(78, 391);
            this.RegistorButton.Name = "RegistorButton";
            this.RegistorButton.Size = new System.Drawing.Size(192, 36);
            this.RegistorButton.TabIndex = 33;
            this.RegistorButton.Text = "Register";
            this.RegistorButton.UseVisualStyleBackColor = false;
            this.RegistorButton.Visible = false;
            this.RegistorButton.Click += new System.EventHandler(this.RegistorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(115, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 42);
            this.label2.TabIndex = 35;
            this.label2.Text = "Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(101, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "Loader";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistorButton);
            this.Controls.Add(this.GoBackText);
            this.Controls.Add(this.NewUserText);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.KeyInputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox KeyInputLabel;
        private System.Windows.Forms.Label NewUserText;
        private System.Windows.Forms.Label GoBackText;
        private System.Windows.Forms.Button RegistorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

