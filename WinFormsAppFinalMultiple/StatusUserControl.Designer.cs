namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class StatusUserControl
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
            this.buttonStatusRefreshData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStatusAdd = new System.Windows.Forms.Button();
            this.textBoxStatusAddDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.buttonStatusDelete = new System.Windows.Forms.Button();
            this.buttonStatusEdit = new System.Windows.Forms.Button();
            this.textBoxStatusEditDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatusEdit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 558);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonStatusRefreshData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1176, 89);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refrescar Data";
            // 
            // buttonStatusRefreshData
            // 
            this.buttonStatusRefreshData.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStatusRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatusRefreshData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatusRefreshData.ForeColor = System.Drawing.Color.Blue;
            this.buttonStatusRefreshData.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.refresh;
            this.buttonStatusRefreshData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatusRefreshData.Location = new System.Drawing.Point(19, 39);
            this.buttonStatusRefreshData.Name = "buttonStatusRefreshData";
            this.buttonStatusRefreshData.Size = new System.Drawing.Size(100, 30);
            this.buttonStatusRefreshData.TabIndex = 18;
            this.buttonStatusRefreshData.Text = "Refrescar";
            this.buttonStatusRefreshData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatusRefreshData.UseVisualStyleBackColor = true;
            this.buttonStatusRefreshData.Click += new System.EventHandler(this.buttonStatusRefreshData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonStatusAdd);
            this.groupBox1.Controls.Add(this.textBoxStatusAddDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Estatus";
            // 
            // buttonStatusAdd
            // 
            this.buttonStatusAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStatusAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatusAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatusAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonStatusAdd.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.add;
            this.buttonStatusAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatusAdd.Location = new System.Drawing.Point(19, 83);
            this.buttonStatusAdd.Name = "buttonStatusAdd";
            this.buttonStatusAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonStatusAdd.TabIndex = 19;
            this.buttonStatusAdd.Text = "Agregar";
            this.buttonStatusAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatusAdd.UseVisualStyleBackColor = true;
            this.buttonStatusAdd.Click += new System.EventHandler(this.buttonStatusAdd_Click);
            // 
            // textBoxStatusAddDescription
            // 
            this.textBoxStatusAddDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStatusAddDescription.Location = new System.Drawing.Point(121, 43);
            this.textBoxStatusAddDescription.Name = "textBoxStatusAddDescription";
            this.textBoxStatusAddDescription.Size = new System.Drawing.Size(228, 25);
            this.textBoxStatusAddDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Estatus:";
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.BackColor = System.Drawing.Color.White;
            this.groupBoxEditUser.Controls.Add(this.buttonStatusDelete);
            this.groupBoxEditUser.Controls.Add(this.buttonStatusEdit);
            this.groupBoxEditUser.Controls.Add(this.textBoxStatusEditDescription);
            this.groupBoxEditUser.Controls.Add(this.label2);
            this.groupBoxEditUser.Controls.Add(this.comboBoxStatusEdit);
            this.groupBoxEditUser.Controls.Add(this.label8);
            this.groupBoxEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditUser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(1176, 187);
            this.groupBoxEditUser.TabIndex = 19;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Editar Estatus";
            // 
            // buttonStatusDelete
            // 
            this.buttonStatusDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStatusDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatusDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatusDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStatusDelete.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.delete;
            this.buttonStatusDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatusDelete.Location = new System.Drawing.Point(125, 130);
            this.buttonStatusDelete.Name = "buttonStatusDelete";
            this.buttonStatusDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonStatusDelete.TabIndex = 19;
            this.buttonStatusDelete.Text = "Eliminar";
            this.buttonStatusDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatusDelete.UseVisualStyleBackColor = true;
            this.buttonStatusDelete.Click += new System.EventHandler(this.buttonStatusDelete_Click);
            // 
            // buttonStatusEdit
            // 
            this.buttonStatusEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonStatusEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatusEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatusEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStatusEdit.Image = global::WinFormsAppTrazoRegistrosAdmin.Properties.Resources.edit;
            this.buttonStatusEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStatusEdit.Location = new System.Drawing.Point(19, 130);
            this.buttonStatusEdit.Name = "buttonStatusEdit";
            this.buttonStatusEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonStatusEdit.TabIndex = 18;
            this.buttonStatusEdit.Text = "Editar";
            this.buttonStatusEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatusEdit.UseVisualStyleBackColor = true;
            this.buttonStatusEdit.Click += new System.EventHandler(this.buttonStatusEdit_Click);
            // 
            // textBoxStatusEditDescription
            // 
            this.textBoxStatusEditDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStatusEditDescription.Location = new System.Drawing.Point(121, 86);
            this.textBoxStatusEditDescription.Name = "textBoxStatusEditDescription";
            this.textBoxStatusEditDescription.Size = new System.Drawing.Size(228, 25);
            this.textBoxStatusEditDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editar Estatus:";
            // 
            // comboBoxStatusEdit
            // 
            this.comboBoxStatusEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStatusEdit.FormattingEnabled = true;
            this.comboBoxStatusEdit.Location = new System.Drawing.Point(121, 42);
            this.comboBoxStatusEdit.Name = "comboBoxStatusEdit";
            this.comboBoxStatusEdit.Size = new System.Drawing.Size(228, 25);
            this.comboBoxStatusEdit.TabIndex = 1;
            this.comboBoxStatusEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusEdit_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estatus:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1196, 578);
            this.panel2.TabIndex = 2;
            // 
            // StatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "StatusUserControl";
            this.Size = new System.Drawing.Size(1196, 578);
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
        private Button buttonStatusDelete;
        private Button buttonStatusEdit;
        private TextBox textBoxStatusEditDescription;
        private Label label2;
        private ComboBox comboBoxStatusEdit;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox textBoxStatusAddDescription;
        private Label label1;
        private Button buttonStatusAdd;
        private GroupBox groupBox2;
        private Button buttonStatusRefreshData;
        private Panel panel2;
    }
}
