namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class UserUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            buttonUserRefreshData = new Button();
            groupBox1 = new GroupBox();
            comboBoxUserAddAdminRole = new ComboBox();
            buttonUserAdd = new Button();
            comboBoxUserAddSupervisor = new ComboBox();
            radioButtonUserAddSupervisor = new RadioButton();
            comboBoxUserAddStore = new ComboBox();
            radioButtonUserAddStore = new RadioButton();
            radioButtonUserAddAdministrator = new RadioButton();
            label8 = new Label();
            textBoxUserAddMail = new TextBox();
            label9 = new Label();
            textBoxUserAddSurname = new TextBox();
            label10 = new Label();
            textBoxUserAddName = new TextBox();
            label11 = new Label();
            textBoxUserAddPassword = new TextBox();
            label12 = new Label();
            textBoxUserAddAlias = new TextBox();
            label13 = new Label();
            groupBoxEditUser = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonUserEdit = new Button();
            buttonUserEditDelete = new Button();
            comboBoxUserEditAdminRole = new ComboBox();
            comboBoxUserEditSupervisor = new ComboBox();
            radioButtonUserEditSupervisor = new RadioButton();
            comboBoxUserEditStore = new ComboBox();
            radioButtonUserEditStore = new RadioButton();
            radioButtonUserEditAdministrator = new RadioButton();
            label7 = new Label();
            textBoxUserEditMail = new TextBox();
            label6 = new Label();
            textBoxUserEditSurname = new TextBox();
            label5 = new Label();
            textBoxUserEditName = new TextBox();
            label4 = new Label();
            textBoxUserEditPassword = new TextBox();
            label3 = new Label();
            textBoxUserEditAlias = new TextBox();
            label2 = new Label();
            comboBoxUserEdit = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxEditUser.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBoxEditUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 602);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonUserRefreshData);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 433);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1171, 89);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Refrescar Data";
            // 
            // buttonUserRefreshData
            // 
            buttonUserRefreshData.FlatAppearance.BorderColor = Color.Green;
            buttonUserRefreshData.FlatStyle = FlatStyle.Flat;
            buttonUserRefreshData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserRefreshData.ForeColor = Color.Blue;
            buttonUserRefreshData.Image = Properties.Resources.refresh;
            buttonUserRefreshData.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserRefreshData.Location = new Point(19, 39);
            buttonUserRefreshData.Name = "buttonUserRefreshData";
            buttonUserRefreshData.Size = new Size(100, 30);
            buttonUserRefreshData.TabIndex = 18;
            buttonUserRefreshData.Text = "Refrescar";
            buttonUserRefreshData.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserRefreshData.UseVisualStyleBackColor = true;
            buttonUserRefreshData.Click += buttonUserRefreshData_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(comboBoxUserAddAdminRole);
            groupBox1.Controls.Add(buttonUserAdd);
            groupBox1.Controls.Add(comboBoxUserAddSupervisor);
            groupBox1.Controls.Add(radioButtonUserAddSupervisor);
            groupBox1.Controls.Add(comboBoxUserAddStore);
            groupBox1.Controls.Add(radioButtonUserAddStore);
            groupBox1.Controls.Add(radioButtonUserAddAdministrator);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxUserAddMail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxUserAddSurname);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxUserAddName);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxUserAddPassword);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBoxUserAddAlias);
            groupBox1.Controls.Add(label13);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 231);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1171, 202);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Usuario";
            // 
            // comboBoxUserAddAdminRole
            // 
            comboBoxUserAddAdminRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserAddAdminRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserAddAdminRole.FormattingEnabled = true;
            comboBoxUserAddAdminRole.Location = new Point(273, 95);
            comboBoxUserAddAdminRole.Name = "comboBoxUserAddAdminRole";
            comboBoxUserAddAdminRole.Size = new Size(158, 25);
            comboBoxUserAddAdminRole.TabIndex = 21;
            // 
            // buttonUserAdd
            // 
            buttonUserAdd.FlatAppearance.BorderColor = Color.Green;
            buttonUserAdd.FlatStyle = FlatStyle.Flat;
            buttonUserAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserAdd.ForeColor = Color.Green;
            buttonUserAdd.Image = Properties.Resources.add;
            buttonUserAdd.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserAdd.Location = new Point(19, 142);
            buttonUserAdd.Name = "buttonUserAdd";
            buttonUserAdd.Size = new Size(100, 30);
            buttonUserAdd.TabIndex = 18;
            buttonUserAdd.Text = "Agregar";
            buttonUserAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserAdd.UseVisualStyleBackColor = true;
            buttonUserAdd.Click += buttonUserAdd_Click;
            // 
            // comboBoxUserAddSupervisor
            // 
            comboBoxUserAddSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserAddSupervisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserAddSupervisor.FormattingEnabled = true;
            comboBoxUserAddSupervisor.Location = new Point(757, 95);
            comboBoxUserAddSupervisor.Name = "comboBoxUserAddSupervisor";
            comboBoxUserAddSupervisor.Size = new Size(250, 25);
            comboBoxUserAddSupervisor.TabIndex = 17;
            // 
            // radioButtonUserAddSupervisor
            // 
            radioButtonUserAddSupervisor.AutoSize = true;
            radioButtonUserAddSupervisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUserAddSupervisor.Location = new Point(663, 96);
            radioButtonUserAddSupervisor.Name = "radioButtonUserAddSupervisor";
            radioButtonUserAddSupervisor.Size = new Size(88, 21);
            radioButtonUserAddSupervisor.TabIndex = 16;
            radioButtonUserAddSupervisor.Text = "Supervisor";
            radioButtonUserAddSupervisor.UseVisualStyleBackColor = true;
            radioButtonUserAddSupervisor.CheckedChanged += radioButtonUserAddSupervisor_CheckedChanged;
            // 
            // comboBoxUserAddStore
            // 
            comboBoxUserAddStore.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserAddStore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserAddStore.FormattingEnabled = true;
            comboBoxUserAddStore.Location = new Point(526, 95);
            comboBoxUserAddStore.Name = "comboBoxUserAddStore";
            comboBoxUserAddStore.Size = new Size(120, 25);
            comboBoxUserAddStore.TabIndex = 15;
            // 
            // radioButtonUserAddStore
            // 
            radioButtonUserAddStore.AutoSize = true;
            radioButtonUserAddStore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUserAddStore.Location = new Point(455, 96);
            radioButtonUserAddStore.Name = "radioButtonUserAddStore";
            radioButtonUserAddStore.Size = new Size(65, 21);
            radioButtonUserAddStore.TabIndex = 14;
            radioButtonUserAddStore.Text = "Tienda";
            radioButtonUserAddStore.UseVisualStyleBackColor = true;
            radioButtonUserAddStore.CheckedChanged += radioButtonUserAddStore_CheckedChanged;
            // 
            // radioButtonUserAddAdministrator
            // 
            radioButtonUserAddAdministrator.AutoSize = true;
            radioButtonUserAddAdministrator.Checked = true;
            radioButtonUserAddAdministrator.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUserAddAdministrator.Location = new Point(135, 96);
            radioButtonUserAddAdministrator.Name = "radioButtonUserAddAdministrator";
            radioButtonUserAddAdministrator.Size = new Size(132, 21);
            radioButtonUserAddAdministrator.TabIndex = 13;
            radioButtonUserAddAdministrator.TabStop = true;
            radioButtonUserAddAdministrator.Text = "Administrador Rol";
            radioButtonUserAddAdministrator.UseVisualStyleBackColor = true;
            radioButtonUserAddAdministrator.CheckedChanged += radioButtonUserAddAdministrator_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 98);
            label8.Name = "label8";
            label8.Size = new Size(110, 17);
            label8.TabIndex = 12;
            label8.Text = "Tipo de Usuario:";
            // 
            // textBoxUserAddMail
            // 
            textBoxUserAddMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserAddMail.Location = new Point(906, 48);
            textBoxUserAddMail.Name = "textBoxUserAddMail";
            textBoxUserAddMail.Size = new Size(250, 25);
            textBoxUserAddMail.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(861, 51);
            label9.Name = "label9";
            label9.Size = new Size(39, 17);
            label9.TabIndex = 10;
            label9.Text = "Mail:";
            // 
            // textBoxUserAddSurname
            // 
            textBoxUserAddSurname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserAddSurname.Location = new Point(729, 48);
            textBoxUserAddSurname.Name = "textBoxUserAddSurname";
            textBoxUserAddSurname.Size = new Size(120, 25);
            textBoxUserAddSurname.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(661, 51);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 8;
            label10.Text = "Apellido:";
            // 
            // textBoxUserAddName
            // 
            textBoxUserAddName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserAddName.Location = new Point(521, 48);
            textBoxUserAddName.Name = "textBoxUserAddName";
            textBoxUserAddName.Size = new Size(120, 25);
            textBoxUserAddName.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(453, 51);
            label11.Name = "label11";
            label11.Size = new Size(62, 17);
            label11.TabIndex = 6;
            label11.Text = "Nombre:";
            // 
            // textBoxUserAddPassword
            // 
            textBoxUserAddPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserAddPassword.Location = new Point(311, 48);
            textBoxUserAddPassword.Name = "textBoxUserAddPassword";
            textBoxUserAddPassword.Size = new Size(120, 25);
            textBoxUserAddPassword.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(224, 51);
            label12.Name = "label12";
            label12.Size = new Size(81, 17);
            label12.TabIndex = 4;
            label12.Text = "Contraseña:";
            // 
            // textBoxUserAddAlias
            // 
            textBoxUserAddAlias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserAddAlias.Location = new Point(80, 48);
            textBoxUserAddAlias.Name = "textBoxUserAddAlias";
            textBoxUserAddAlias.Size = new Size(120, 25);
            textBoxUserAddAlias.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(19, 54);
            label13.Name = "label13";
            label13.Size = new Size(42, 17);
            label13.TabIndex = 2;
            label13.Text = "Alias:";
            // 
            // groupBoxEditUser
            // 
            groupBoxEditUser.BackColor = Color.White;
            groupBoxEditUser.Controls.Add(flowLayoutPanel1);
            groupBoxEditUser.Controls.Add(comboBoxUserEditAdminRole);
            groupBoxEditUser.Controls.Add(comboBoxUserEditSupervisor);
            groupBoxEditUser.Controls.Add(radioButtonUserEditSupervisor);
            groupBoxEditUser.Controls.Add(comboBoxUserEditStore);
            groupBoxEditUser.Controls.Add(radioButtonUserEditStore);
            groupBoxEditUser.Controls.Add(radioButtonUserEditAdministrator);
            groupBoxEditUser.Controls.Add(label7);
            groupBoxEditUser.Controls.Add(textBoxUserEditMail);
            groupBoxEditUser.Controls.Add(label6);
            groupBoxEditUser.Controls.Add(textBoxUserEditSurname);
            groupBoxEditUser.Controls.Add(label5);
            groupBoxEditUser.Controls.Add(textBoxUserEditName);
            groupBoxEditUser.Controls.Add(label4);
            groupBoxEditUser.Controls.Add(textBoxUserEditPassword);
            groupBoxEditUser.Controls.Add(label3);
            groupBoxEditUser.Controls.Add(textBoxUserEditAlias);
            groupBoxEditUser.Controls.Add(label2);
            groupBoxEditUser.Controls.Add(comboBoxUserEdit);
            groupBoxEditUser.Controls.Add(label1);
            groupBoxEditUser.Dock = DockStyle.Top;
            groupBoxEditUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEditUser.Location = new Point(0, 0);
            groupBoxEditUser.Name = "groupBoxEditUser";
            groupBoxEditUser.Size = new Size(1171, 231);
            groupBoxEditUser.TabIndex = 0;
            groupBoxEditUser.TabStop = false;
            groupBoxEditUser.Text = "Editar Usuario";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonUserEdit);
            flowLayoutPanel1.Controls.Add(buttonUserEditDelete);
            flowLayoutPanel1.Location = new Point(16, 175);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 37);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // buttonUserEdit
            // 
            buttonUserEdit.FlatAppearance.BorderColor = Color.Green;
            buttonUserEdit.FlatStyle = FlatStyle.Flat;
            buttonUserEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserEdit.ForeColor = Color.FromArgb(255, 128, 0);
            buttonUserEdit.Image = Properties.Resources.edit;
            buttonUserEdit.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserEdit.Location = new Point(3, 3);
            buttonUserEdit.Name = "buttonUserEdit";
            buttonUserEdit.Size = new Size(100, 30);
            buttonUserEdit.TabIndex = 18;
            buttonUserEdit.Text = "Editar";
            buttonUserEdit.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserEdit.UseVisualStyleBackColor = true;
            buttonUserEdit.Click += buttonUserEditEdit_Click;
            // 
            // buttonUserEditDelete
            // 
            buttonUserEditDelete.FlatAppearance.BorderColor = Color.Green;
            buttonUserEditDelete.FlatStyle = FlatStyle.Flat;
            buttonUserEditDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserEditDelete.ForeColor = Color.FromArgb(192, 0, 0);
            buttonUserEditDelete.Image = Properties.Resources.delete;
            buttonUserEditDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserEditDelete.Location = new Point(109, 3);
            buttonUserEditDelete.Name = "buttonUserEditDelete";
            buttonUserEditDelete.Size = new Size(100, 30);
            buttonUserEditDelete.TabIndex = 19;
            buttonUserEditDelete.Text = "Eliminar";
            buttonUserEditDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserEditDelete.UseVisualStyleBackColor = true;
            buttonUserEditDelete.Click += buttonUserEditDelete_Click;
            // 
            // comboBoxUserEditAdminRole
            // 
            comboBoxUserEditAdminRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserEditAdminRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserEditAdminRole.FormattingEnabled = true;
            comboBoxUserEditAdminRole.Location = new Point(273, 130);
            comboBoxUserEditAdminRole.Name = "comboBoxUserEditAdminRole";
            comboBoxUserEditAdminRole.Size = new Size(158, 25);
            comboBoxUserEditAdminRole.TabIndex = 20;
            // 
            // comboBoxUserEditSupervisor
            // 
            comboBoxUserEditSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserEditSupervisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserEditSupervisor.FormattingEnabled = true;
            comboBoxUserEditSupervisor.Location = new Point(757, 130);
            comboBoxUserEditSupervisor.Name = "comboBoxUserEditSupervisor";
            comboBoxUserEditSupervisor.Size = new Size(250, 25);
            comboBoxUserEditSupervisor.TabIndex = 17;
            // 
            // radioButtonUserEditSupervisor
            // 
            radioButtonUserEditSupervisor.AutoSize = true;
            radioButtonUserEditSupervisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUserEditSupervisor.Location = new Point(663, 131);
            radioButtonUserEditSupervisor.Name = "radioButtonUserEditSupervisor";
            radioButtonUserEditSupervisor.Size = new Size(88, 21);
            radioButtonUserEditSupervisor.TabIndex = 16;
            radioButtonUserEditSupervisor.Text = "Supervisor";
            radioButtonUserEditSupervisor.UseVisualStyleBackColor = true;
            radioButtonUserEditSupervisor.CheckedChanged += radioButtonEditUserSupervisor_CheckedChanged;
            // 
            // comboBoxUserEditStore
            // 
            comboBoxUserEditStore.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserEditStore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserEditStore.FormattingEnabled = true;
            comboBoxUserEditStore.Location = new Point(526, 130);
            comboBoxUserEditStore.Name = "comboBoxUserEditStore";
            comboBoxUserEditStore.Size = new Size(120, 25);
            comboBoxUserEditStore.TabIndex = 15;
            // 
            // radioButtonUserEditStore
            // 
            radioButtonUserEditStore.AutoSize = true;
            radioButtonUserEditStore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUserEditStore.Location = new Point(455, 131);
            radioButtonUserEditStore.Name = "radioButtonUserEditStore";
            radioButtonUserEditStore.Size = new Size(65, 21);
            radioButtonUserEditStore.TabIndex = 14;
            radioButtonUserEditStore.Text = "Tienda";
            radioButtonUserEditStore.UseVisualStyleBackColor = true;
            radioButtonUserEditStore.CheckedChanged += radioButtonEditUserStore_CheckedChanged;
            // 
            // radioButtonUserEditAdministrator
            // 
            radioButtonUserEditAdministrator.AutoSize = true;
            radioButtonUserEditAdministrator.Checked = true;
            radioButtonUserEditAdministrator.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUserEditAdministrator.Location = new Point(135, 131);
            radioButtonUserEditAdministrator.Name = "radioButtonUserEditAdministrator";
            radioButtonUserEditAdministrator.Size = new Size(132, 21);
            radioButtonUserEditAdministrator.TabIndex = 13;
            radioButtonUserEditAdministrator.TabStop = true;
            radioButtonUserEditAdministrator.Text = "Administrador Rol";
            radioButtonUserEditAdministrator.UseVisualStyleBackColor = true;
            radioButtonUserEditAdministrator.CheckedChanged += radioButtonEditUserAdministrator_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 133);
            label7.Name = "label7";
            label7.Size = new Size(110, 17);
            label7.TabIndex = 12;
            label7.Text = "Tipo de Usuario:";
            // 
            // textBoxUserEditMail
            // 
            textBoxUserEditMail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserEditMail.Location = new Point(906, 83);
            textBoxUserEditMail.Name = "textBoxUserEditMail";
            textBoxUserEditMail.Size = new Size(250, 25);
            textBoxUserEditMail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(861, 86);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 10;
            label6.Text = "Mail:";
            // 
            // textBoxUserEditSurname
            // 
            textBoxUserEditSurname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserEditSurname.Location = new Point(729, 83);
            textBoxUserEditSurname.Name = "textBoxUserEditSurname";
            textBoxUserEditSurname.Size = new Size(120, 25);
            textBoxUserEditSurname.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(661, 86);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 8;
            label5.Text = "Apellido:";
            // 
            // textBoxUserEditName
            // 
            textBoxUserEditName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserEditName.Location = new Point(521, 83);
            textBoxUserEditName.Name = "textBoxUserEditName";
            textBoxUserEditName.Size = new Size(120, 25);
            textBoxUserEditName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(453, 86);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 6;
            label4.Text = "Nombre:";
            // 
            // textBoxUserEditPassword
            // 
            textBoxUserEditPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserEditPassword.Location = new Point(311, 83);
            textBoxUserEditPassword.Name = "textBoxUserEditPassword";
            textBoxUserEditPassword.Size = new Size(120, 25);
            textBoxUserEditPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 86);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // textBoxUserEditAlias
            // 
            textBoxUserEditAlias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserEditAlias.Location = new Point(80, 83);
            textBoxUserEditAlias.Name = "textBoxUserEditAlias";
            textBoxUserEditAlias.Size = new Size(120, 25);
            textBoxUserEditAlias.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Alias:";
            // 
            // comboBoxUserEdit
            // 
            comboBoxUserEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserEdit.FormattingEnabled = true;
            comboBoxUserEdit.Location = new Point(80, 42);
            comboBoxUserEdit.Name = "comboBoxUserEdit";
            comboBoxUserEdit.Size = new Size(120, 25);
            comboBoxUserEdit.TabIndex = 1;
            comboBoxUserEdit.SelectedIndexChanged += comboBoxUserEdit_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1191, 622);
            panel2.TabIndex = 1;
            // 
            // UserUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UserUserControl";
            Size = new Size(1191, 622);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxEditUser.ResumeLayout(false);
            groupBoxEditUser.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxEditUser;
        private ComboBox comboBoxUserEdit;
        private TextBox textBoxUserEditMail;
        private Label label6;
        private TextBox textBoxUserEditSurname;
        private Label label5;
        private TextBox textBoxUserEditName;
        private Label label4;
        private TextBox textBoxUserEditPassword;
        private Label label3;
        private TextBox textBoxUserEditAlias;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxUserEditSupervisor;
        private RadioButton radioButtonUserEditSupervisor;
        private ComboBox comboBoxUserEditStore;
        private RadioButton radioButtonUserEditStore;
        private RadioButton radioButtonUserEditAdministrator;
        private Label label7;
        private Button buttonUserEdit;
        private Button buttonUserEditDelete;
        private GroupBox groupBox1;
        private Button buttonUserAdd;
        private ComboBox comboBoxUserAddSupervisor;
        private RadioButton radioButtonUserAddSupervisor;
        private ComboBox comboBoxUserAddStore;
        private RadioButton radioButtonUserAddStore;
        private RadioButton radioButtonUserAddAdministrator;
        private Label label8;
        private TextBox textBoxUserAddMail;
        private Label label9;
        private TextBox textBoxUserAddSurname;
        private Label label10;
        private TextBox textBoxUserAddName;
        private Label label11;
        private TextBox textBoxUserAddPassword;
        private Label label12;
        private TextBox textBoxUserAddAlias;
        private Label label13;
        private GroupBox groupBox2;
        private Button buttonUserRefreshData;
        private Panel panel2;
        private ComboBox comboBoxUserAddAdminRole;
        private ComboBox comboBoxUserEditAdminRole;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
