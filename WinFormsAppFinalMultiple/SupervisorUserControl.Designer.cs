namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class SupervisorUserControl
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
            this.buttonSupervisorRefreshData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSupervisorAdd = new System.Windows.Forms.Button();
            this.textBoxSupervisorAddDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.buttonSupervisorDelete = new System.Windows.Forms.Button();
            this.buttonSupervisorEdit = new System.Windows.Forms.Button();
            this.textBoxSupervisorEditDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSupervisorEdit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.buttonRefreshData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 452);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonSupervisorRefreshData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 89);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refrescar Data";
            // 
            // buttonSupervisorRefreshData
            // 
            this.buttonSupervisorRefreshData.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSupervisorRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupervisorRefreshData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSupervisorRefreshData.ForeColor = System.Drawing.Color.Blue;
            this.buttonSupervisorRefreshData.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.refresh;
            this.buttonSupervisorRefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSupervisorRefreshData.Location = new System.Drawing.Point(19, 39);
            this.buttonSupervisorRefreshData.Name = "buttonSupervisorRefreshData";
            this.buttonSupervisorRefreshData.Size = new System.Drawing.Size(100, 30);
            this.buttonSupervisorRefreshData.TabIndex = 18;
            this.buttonSupervisorRefreshData.Text = "Refrescar";
            this.buttonSupervisorRefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupervisorRefreshData.UseVisualStyleBackColor = true;
            this.buttonSupervisorRefreshData.Click += new System.EventHandler(this.buttonSupervisorRefreshData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonSupervisorAdd);
            this.groupBox1.Controls.Add(this.textBoxSupervisorAddDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Supervisor";
            // 
            // buttonSupervisorAdd
            // 
            this.buttonSupervisorAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSupervisorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupervisorAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSupervisorAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonSupervisorAdd.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.add;
            this.buttonSupervisorAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSupervisorAdd.Location = new System.Drawing.Point(19, 83);
            this.buttonSupervisorAdd.Name = "buttonSupervisorAdd";
            this.buttonSupervisorAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonSupervisorAdd.TabIndex = 19;
            this.buttonSupervisorAdd.Text = "Agregar";
            this.buttonSupervisorAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupervisorAdd.UseVisualStyleBackColor = true;
            this.buttonSupervisorAdd.Click += new System.EventHandler(this.buttonSupervisorAdd_Click);
            // 
            // textBoxSupervisorAddDescription
            // 
            this.textBoxSupervisorAddDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupervisorAddDescription.Location = new System.Drawing.Point(144, 43);
            this.textBoxSupervisorAddDescription.Name = "textBoxSupervisorAddDescription";
            this.textBoxSupervisorAddDescription.Size = new System.Drawing.Size(228, 25);
            this.textBoxSupervisorAddDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Supervisor:";
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.BackColor = System.Drawing.Color.White;
            this.groupBoxEditUser.Controls.Add(this.buttonSupervisorDelete);
            this.groupBoxEditUser.Controls.Add(this.buttonSupervisorEdit);
            this.groupBoxEditUser.Controls.Add(this.textBoxSupervisorEditDescription);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.comboBoxSupervisorEdit);
            this.groupBoxEditUser.Controls.Add(this.label8);
            this.groupBoxEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditUser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(845, 187);
            this.groupBoxEditUser.TabIndex = 19;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Editar Supervisor";
            // 
            // buttonSupervisorDelete
            // 
            this.buttonSupervisorDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSupervisorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupervisorDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSupervisorDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSupervisorDelete.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.delete;
            this.buttonSupervisorDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSupervisorDelete.Location = new System.Drawing.Point(125, 130);
            this.buttonSupervisorDelete.Name = "buttonSupervisorDelete";
            this.buttonSupervisorDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonSupervisorDelete.TabIndex = 19;
            this.buttonSupervisorDelete.Text = "Eliminar";
            this.buttonSupervisorDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupervisorDelete.UseVisualStyleBackColor = true;
            this.buttonSupervisorDelete.Click += new System.EventHandler(this.buttonSupervisorDelete_Click);
            // 
            // buttonSupervisorEdit
            // 
            this.buttonSupervisorEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSupervisorEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupervisorEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSupervisorEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSupervisorEdit.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.edit;
            this.buttonSupervisorEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSupervisorEdit.Location = new System.Drawing.Point(19, 130);
            this.buttonSupervisorEdit.Name = "buttonSupervisorEdit";
            this.buttonSupervisorEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonSupervisorEdit.TabIndex = 18;
            this.buttonSupervisorEdit.Text = "Editar";
            this.buttonSupervisorEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupervisorEdit.UseVisualStyleBackColor = true;
            this.buttonSupervisorEdit.Click += new System.EventHandler(this.buttonSupervisorEdit_Click);
            // 
            // textBoxSupervisorEditDescription
            // 
            this.textBoxSupervisorEditDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupervisorEditDescription.Location = new System.Drawing.Point(144, 86);
            this.textBoxSupervisorEditDescription.Name = "textBoxSupervisorEditDescription";
            this.textBoxSupervisorEditDescription.Size = new System.Drawing.Size(228, 25);
            this.textBoxSupervisorEditDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editar Supervisor:";
            // 
            // comboBoxSupervisorEdit
            // 
            this.comboBoxSupervisorEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisorEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSupervisorEdit.FormattingEnabled = true;
            this.comboBoxSupervisorEdit.Location = new System.Drawing.Point(144, 42);
            this.comboBoxSupervisorEdit.Name = "comboBoxSupervisorEdit";
            this.comboBoxSupervisorEdit.Size = new System.Drawing.Size(228, 25);
            this.comboBoxSupervisorEdit.TabIndex = 1;
            this.comboBoxSupervisorEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupervisorEdit_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Supervisor:";
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefreshData.ForeColor = System.Drawing.Color.Blue;
            this.buttonRefreshData.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.refresh;
            this.buttonRefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshData.Location = new System.Drawing.Point(19, 139);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(100, 30);
            this.buttonRefreshData.TabIndex = 20;
            this.buttonRefreshData.Text = "Refrescar";
            this.buttonRefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(865, 472);
            this.panel2.TabIndex = 3;
            // 
            // SupervisorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "SupervisorUserControl";
            this.Size = new System.Drawing.Size(865, 472);
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
        private GroupBox groupBox2;
        private Button buttonSupervisorRefreshData;
        private GroupBox groupBox1;
        private Button buttonSupervisorAdd;
        private TextBox textBoxSupervisorAddDescription;
        private Label label1;
        private GroupBox groupBoxEditUser;
        private Button buttonSupervisorDelete;
        private Button buttonSupervisorEdit;
        private TextBox textBoxSupervisorEditDescription;
        private Label label2;
        private ComboBox comboBoxSupervisorEdit;
        private Label label8;
        private Button buttonRefreshData;
        private Panel panel2;
    }
}
