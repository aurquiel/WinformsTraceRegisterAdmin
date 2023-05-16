namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUserAlias = new TextBox();
            textBoxUserPassword = new TextBox();
            buttonLogin = new Button();
            buttonClose = new Button();
            textBoxStatus = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = Properties.Resources.logoMundoTotalGrande;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(423, 158);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 179);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 225);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // textBoxUserAlias
            // 
            textBoxUserAlias.Location = new Point(145, 181);
            textBoxUserAlias.Name = "textBoxUserAlias";
            textBoxUserAlias.Size = new Size(257, 23);
            textBoxUserAlias.TabIndex = 0;
            // 
            // textBoxUserPassword
            // 
            textBoxUserPassword.Location = new Point(145, 225);
            textBoxUserPassword.Name = "textBoxUserPassword";
            textBoxUserPassword.Size = new Size(257, 23);
            textBoxUserPassword.TabIndex = 1;
            textBoxUserPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.Green;
            buttonLogin.Image = Properties.Resources.login;
            buttonLogin.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogin.Location = new Point(190, 301);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(103, 41);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Entrar";
            buttonLogin.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.Red;
            buttonClose.Image = Properties.Resources.cancel;
            buttonClose.ImageAlign = ContentAlignment.MiddleRight;
            buttonClose.Location = new Point(299, 301);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(103, 41);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Salir";
            buttonClose.TextAlign = ContentAlignment.MiddleLeft;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Location = new Point(145, 261);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(256, 16);
            textBoxStatus.TabIndex = 7;
            textBoxStatus.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(423, 369);
            Controls.Add(textBoxStatus);
            Controls.Add(buttonClose);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxUserPassword);
            Controls.Add(textBoxUserAlias);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label label1;
        private Label label2;
        private TextBox textBoxUserAlias;
        private TextBox textBoxUserPassword;
        private Button buttonLogin;
        private Button buttonClose;
        private TextBox textBoxStatus;
    }
}