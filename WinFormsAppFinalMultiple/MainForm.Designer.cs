namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxInit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBoxStatusMessages = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRoles = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonSupervisor = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.panelRegisterSubmenu = new System.Windows.Forms.Panel();
            this.buttonRegisterSupervisor = new System.Windows.Forms.Button();
            this.buttonRegisterStore = new System.Windows.Forms.Button();
            this.buttonRegisters = new System.Windows.Forms.Button();
            this.panelReporteSubmenu = new System.Windows.Forms.Panel();
            this.buttonReportSupervisor = new System.Windows.Forms.Button();
            this.buttonReportStore = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRegisterSubmenu.SuspendLayout();
            this.panelReporteSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxInit
            // 
            this.pictureBoxInit.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInit.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.operations;
            this.pictureBoxInit.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInit.Name = "pictureBoxInit";
            this.pictureBoxInit.Size = new System.Drawing.Size(984, 715);
            this.pictureBoxInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxInit.TabIndex = 0;
            this.pictureBoxInit.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 715);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 46);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.richTextBoxStatusMessages);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(92, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 46);
            this.panel5.TabIndex = 4;
            // 
            // richTextBoxStatusMessages
            // 
            this.richTextBoxStatusMessages.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBoxStatusMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatusMessages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxStatusMessages.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatusMessages.Name = "richTextBoxStatusMessages";
            this.richTextBoxStatusMessages.ReadOnly = true;
            this.richTextBoxStatusMessages.Size = new System.Drawing.Size(892, 46);
            this.richTextBoxStatusMessages.TabIndex = 0;
            this.richTextBoxStatusMessages.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 46);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTATUS:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonRoles);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonStore);
            this.panel1.Controls.Add(this.buttonSupervisor);
            this.panel1.Controls.Add(this.buttonStatus);
            this.panel1.Controls.Add(this.panelRegisterSubmenu);
            this.panel1.Controls.Add(this.buttonRegisters);
            this.panel1.Controls.Add(this.panelReporteSubmenu);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonReports);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 761);
            this.panel1.TabIndex = 0;
            // 
            // buttonRoles
            // 
            this.buttonRoles.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRoles.FlatAppearance.BorderSize = 0;
            this.buttonRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRoles.ForeColor = System.Drawing.Color.White;
            this.buttonRoles.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.roles;
            this.buttonRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoles.Location = new System.Drawing.Point(0, 606);
            this.buttonRoles.Name = "buttonRoles";
            this.buttonRoles.Size = new System.Drawing.Size(200, 52);
            this.buttonRoles.TabIndex = 11;
            this.buttonRoles.Text = "ROLES";
            this.buttonRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoles.UseVisualStyleBackColor = false;
            this.buttonRoles.Click += new System.EventHandler(this.buttonRoles_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUser.ForeColor = System.Drawing.Color.White;
            this.buttonUser.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.user;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.Location = new System.Drawing.Point(0, 560);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(200, 46);
            this.buttonUser.TabIndex = 8;
            this.buttonUser.Text = "USUARIO";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonStore
            // 
            this.buttonStore.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStore.ForeColor = System.Drawing.Color.White;
            this.buttonStore.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.tienda;
            this.buttonStore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStore.Location = new System.Drawing.Point(0, 514);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(200, 46);
            this.buttonStore.TabIndex = 7;
            this.buttonStore.Text = "TIENDA";
            this.buttonStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStore.UseVisualStyleBackColor = false;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonSupervisor
            // 
            this.buttonSupervisor.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSupervisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupervisor.FlatAppearance.BorderSize = 0;
            this.buttonSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSupervisor.ForeColor = System.Drawing.Color.White;
            this.buttonSupervisor.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.supervisor;
            this.buttonSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSupervisor.Location = new System.Drawing.Point(0, 468);
            this.buttonSupervisor.Name = "buttonSupervisor";
            this.buttonSupervisor.Size = new System.Drawing.Size(200, 46);
            this.buttonSupervisor.TabIndex = 6;
            this.buttonSupervisor.Text = "SUPERVISOR";
            this.buttonSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupervisor.UseVisualStyleBackColor = false;
            this.buttonSupervisor.Click += new System.EventHandler(this.buttonSupervisor_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatus.FlatAppearance.BorderSize = 0;
            this.buttonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatus.ForeColor = System.Drawing.Color.White;
            this.buttonStatus.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.status;
            this.buttonStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatus.Location = new System.Drawing.Point(0, 422);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(200, 46);
            this.buttonStatus.TabIndex = 5;
            this.buttonStatus.Text = "ESTATUS";
            this.buttonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatus.UseVisualStyleBackColor = false;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // panelRegisterSubmenu
            // 
            this.panelRegisterSubmenu.Controls.Add(this.buttonRegisterSupervisor);
            this.panelRegisterSubmenu.Controls.Add(this.buttonRegisterStore);
            this.panelRegisterSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegisterSubmenu.Location = new System.Drawing.Point(0, 330);
            this.panelRegisterSubmenu.Name = "panelRegisterSubmenu";
            this.panelRegisterSubmenu.Size = new System.Drawing.Size(200, 92);
            this.panelRegisterSubmenu.TabIndex = 10;
            // 
            // buttonRegisterSupervisor
            // 
            this.buttonRegisterSupervisor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRegisterSupervisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegisterSupervisor.FlatAppearance.BorderSize = 0;
            this.buttonRegisterSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterSupervisor.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegisterSupervisor.Location = new System.Drawing.Point(0, 46);
            this.buttonRegisterSupervisor.Name = "buttonRegisterSupervisor";
            this.buttonRegisterSupervisor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonRegisterSupervisor.Size = new System.Drawing.Size(200, 46);
            this.buttonRegisterSupervisor.TabIndex = 3;
            this.buttonRegisterSupervisor.Text = "Supervisores";
            this.buttonRegisterSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisterSupervisor.UseVisualStyleBackColor = false;
            this.buttonRegisterSupervisor.Click += new System.EventHandler(this.buttonRegisterSupervisor_Click);
            // 
            // buttonRegisterStore
            // 
            this.buttonRegisterStore.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRegisterStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegisterStore.FlatAppearance.BorderSize = 0;
            this.buttonRegisterStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterStore.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterStore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegisterStore.Location = new System.Drawing.Point(0, 0);
            this.buttonRegisterStore.Name = "buttonRegisterStore";
            this.buttonRegisterStore.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonRegisterStore.Size = new System.Drawing.Size(200, 46);
            this.buttonRegisterStore.TabIndex = 2;
            this.buttonRegisterStore.Text = "Tiendas";
            this.buttonRegisterStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisterStore.UseVisualStyleBackColor = false;
            this.buttonRegisterStore.Click += new System.EventHandler(this.buttonRegisterStore_Click);
            // 
            // buttonRegisters
            // 
            this.buttonRegisters.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRegisters.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegisters.FlatAppearance.BorderSize = 0;
            this.buttonRegisters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisters.ForeColor = System.Drawing.Color.White;
            this.buttonRegisters.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.registro;
            this.buttonRegisters.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegisters.Location = new System.Drawing.Point(0, 284);
            this.buttonRegisters.Name = "buttonRegisters";
            this.buttonRegisters.Size = new System.Drawing.Size(200, 46);
            this.buttonRegisters.TabIndex = 9;
            this.buttonRegisters.Text = "REGISTROS";
            this.buttonRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisters.UseVisualStyleBackColor = false;
            this.buttonRegisters.Click += new System.EventHandler(this.buttonRegisters_Click);
            // 
            // panelReporteSubmenu
            // 
            this.panelReporteSubmenu.Controls.Add(this.buttonReportSupervisor);
            this.panelReporteSubmenu.Controls.Add(this.buttonReportStore);
            this.panelReporteSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReporteSubmenu.Location = new System.Drawing.Point(0, 192);
            this.panelReporteSubmenu.Name = "panelReporteSubmenu";
            this.panelReporteSubmenu.Size = new System.Drawing.Size(200, 92);
            this.panelReporteSubmenu.TabIndex = 4;
            // 
            // buttonReportSupervisor
            // 
            this.buttonReportSupervisor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonReportSupervisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportSupervisor.FlatAppearance.BorderSize = 0;
            this.buttonReportSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportSupervisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReportSupervisor.ForeColor = System.Drawing.Color.White;
            this.buttonReportSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportSupervisor.Location = new System.Drawing.Point(0, 46);
            this.buttonReportSupervisor.Name = "buttonReportSupervisor";
            this.buttonReportSupervisor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonReportSupervisor.Size = new System.Drawing.Size(200, 46);
            this.buttonReportSupervisor.TabIndex = 3;
            this.buttonReportSupervisor.Text = "Supervisores";
            this.buttonReportSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportSupervisor.UseVisualStyleBackColor = false;
            this.buttonReportSupervisor.Click += new System.EventHandler(this.buttonReportSupervisor_Click);
            // 
            // buttonReportStore
            // 
            this.buttonReportStore.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonReportStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportStore.FlatAppearance.BorderSize = 0;
            this.buttonReportStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReportStore.ForeColor = System.Drawing.Color.White;
            this.buttonReportStore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReportStore.Location = new System.Drawing.Point(0, 0);
            this.buttonReportStore.Name = "buttonReportStore";
            this.buttonReportStore.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonReportStore.Size = new System.Drawing.Size(200, 46);
            this.buttonReportStore.TabIndex = 2;
            this.buttonReportStore.Text = "Tiendas";
            this.buttonReportStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportStore.UseVisualStyleBackColor = false;
            this.buttonReportStore.Click += new System.EventHandler(this.buttonReportStore_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Crimson;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.cancel;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.Location = new System.Drawing.Point(0, 715);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(200, 46);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "SALIR";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReports.ForeColor = System.Drawing.Color.White;
            this.buttonReports.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.init;
            this.buttonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReports.Location = new System.Drawing.Point(0, 146);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(200, 46);
            this.buttonReports.TabIndex = 1;
            this.buttonReports.Text = "REPORTES";
            this.buttonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.MundoTotalLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelChildForm);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(200, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(984, 761);
            this.panel6.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBoxInit);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(984, 715);
            this.panelChildForm.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelRegisterSubmenu.ResumeLayout(false);
            this.panelReporteSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBoxInit;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel5;
        private RichTextBox richTextBoxStatusMessages;
        private Panel panel1;
        private Button buttonStore;
        private Button buttonSupervisor;
        private Button buttonStatus;
        private Panel panelRegisterSubmenu;
        private Button buttonRegisterSupervisor;
        private Button buttonRegisterStore;
        private Button buttonRegisters;
        private Panel panelReporteSubmenu;
        private Button buttonReportSupervisor;
        private Button buttonReportStore;
        private Button buttonClose;
        private Button buttonReports;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Panel panelChildForm;
        private Button buttonRoles;
        private Button buttonUser;
    }
}