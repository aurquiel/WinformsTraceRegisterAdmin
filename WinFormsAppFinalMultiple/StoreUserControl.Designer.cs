namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class StoreUserControl
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
            this.buttonStoreRefreshData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStoreAddCode = new System.Windows.Forms.TextBox();
            this.comboBoxStoreAddSupervisor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStoreAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.comboBoxStoreEdit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStoreDelete = new System.Windows.Forms.Button();
            this.buttonStoreEdit = new System.Windows.Forms.Button();
            this.textBoxStoreEditCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStoreEditSupervisor = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(826, 473);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonStoreRefreshData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 89);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refrescar Data";
            // 
            // buttonStoreRefreshData
            // 
            this.buttonStoreRefreshData.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStoreRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreRefreshData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStoreRefreshData.ForeColor = System.Drawing.Color.Blue;
            this.buttonStoreRefreshData.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.refresh;
            this.buttonStoreRefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStoreRefreshData.Location = new System.Drawing.Point(19, 39);
            this.buttonStoreRefreshData.Name = "buttonStoreRefreshData";
            this.buttonStoreRefreshData.Size = new System.Drawing.Size(100, 30);
            this.buttonStoreRefreshData.TabIndex = 18;
            this.buttonStoreRefreshData.Text = "Refrescar";
            this.buttonStoreRefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStoreRefreshData.UseVisualStyleBackColor = true;
            this.buttonStoreRefreshData.Click += new System.EventHandler(this.buttonStoreRefreshData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBoxStoreAddCode);
            this.groupBox1.Controls.Add(this.comboBoxStoreAddSupervisor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonStoreAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Tienda";
            // 
            // textBoxStoreAddCode
            // 
            this.textBoxStoreAddCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStoreAddCode.Location = new System.Drawing.Point(144, 43);
            this.textBoxStoreAddCode.Name = "textBoxStoreAddCode";
            this.textBoxStoreAddCode.Size = new System.Drawing.Size(104, 25);
            this.textBoxStoreAddCode.TabIndex = 22;
            this.textBoxStoreAddCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStoreAddCode_KeyPress);
            // 
            // comboBoxStoreAddSupervisor
            // 
            this.comboBoxStoreAddSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStoreAddSupervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStoreAddSupervisor.FormattingEnabled = true;
            this.comboBoxStoreAddSupervisor.Location = new System.Drawing.Point(354, 43);
            this.comboBoxStoreAddSupervisor.Name = "comboBoxStoreAddSupervisor";
            this.comboBoxStoreAddSupervisor.Size = new System.Drawing.Size(228, 25);
            this.comboBoxStoreAddSupervisor.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Supervisor:";
            // 
            // buttonStoreAdd
            // 
            this.buttonStoreAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStoreAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStoreAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonStoreAdd.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.add;
            this.buttonStoreAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStoreAdd.Location = new System.Drawing.Point(19, 83);
            this.buttonStoreAdd.Name = "buttonStoreAdd";
            this.buttonStoreAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonStoreAdd.TabIndex = 19;
            this.buttonStoreAdd.Text = "Agregar";
            this.buttonStoreAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStoreAdd.UseVisualStyleBackColor = true;
            this.buttonStoreAdd.Click += new System.EventHandler(this.buttonStoreAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Tienda:";
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.BackColor = System.Drawing.Color.White;
            this.groupBoxEditUser.Controls.Add(this.comboBoxStoreEdit);
            this.groupBoxEditUser.Controls.Add(this.label4);
            this.groupBoxEditUser.Controls.Add(this.buttonStoreDelete);
            this.groupBoxEditUser.Controls.Add(this.buttonStoreEdit);
            this.groupBoxEditUser.Controls.Add(this.textBoxStoreEditCode);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.comboBoxStoreEditSupervisor);
            this.groupBoxEditUser.Controls.Add(this.label8);
            this.groupBoxEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditUser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(826, 187);
            this.groupBoxEditUser.TabIndex = 19;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Editar Tienda";
            // 
            // comboBoxStoreEdit
            // 
            this.comboBoxStoreEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStoreEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStoreEdit.FormattingEnabled = true;
            this.comboBoxStoreEdit.Location = new System.Drawing.Point(144, 44);
            this.comboBoxStoreEdit.Name = "comboBoxStoreEdit";
            this.comboBoxStoreEdit.Size = new System.Drawing.Size(104, 25);
            this.comboBoxStoreEdit.TabIndex = 21;
            this.comboBoxStoreEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxStoreEdit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tienda:";
            // 
            // buttonStoreDelete
            // 
            this.buttonStoreDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStoreDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStoreDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStoreDelete.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.delete;
            this.buttonStoreDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStoreDelete.Location = new System.Drawing.Point(125, 130);
            this.buttonStoreDelete.Name = "buttonStoreDelete";
            this.buttonStoreDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonStoreDelete.TabIndex = 19;
            this.buttonStoreDelete.Text = "Eliminar";
            this.buttonStoreDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStoreDelete.UseVisualStyleBackColor = true;
            this.buttonStoreDelete.Click += new System.EventHandler(this.buttonStoreDelete_Click);
            // 
            // buttonStoreEdit
            // 
            this.buttonStoreEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStoreEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStoreEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStoreEdit.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.edit;
            this.buttonStoreEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStoreEdit.Location = new System.Drawing.Point(19, 130);
            this.buttonStoreEdit.Name = "buttonStoreEdit";
            this.buttonStoreEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonStoreEdit.TabIndex = 18;
            this.buttonStoreEdit.Text = "Editar";
            this.buttonStoreEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStoreEdit.UseVisualStyleBackColor = true;
            this.buttonStoreEdit.Click += new System.EventHandler(this.buttonStoreEdit_Click);
            // 
            // textBoxStoreEditCode
            // 
            this.textBoxStoreEditCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStoreEditCode.Location = new System.Drawing.Point(144, 86);
            this.textBoxStoreEditCode.Name = "textBoxStoreEditCode";
            this.textBoxStoreEditCode.Size = new System.Drawing.Size(104, 25);
            this.textBoxStoreEditCode.TabIndex = 3;
            this.textBoxStoreEditCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStoreEditCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editar Tienda:";
            // 
            // comboBoxStoreEditSupervisor
            // 
            this.comboBoxStoreEditSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStoreEditSupervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStoreEditSupervisor.FormattingEnabled = true;
            this.comboBoxStoreEditSupervisor.Location = new System.Drawing.Point(354, 86);
            this.comboBoxStoreEditSupervisor.Name = "comboBoxStoreEditSupervisor";
            this.comboBoxStoreEditSupervisor.Size = new System.Drawing.Size(228, 25);
            this.comboBoxStoreEditSupervisor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(269, 89);
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
            this.panel2.Size = new System.Drawing.Size(846, 493);
            this.panel2.TabIndex = 4;
            // 
            // StoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "StoreUserControl";
            this.Size = new System.Drawing.Size(846, 493);
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
        private Button buttonStoreRefreshData;
        private GroupBox groupBox1;
        private TextBox textBoxStoreAddCode;
        private ComboBox comboBoxStoreAddSupervisor;
        private Label label3;
        private Button buttonStoreAdd;
        private Label label1;
        private GroupBox groupBoxEditUser;
        private Label label4;
        private Button buttonStoreDelete;
        private Button buttonStoreEdit;
        private TextBox textBoxStoreEditCode;
        private Label label2;
        private ComboBox comboBoxStoreEditSupervisor;
        private Label label8;
        private Button buttonRefreshData;
        private ComboBox comboBoxStoreEdit;
        private Panel panel2;
    }
}
