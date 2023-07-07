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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            buttonSupervisorRefreshData = new Button();
            groupBox1 = new GroupBox();
            buttonSupervisorAdd = new Button();
            textBoxSupervisorAddDescription = new TextBox();
            label1 = new Label();
            groupBoxEditUser = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSupervisorEdit = new Button();
            buttonSupervisorDelete = new Button();
            textBoxSupervisorEditDescription = new TextBox();
            label2 = new Label();
            comboBoxSupervisorEdit = new ComboBox();
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
            panel1.Size = new Size(845, 452);
            panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonSupervisorRefreshData);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(845, 89);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Refrescar Data";
            // 
            // buttonSupervisorRefreshData
            // 
            buttonSupervisorRefreshData.FlatAppearance.BorderColor = Color.Green;
            buttonSupervisorRefreshData.FlatStyle = FlatStyle.Flat;
            buttonSupervisorRefreshData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupervisorRefreshData.ForeColor = Color.Blue;
            buttonSupervisorRefreshData.Image = Properties.Resources.refresh;
            buttonSupervisorRefreshData.ImageAlign = ContentAlignment.MiddleRight;
            buttonSupervisorRefreshData.Location = new Point(19, 39);
            buttonSupervisorRefreshData.Name = "buttonSupervisorRefreshData";
            buttonSupervisorRefreshData.Size = new Size(100, 30);
            buttonSupervisorRefreshData.TabIndex = 18;
            buttonSupervisorRefreshData.Text = "Refrescar";
            buttonSupervisorRefreshData.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupervisorRefreshData.UseVisualStyleBackColor = true;
            buttonSupervisorRefreshData.Click += buttonSupervisorRefreshData_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(buttonSupervisorAdd);
            groupBox1.Controls.Add(textBoxSupervisorAddDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 133);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Supervisor";
            // 
            // buttonSupervisorAdd
            // 
            buttonSupervisorAdd.FlatAppearance.BorderColor = Color.Green;
            buttonSupervisorAdd.FlatStyle = FlatStyle.Flat;
            buttonSupervisorAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupervisorAdd.ForeColor = Color.Green;
            buttonSupervisorAdd.Image = Properties.Resources.add;
            buttonSupervisorAdd.ImageAlign = ContentAlignment.MiddleRight;
            buttonSupervisorAdd.Location = new Point(19, 83);
            buttonSupervisorAdd.Name = "buttonSupervisorAdd";
            buttonSupervisorAdd.Size = new Size(100, 30);
            buttonSupervisorAdd.TabIndex = 19;
            buttonSupervisorAdd.Text = "Agregar";
            buttonSupervisorAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupervisorAdd.UseVisualStyleBackColor = true;
            buttonSupervisorAdd.Click += buttonSupervisorAdd_Click;
            // 
            // textBoxSupervisorAddDescription
            // 
            textBoxSupervisorAddDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSupervisorAddDescription.Location = new Point(144, 43);
            textBoxSupervisorAddDescription.Name = "textBoxSupervisorAddDescription";
            textBoxSupervisorAddDescription.Size = new Size(228, 25);
            textBoxSupervisorAddDescription.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Supervisor:";
            // 
            // groupBoxEditUser
            // 
            groupBoxEditUser.BackColor = Color.White;
            groupBoxEditUser.Controls.Add(flowLayoutPanel1);
            groupBoxEditUser.Controls.Add(textBoxSupervisorEditDescription);
            groupBoxEditUser.Controls.Add(label2);
            groupBoxEditUser.Controls.Add(comboBoxSupervisorEdit);
            groupBoxEditUser.Controls.Add(label8);
            groupBoxEditUser.Dock = DockStyle.Top;
            groupBoxEditUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEditUser.Location = new Point(0, 0);
            groupBoxEditUser.Name = "groupBoxEditUser";
            groupBoxEditUser.Size = new Size(845, 187);
            groupBoxEditUser.TabIndex = 19;
            groupBoxEditUser.TabStop = false;
            groupBoxEditUser.Text = "Editar Supervisor";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSupervisorEdit);
            flowLayoutPanel1.Controls.Add(buttonSupervisorDelete);
            flowLayoutPanel1.Location = new Point(16, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 37);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // buttonSupervisorEdit
            // 
            buttonSupervisorEdit.FlatAppearance.BorderColor = Color.Green;
            buttonSupervisorEdit.FlatStyle = FlatStyle.Flat;
            buttonSupervisorEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupervisorEdit.ForeColor = Color.FromArgb(255, 128, 0);
            buttonSupervisorEdit.Image = Properties.Resources.edit;
            buttonSupervisorEdit.ImageAlign = ContentAlignment.MiddleRight;
            buttonSupervisorEdit.Location = new Point(3, 3);
            buttonSupervisorEdit.Name = "buttonSupervisorEdit";
            buttonSupervisorEdit.Size = new Size(100, 30);
            buttonSupervisorEdit.TabIndex = 18;
            buttonSupervisorEdit.Text = "Editar";
            buttonSupervisorEdit.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupervisorEdit.UseVisualStyleBackColor = true;
            buttonSupervisorEdit.Click += buttonSupervisorEdit_Click;
            // 
            // buttonSupervisorDelete
            // 
            buttonSupervisorDelete.FlatAppearance.BorderColor = Color.Green;
            buttonSupervisorDelete.FlatStyle = FlatStyle.Flat;
            buttonSupervisorDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupervisorDelete.ForeColor = Color.FromArgb(192, 0, 0);
            buttonSupervisorDelete.Image = Properties.Resources.delete;
            buttonSupervisorDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonSupervisorDelete.Location = new Point(109, 3);
            buttonSupervisorDelete.Name = "buttonSupervisorDelete";
            buttonSupervisorDelete.Size = new Size(100, 30);
            buttonSupervisorDelete.TabIndex = 19;
            buttonSupervisorDelete.Text = "Eliminar";
            buttonSupervisorDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupervisorDelete.UseVisualStyleBackColor = true;
            buttonSupervisorDelete.Click += buttonSupervisorDelete_Click;
            // 
            // textBoxSupervisorEditDescription
            // 
            textBoxSupervisorEditDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSupervisorEditDescription.Location = new Point(144, 86);
            textBoxSupervisorEditDescription.Name = "textBoxSupervisorEditDescription";
            textBoxSupervisorEditDescription.Size = new Size(228, 25);
            textBoxSupervisorEditDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 2;
            label2.Text = "Editar Supervisor:";
            // 
            // comboBoxSupervisorEdit
            // 
            comboBoxSupervisorEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupervisorEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSupervisorEdit.FormattingEnabled = true;
            comboBoxSupervisorEdit.Location = new Point(144, 42);
            comboBoxSupervisorEdit.Name = "comboBoxSupervisorEdit";
            comboBoxSupervisorEdit.Size = new Size(228, 25);
            comboBoxSupervisorEdit.TabIndex = 1;
            comboBoxSupervisorEdit.SelectedIndexChanged += comboBoxSupervisorEdit_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 45);
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
            panel2.Size = new Size(865, 472);
            panel2.TabIndex = 3;
            // 
            // SupervisorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "SupervisorUserControl";
            Size = new Size(865, 472);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
