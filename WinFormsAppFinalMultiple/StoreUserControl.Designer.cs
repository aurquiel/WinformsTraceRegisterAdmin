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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            buttonStoreRefreshData = new Button();
            groupBox1 = new GroupBox();
            textBoxStoreAddCode = new TextBox();
            comboBoxStoreAddSupervisor = new ComboBox();
            label3 = new Label();
            buttonStoreAdd = new Button();
            label1 = new Label();
            groupBoxEditUser = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonStoreEdit = new Button();
            buttonStoreDelete = new Button();
            comboBoxStoreEdit = new ComboBox();
            label4 = new Label();
            textBoxStoreEditCode = new TextBox();
            label2 = new Label();
            comboBoxStoreEditSupervisor = new ComboBox();
            label8 = new Label();
            buttonRefreshData = new Button();
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
            panel1.Controls.Add(buttonRefreshData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 473);
            panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonStoreRefreshData);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 89);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Refrescar Data";
            // 
            // buttonStoreRefreshData
            // 
            buttonStoreRefreshData.FlatAppearance.BorderColor = Color.Green;
            buttonStoreRefreshData.FlatStyle = FlatStyle.Flat;
            buttonStoreRefreshData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStoreRefreshData.ForeColor = Color.Blue;
            buttonStoreRefreshData.Image = Properties.Resources.refresh;
            buttonStoreRefreshData.ImageAlign = ContentAlignment.MiddleRight;
            buttonStoreRefreshData.Location = new Point(19, 39);
            buttonStoreRefreshData.Name = "buttonStoreRefreshData";
            buttonStoreRefreshData.Size = new Size(100, 30);
            buttonStoreRefreshData.TabIndex = 18;
            buttonStoreRefreshData.Text = "Refrescar";
            buttonStoreRefreshData.TextAlign = ContentAlignment.MiddleLeft;
            buttonStoreRefreshData.UseVisualStyleBackColor = true;
            buttonStoreRefreshData.Click += buttonStoreRefreshData_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBoxStoreAddCode);
            groupBox1.Controls.Add(comboBoxStoreAddSupervisor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonStoreAdd);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 133);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Tienda";
            // 
            // textBoxStoreAddCode
            // 
            textBoxStoreAddCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStoreAddCode.Location = new Point(144, 43);
            textBoxStoreAddCode.Name = "textBoxStoreAddCode";
            textBoxStoreAddCode.Size = new Size(104, 25);
            textBoxStoreAddCode.TabIndex = 22;
            textBoxStoreAddCode.KeyPress += textBoxStoreAddCode_KeyPress;
            // 
            // comboBoxStoreAddSupervisor
            // 
            comboBoxStoreAddSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStoreAddSupervisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStoreAddSupervisor.FormattingEnabled = true;
            comboBoxStoreAddSupervisor.Location = new Point(354, 43);
            comboBoxStoreAddSupervisor.Name = "comboBoxStoreAddSupervisor";
            comboBoxStoreAddSupervisor.Size = new Size(228, 25);
            comboBoxStoreAddSupervisor.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(269, 46);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 20;
            label3.Text = "Supervisor:";
            // 
            // buttonStoreAdd
            // 
            buttonStoreAdd.FlatAppearance.BorderColor = Color.Green;
            buttonStoreAdd.FlatStyle = FlatStyle.Flat;
            buttonStoreAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStoreAdd.ForeColor = Color.Green;
            buttonStoreAdd.Image = Properties.Resources.add;
            buttonStoreAdd.ImageAlign = ContentAlignment.MiddleRight;
            buttonStoreAdd.Location = new Point(19, 83);
            buttonStoreAdd.Name = "buttonStoreAdd";
            buttonStoreAdd.Size = new Size(100, 30);
            buttonStoreAdd.TabIndex = 19;
            buttonStoreAdd.Text = "Agregar";
            buttonStoreAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonStoreAdd.UseVisualStyleBackColor = true;
            buttonStoreAdd.Click += buttonStoreAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Tienda:";
            // 
            // groupBoxEditUser
            // 
            groupBoxEditUser.BackColor = Color.White;
            groupBoxEditUser.Controls.Add(flowLayoutPanel1);
            groupBoxEditUser.Controls.Add(comboBoxStoreEdit);
            groupBoxEditUser.Controls.Add(label4);
            groupBoxEditUser.Controls.Add(textBoxStoreEditCode);
            groupBoxEditUser.Controls.Add(label2);
            groupBoxEditUser.Controls.Add(comboBoxStoreEditSupervisor);
            groupBoxEditUser.Controls.Add(label8);
            groupBoxEditUser.Dock = DockStyle.Top;
            groupBoxEditUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEditUser.Location = new Point(0, 0);
            groupBoxEditUser.Name = "groupBoxEditUser";
            groupBoxEditUser.Size = new Size(826, 187);
            groupBoxEditUser.TabIndex = 19;
            groupBoxEditUser.TabStop = false;
            groupBoxEditUser.Text = "Editar Tienda";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonStoreEdit);
            flowLayoutPanel1.Controls.Add(buttonStoreDelete);
            flowLayoutPanel1.Location = new Point(16, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 37);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // buttonStoreEdit
            // 
            buttonStoreEdit.FlatAppearance.BorderColor = Color.Green;
            buttonStoreEdit.FlatStyle = FlatStyle.Flat;
            buttonStoreEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStoreEdit.ForeColor = Color.FromArgb(255, 128, 0);
            buttonStoreEdit.Image = Properties.Resources.edit;
            buttonStoreEdit.ImageAlign = ContentAlignment.MiddleRight;
            buttonStoreEdit.Location = new Point(3, 3);
            buttonStoreEdit.Name = "buttonStoreEdit";
            buttonStoreEdit.Size = new Size(100, 30);
            buttonStoreEdit.TabIndex = 18;
            buttonStoreEdit.Text = "Editar";
            buttonStoreEdit.TextAlign = ContentAlignment.MiddleLeft;
            buttonStoreEdit.UseVisualStyleBackColor = true;
            buttonStoreEdit.Click += buttonStoreEdit_Click;
            // 
            // buttonStoreDelete
            // 
            buttonStoreDelete.FlatAppearance.BorderColor = Color.Green;
            buttonStoreDelete.FlatStyle = FlatStyle.Flat;
            buttonStoreDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStoreDelete.ForeColor = Color.FromArgb(192, 0, 0);
            buttonStoreDelete.Image = Properties.Resources.delete;
            buttonStoreDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonStoreDelete.Location = new Point(109, 3);
            buttonStoreDelete.Name = "buttonStoreDelete";
            buttonStoreDelete.Size = new Size(100, 30);
            buttonStoreDelete.TabIndex = 19;
            buttonStoreDelete.Text = "Eliminar";
            buttonStoreDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonStoreDelete.UseVisualStyleBackColor = true;
            buttonStoreDelete.Click += buttonStoreDelete_Click;
            // 
            // comboBoxStoreEdit
            // 
            comboBoxStoreEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStoreEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStoreEdit.FormattingEnabled = true;
            comboBoxStoreEdit.Location = new Point(144, 44);
            comboBoxStoreEdit.Name = "comboBoxStoreEdit";
            comboBoxStoreEdit.Size = new Size(104, 25);
            comboBoxStoreEdit.TabIndex = 21;
            comboBoxStoreEdit.SelectedIndexChanged += comboBoxStoreEdit_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 47);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 20;
            label4.Text = "Tienda:";
            // 
            // textBoxStoreEditCode
            // 
            textBoxStoreEditCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStoreEditCode.Location = new Point(144, 86);
            textBoxStoreEditCode.Name = "textBoxStoreEditCode";
            textBoxStoreEditCode.Size = new Size(104, 25);
            textBoxStoreEditCode.TabIndex = 3;
            textBoxStoreEditCode.KeyPress += textBoxStoreEditCode_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 2;
            label2.Text = "Editar Tienda:";
            // 
            // comboBoxStoreEditSupervisor
            // 
            comboBoxStoreEditSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStoreEditSupervisor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStoreEditSupervisor.FormattingEnabled = true;
            comboBoxStoreEditSupervisor.Location = new Point(354, 86);
            comboBoxStoreEditSupervisor.Name = "comboBoxStoreEditSupervisor";
            comboBoxStoreEditSupervisor.Size = new Size(228, 25);
            comboBoxStoreEditSupervisor.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(269, 89);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 0;
            label8.Text = "Supervisor:";
            // 
            // buttonRefreshData
            // 
            buttonRefreshData.FlatAppearance.BorderColor = Color.Green;
            buttonRefreshData.FlatStyle = FlatStyle.Flat;
            buttonRefreshData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefreshData.ForeColor = Color.Blue;
            buttonRefreshData.Image = Properties.Resources.refresh;
            buttonRefreshData.ImageAlign = ContentAlignment.MiddleRight;
            buttonRefreshData.Location = new Point(19, 139);
            buttonRefreshData.Name = "buttonRefreshData";
            buttonRefreshData.Size = new Size(100, 30);
            buttonRefreshData.TabIndex = 20;
            buttonRefreshData.Text = "Refrescar";
            buttonRefreshData.TextAlign = ContentAlignment.MiddleLeft;
            buttonRefreshData.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(846, 493);
            panel2.TabIndex = 4;
            // 
            // StoreUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "StoreUserControl";
            Size = new Size(846, 493);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
