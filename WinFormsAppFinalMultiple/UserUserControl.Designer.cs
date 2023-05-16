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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUserRefreshData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.comboBoxUserAddSupervisor = new System.Windows.Forms.ComboBox();
            this.radioButtonUserAddSupervisor = new System.Windows.Forms.RadioButton();
            this.comboBoxUserAddStore = new System.Windows.Forms.ComboBox();
            this.radioButtonUserAddStore = new System.Windows.Forms.RadioButton();
            this.radioButtonUserAddAdministrator = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUserAddMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUserAddSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUserAddName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUserAddPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUserAddAlias = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.buttonUserEditDelete = new System.Windows.Forms.Button();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.comboBoxUserEditSupervisor = new System.Windows.Forms.ComboBox();
            this.radioButtonUserEditSupervisor = new System.Windows.Forms.RadioButton();
            this.comboBoxUserEditStore = new System.Windows.Forms.ComboBox();
            this.radioButtonUserEditStore = new System.Windows.Forms.RadioButton();
            this.radioButtonUserEditAdministrator = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUserEditMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUserEditSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserEditName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserEditPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserEditAlias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUserEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxUserEditAdminRole = new System.Windows.Forms.ComboBox();
            this.comboBoxUserAddAdminRole = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxEditUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxEditUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 602);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonUserRefreshData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1171, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refrescar Data";
            // 
            // buttonUserRefreshData
            // 
            this.buttonUserRefreshData.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonUserRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserRefreshData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUserRefreshData.ForeColor = System.Drawing.Color.Blue;
            this.buttonUserRefreshData.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.refresh;
            this.buttonUserRefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserRefreshData.Location = new System.Drawing.Point(19, 39);
            this.buttonUserRefreshData.Name = "buttonUserRefreshData";
            this.buttonUserRefreshData.Size = new System.Drawing.Size(100, 30);
            this.buttonUserRefreshData.TabIndex = 18;
            this.buttonUserRefreshData.Text = "Refrescar";
            this.buttonUserRefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserRefreshData.UseVisualStyleBackColor = true;
            this.buttonUserRefreshData.Click += new System.EventHandler(this.buttonUserRefreshData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBoxUserAddAdminRole);
            this.groupBox1.Controls.Add(this.buttonUserAdd);
            this.groupBox1.Controls.Add(this.comboBoxUserAddSupervisor);
            this.groupBox1.Controls.Add(this.radioButtonUserAddSupervisor);
            this.groupBox1.Controls.Add(this.comboBoxUserAddStore);
            this.groupBox1.Controls.Add(this.radioButtonUserAddStore);
            this.groupBox1.Controls.Add(this.radioButtonUserAddAdministrator);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxUserAddMail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxUserAddSurname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxUserAddName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxUserAddPassword);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxUserAddAlias);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Usuario";
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUserAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonUserAdd.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.add;
            this.buttonUserAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserAdd.Location = new System.Drawing.Point(19, 142);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonUserAdd.TabIndex = 18;
            this.buttonUserAdd.Text = "Agregar";
            this.buttonUserAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // comboBoxUserAddSupervisor
            // 
            this.comboBoxUserAddSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserAddSupervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserAddSupervisor.FormattingEnabled = true;
            this.comboBoxUserAddSupervisor.Location = new System.Drawing.Point(757, 95);
            this.comboBoxUserAddSupervisor.Name = "comboBoxUserAddSupervisor";
            this.comboBoxUserAddSupervisor.Size = new System.Drawing.Size(250, 25);
            this.comboBoxUserAddSupervisor.TabIndex = 17;
            // 
            // radioButtonUserAddSupervisor
            // 
            this.radioButtonUserAddSupervisor.AutoSize = true;
            this.radioButtonUserAddSupervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUserAddSupervisor.Location = new System.Drawing.Point(663, 96);
            this.radioButtonUserAddSupervisor.Name = "radioButtonUserAddSupervisor";
            this.radioButtonUserAddSupervisor.Size = new System.Drawing.Size(88, 21);
            this.radioButtonUserAddSupervisor.TabIndex = 16;
            this.radioButtonUserAddSupervisor.Text = "Supervisor";
            this.radioButtonUserAddSupervisor.UseVisualStyleBackColor = true;
            this.radioButtonUserAddSupervisor.CheckedChanged += new System.EventHandler(this.radioButtonUserAddSupervisor_CheckedChanged);
            // 
            // comboBoxUserAddStore
            // 
            this.comboBoxUserAddStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserAddStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserAddStore.FormattingEnabled = true;
            this.comboBoxUserAddStore.Location = new System.Drawing.Point(526, 95);
            this.comboBoxUserAddStore.Name = "comboBoxUserAddStore";
            this.comboBoxUserAddStore.Size = new System.Drawing.Size(120, 25);
            this.comboBoxUserAddStore.TabIndex = 15;
            // 
            // radioButtonUserAddStore
            // 
            this.radioButtonUserAddStore.AutoSize = true;
            this.radioButtonUserAddStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUserAddStore.Location = new System.Drawing.Point(455, 96);
            this.radioButtonUserAddStore.Name = "radioButtonUserAddStore";
            this.radioButtonUserAddStore.Size = new System.Drawing.Size(65, 21);
            this.radioButtonUserAddStore.TabIndex = 14;
            this.radioButtonUserAddStore.Text = "Tienda";
            this.radioButtonUserAddStore.UseVisualStyleBackColor = true;
            this.radioButtonUserAddStore.CheckedChanged += new System.EventHandler(this.radioButtonUserAddStore_CheckedChanged);
            // 
            // radioButtonUserAddAdministrator
            // 
            this.radioButtonUserAddAdministrator.AutoSize = true;
            this.radioButtonUserAddAdministrator.Checked = true;
            this.radioButtonUserAddAdministrator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUserAddAdministrator.Location = new System.Drawing.Point(135, 96);
            this.radioButtonUserAddAdministrator.Name = "radioButtonUserAddAdministrator";
            this.radioButtonUserAddAdministrator.Size = new System.Drawing.Size(132, 21);
            this.radioButtonUserAddAdministrator.TabIndex = 13;
            this.radioButtonUserAddAdministrator.TabStop = true;
            this.radioButtonUserAddAdministrator.Text = "Administrador Rol";
            this.radioButtonUserAddAdministrator.UseVisualStyleBackColor = true;
            this.radioButtonUserAddAdministrator.CheckedChanged += new System.EventHandler(this.radioButtonUserAddAdministrator_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo de Usuario:";
            // 
            // textBoxUserAddMail
            // 
            this.textBoxUserAddMail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAddMail.Location = new System.Drawing.Point(906, 48);
            this.textBoxUserAddMail.Name = "textBoxUserAddMail";
            this.textBoxUserAddMail.Size = new System.Drawing.Size(250, 25);
            this.textBoxUserAddMail.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(861, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mail:";
            // 
            // textBoxUserAddSurname
            // 
            this.textBoxUserAddSurname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAddSurname.Location = new System.Drawing.Point(729, 48);
            this.textBoxUserAddSurname.Name = "textBoxUserAddSurname";
            this.textBoxUserAddSurname.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserAddSurname.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(661, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Apellido:";
            // 
            // textBoxUserAddName
            // 
            this.textBoxUserAddName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAddName.Location = new System.Drawing.Point(521, 48);
            this.textBoxUserAddName.Name = "textBoxUserAddName";
            this.textBoxUserAddName.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserAddName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(453, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nombre:";
            // 
            // textBoxUserAddPassword
            // 
            this.textBoxUserAddPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAddPassword.Location = new System.Drawing.Point(311, 48);
            this.textBoxUserAddPassword.Name = "textBoxUserAddPassword";
            this.textBoxUserAddPassword.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserAddPassword.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(224, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Contraseña:";
            // 
            // textBoxUserAddAlias
            // 
            this.textBoxUserAddAlias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAddAlias.Location = new System.Drawing.Point(80, 48);
            this.textBoxUserAddAlias.Name = "textBoxUserAddAlias";
            this.textBoxUserAddAlias.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserAddAlias.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(19, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Alias:";
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.BackColor = System.Drawing.Color.White;
            this.groupBoxEditUser.Controls.Add(this.comboBoxUserEditAdminRole);
            this.groupBoxEditUser.Controls.Add(this.buttonUserEditDelete);
            this.groupBoxEditUser.Controls.Add(this.buttonUserEdit);
            this.groupBoxEditUser.Controls.Add(this.comboBoxUserEditSupervisor);
            this.groupBoxEditUser.Controls.Add(this.radioButtonUserEditSupervisor);
            this.groupBoxEditUser.Controls.Add(this.comboBoxUserEditStore);
            this.groupBoxEditUser.Controls.Add(this.radioButtonUserEditStore);
            this.groupBoxEditUser.Controls.Add(this.radioButtonUserEditAdministrator);
            this.groupBoxEditUser.Controls.Add(this.label7);
            this.groupBoxEditUser.Controls.Add(this.textBoxUserEditMail);
            this.groupBoxEditUser.Controls.Add(this.label6);
            this.groupBoxEditUser.Controls.Add(this.textBoxUserEditSurname);
            this.groupBoxEditUser.Controls.Add(this.label5);
            this.groupBoxEditUser.Controls.Add(this.textBoxUserEditName);
            this.groupBoxEditUser.Controls.Add(this.label4);
            this.groupBoxEditUser.Controls.Add(this.textBoxUserEditPassword);
            this.groupBoxEditUser.Controls.Add(this.label3);
            this.groupBoxEditUser.Controls.Add(this.textBoxUserEditAlias);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.comboBoxUserEdit);
            this.groupBoxEditUser.Controls.Add(this.label1);
            this.groupBoxEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditUser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(1171, 231);
            this.groupBoxEditUser.TabIndex = 0;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Editar Usuario";
            // 
            // buttonUserEditDelete
            // 
            this.buttonUserEditDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonUserEditDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserEditDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUserEditDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUserEditDelete.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.delete;
            this.buttonUserEditDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserEditDelete.Location = new System.Drawing.Point(125, 177);
            this.buttonUserEditDelete.Name = "buttonUserEditDelete";
            this.buttonUserEditDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonUserEditDelete.TabIndex = 19;
            this.buttonUserEditDelete.Text = "Eliminar";
            this.buttonUserEditDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserEditDelete.UseVisualStyleBackColor = true;
            this.buttonUserEditDelete.Click += new System.EventHandler(this.buttonUserEditDelete_Click);
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUserEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUserEdit.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.edit;
            this.buttonUserEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUserEdit.Location = new System.Drawing.Point(19, 177);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonUserEdit.TabIndex = 18;
            this.buttonUserEdit.Text = "Editar";
            this.buttonUserEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEditEdit_Click);
            // 
            // comboBoxUserEditSupervisor
            // 
            this.comboBoxUserEditSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserEditSupervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserEditSupervisor.FormattingEnabled = true;
            this.comboBoxUserEditSupervisor.Location = new System.Drawing.Point(757, 130);
            this.comboBoxUserEditSupervisor.Name = "comboBoxUserEditSupervisor";
            this.comboBoxUserEditSupervisor.Size = new System.Drawing.Size(250, 25);
            this.comboBoxUserEditSupervisor.TabIndex = 17;
            // 
            // radioButtonUserEditSupervisor
            // 
            this.radioButtonUserEditSupervisor.AutoSize = true;
            this.radioButtonUserEditSupervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUserEditSupervisor.Location = new System.Drawing.Point(663, 131);
            this.radioButtonUserEditSupervisor.Name = "radioButtonUserEditSupervisor";
            this.radioButtonUserEditSupervisor.Size = new System.Drawing.Size(88, 21);
            this.radioButtonUserEditSupervisor.TabIndex = 16;
            this.radioButtonUserEditSupervisor.Text = "Supervisor";
            this.radioButtonUserEditSupervisor.UseVisualStyleBackColor = true;
            this.radioButtonUserEditSupervisor.CheckedChanged += new System.EventHandler(this.radioButtonEditUserSupervisor_CheckedChanged);
            // 
            // comboBoxUserEditStore
            // 
            this.comboBoxUserEditStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserEditStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserEditStore.FormattingEnabled = true;
            this.comboBoxUserEditStore.Location = new System.Drawing.Point(526, 130);
            this.comboBoxUserEditStore.Name = "comboBoxUserEditStore";
            this.comboBoxUserEditStore.Size = new System.Drawing.Size(120, 25);
            this.comboBoxUserEditStore.TabIndex = 15;
            // 
            // radioButtonUserEditStore
            // 
            this.radioButtonUserEditStore.AutoSize = true;
            this.radioButtonUserEditStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUserEditStore.Location = new System.Drawing.Point(455, 131);
            this.radioButtonUserEditStore.Name = "radioButtonUserEditStore";
            this.radioButtonUserEditStore.Size = new System.Drawing.Size(65, 21);
            this.radioButtonUserEditStore.TabIndex = 14;
            this.radioButtonUserEditStore.Text = "Tienda";
            this.radioButtonUserEditStore.UseVisualStyleBackColor = true;
            this.radioButtonUserEditStore.CheckedChanged += new System.EventHandler(this.radioButtonEditUserStore_CheckedChanged);
            // 
            // radioButtonUserEditAdministrator
            // 
            this.radioButtonUserEditAdministrator.AutoSize = true;
            this.radioButtonUserEditAdministrator.Checked = true;
            this.radioButtonUserEditAdministrator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUserEditAdministrator.Location = new System.Drawing.Point(135, 131);
            this.radioButtonUserEditAdministrator.Name = "radioButtonUserEditAdministrator";
            this.radioButtonUserEditAdministrator.Size = new System.Drawing.Size(132, 21);
            this.radioButtonUserEditAdministrator.TabIndex = 13;
            this.radioButtonUserEditAdministrator.TabStop = true;
            this.radioButtonUserEditAdministrator.Text = "Administrador Rol";
            this.radioButtonUserEditAdministrator.UseVisualStyleBackColor = true;
            this.radioButtonUserEditAdministrator.CheckedChanged += new System.EventHandler(this.radioButtonEditUserAdministrator_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo de Usuario:";
            // 
            // textBoxUserEditMail
            // 
            this.textBoxUserEditMail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserEditMail.Location = new System.Drawing.Point(906, 83);
            this.textBoxUserEditMail.Name = "textBoxUserEditMail";
            this.textBoxUserEditMail.Size = new System.Drawing.Size(250, 25);
            this.textBoxUserEditMail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(861, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail:";
            // 
            // textBoxUserEditSurname
            // 
            this.textBoxUserEditSurname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserEditSurname.Location = new System.Drawing.Point(729, 83);
            this.textBoxUserEditSurname.Name = "textBoxUserEditSurname";
            this.textBoxUserEditSurname.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserEditSurname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(661, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido:";
            // 
            // textBoxUserEditName
            // 
            this.textBoxUserEditName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserEditName.Location = new System.Drawing.Point(521, 83);
            this.textBoxUserEditName.Name = "textBoxUserEditName";
            this.textBoxUserEditName.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserEditName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(453, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // textBoxUserEditPassword
            // 
            this.textBoxUserEditPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserEditPassword.Location = new System.Drawing.Point(311, 83);
            this.textBoxUserEditPassword.Name = "textBoxUserEditPassword";
            this.textBoxUserEditPassword.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserEditPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(224, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // textBoxUserEditAlias
            // 
            this.textBoxUserEditAlias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserEditAlias.Location = new System.Drawing.Point(80, 83);
            this.textBoxUserEditAlias.Name = "textBoxUserEditAlias";
            this.textBoxUserEditAlias.Size = new System.Drawing.Size(120, 25);
            this.textBoxUserEditAlias.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alias:";
            // 
            // comboBoxUserEdit
            // 
            this.comboBoxUserEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserEdit.FormattingEnabled = true;
            this.comboBoxUserEdit.Location = new System.Drawing.Point(80, 42);
            this.comboBoxUserEdit.Name = "comboBoxUserEdit";
            this.comboBoxUserEdit.Size = new System.Drawing.Size(120, 25);
            this.comboBoxUserEdit.TabIndex = 1;
            this.comboBoxUserEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserEdit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1191, 622);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxUserEditAdminRole
            // 
            this.comboBoxUserEditAdminRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserEditAdminRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserEditAdminRole.FormattingEnabled = true;
            this.comboBoxUserEditAdminRole.Location = new System.Drawing.Point(273, 130);
            this.comboBoxUserEditAdminRole.Name = "comboBoxUserEditAdminRole";
            this.comboBoxUserEditAdminRole.Size = new System.Drawing.Size(158, 25);
            this.comboBoxUserEditAdminRole.TabIndex = 20;
            // 
            // comboBoxUserAddAdminRole
            // 
            this.comboBoxUserAddAdminRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserAddAdminRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUserAddAdminRole.FormattingEnabled = true;
            this.comboBoxUserAddAdminRole.Location = new System.Drawing.Point(273, 95);
            this.comboBoxUserAddAdminRole.Name = "comboBoxUserAddAdminRole";
            this.comboBoxUserAddAdminRole.Size = new System.Drawing.Size(158, 25);
            this.comboBoxUserAddAdminRole.TabIndex = 21;
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(1191, 622);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxEditUser.ResumeLayout(false);
            this.groupBoxEditUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
