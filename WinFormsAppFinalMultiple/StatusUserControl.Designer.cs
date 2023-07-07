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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            buttonStatusRefreshData = new Button();
            groupBox1 = new GroupBox();
            buttonStatusAdd = new Button();
            textBoxStatusAddDescription = new TextBox();
            label1 = new Label();
            groupBoxEditUser = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonStatusEdit = new Button();
            buttonStatusDelete = new Button();
            textBoxStatusEditDescription = new TextBox();
            label2 = new Label();
            comboBoxStatusEdit = new ComboBox();
            label8 = new Label();
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
            panel1.Size = new Size(1176, 558);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonStatusRefreshData);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1176, 89);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Refrescar Data";
            // 
            // buttonStatusRefreshData
            // 
            buttonStatusRefreshData.FlatAppearance.BorderColor = Color.Green;
            buttonStatusRefreshData.FlatStyle = FlatStyle.Flat;
            buttonStatusRefreshData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStatusRefreshData.ForeColor = Color.Blue;
            buttonStatusRefreshData.Image = Properties.Resources.refresh;
            buttonStatusRefreshData.ImageAlign = ContentAlignment.MiddleRight;
            buttonStatusRefreshData.Location = new Point(19, 39);
            buttonStatusRefreshData.Name = "buttonStatusRefreshData";
            buttonStatusRefreshData.Size = new Size(100, 30);
            buttonStatusRefreshData.TabIndex = 18;
            buttonStatusRefreshData.Text = "Refrescar";
            buttonStatusRefreshData.TextAlign = ContentAlignment.MiddleLeft;
            buttonStatusRefreshData.UseVisualStyleBackColor = true;
            buttonStatusRefreshData.Click += buttonStatusRefreshData_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(buttonStatusAdd);
            groupBox1.Controls.Add(textBoxStatusAddDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 133);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Estatus";
            // 
            // buttonStatusAdd
            // 
            buttonStatusAdd.FlatAppearance.BorderColor = Color.Green;
            buttonStatusAdd.FlatStyle = FlatStyle.Flat;
            buttonStatusAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStatusAdd.ForeColor = Color.Green;
            buttonStatusAdd.Image = Properties.Resources.add;
            buttonStatusAdd.ImageAlign = ContentAlignment.MiddleRight;
            buttonStatusAdd.Location = new Point(19, 83);
            buttonStatusAdd.Name = "buttonStatusAdd";
            buttonStatusAdd.Size = new Size(100, 30);
            buttonStatusAdd.TabIndex = 19;
            buttonStatusAdd.Text = "Agregar";
            buttonStatusAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonStatusAdd.UseVisualStyleBackColor = true;
            buttonStatusAdd.Click += buttonStatusAdd_Click;
            // 
            // textBoxStatusAddDescription
            // 
            textBoxStatusAddDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatusAddDescription.Location = new Point(121, 43);
            textBoxStatusAddDescription.Name = "textBoxStatusAddDescription";
            textBoxStatusAddDescription.Size = new Size(228, 25);
            textBoxStatusAddDescription.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Estatus:";
            // 
            // groupBoxEditUser
            // 
            groupBoxEditUser.BackColor = Color.White;
            groupBoxEditUser.Controls.Add(flowLayoutPanel1);
            groupBoxEditUser.Controls.Add(textBoxStatusEditDescription);
            groupBoxEditUser.Controls.Add(label2);
            groupBoxEditUser.Controls.Add(comboBoxStatusEdit);
            groupBoxEditUser.Controls.Add(label8);
            groupBoxEditUser.Dock = DockStyle.Top;
            groupBoxEditUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEditUser.Location = new Point(0, 0);
            groupBoxEditUser.Name = "groupBoxEditUser";
            groupBoxEditUser.Size = new Size(1176, 187);
            groupBoxEditUser.TabIndex = 19;
            groupBoxEditUser.TabStop = false;
            groupBoxEditUser.Text = "Editar Estatus";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonStatusEdit);
            flowLayoutPanel1.Controls.Add(buttonStatusDelete);
            flowLayoutPanel1.Location = new Point(16, 131);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(214, 37);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // buttonStatusEdit
            // 
            buttonStatusEdit.FlatAppearance.BorderColor = Color.Green;
            buttonStatusEdit.FlatStyle = FlatStyle.Flat;
            buttonStatusEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStatusEdit.ForeColor = Color.FromArgb(255, 128, 0);
            buttonStatusEdit.Image = Properties.Resources.edit;
            buttonStatusEdit.ImageAlign = ContentAlignment.MiddleRight;
            buttonStatusEdit.Location = new Point(3, 3);
            buttonStatusEdit.Name = "buttonStatusEdit";
            buttonStatusEdit.Size = new Size(100, 30);
            buttonStatusEdit.TabIndex = 18;
            buttonStatusEdit.Text = "Editar";
            buttonStatusEdit.TextAlign = ContentAlignment.MiddleLeft;
            buttonStatusEdit.UseVisualStyleBackColor = true;
            buttonStatusEdit.Click += buttonStatusEdit_Click;
            // 
            // buttonStatusDelete
            // 
            buttonStatusDelete.FlatAppearance.BorderColor = Color.Green;
            buttonStatusDelete.FlatStyle = FlatStyle.Flat;
            buttonStatusDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStatusDelete.ForeColor = Color.FromArgb(192, 0, 0);
            buttonStatusDelete.Image = Properties.Resources.delete;
            buttonStatusDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonStatusDelete.Location = new Point(109, 3);
            buttonStatusDelete.Name = "buttonStatusDelete";
            buttonStatusDelete.Size = new Size(100, 30);
            buttonStatusDelete.TabIndex = 19;
            buttonStatusDelete.Text = "Eliminar";
            buttonStatusDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonStatusDelete.UseVisualStyleBackColor = true;
            buttonStatusDelete.Click += buttonStatusDelete_Click;
            // 
            // textBoxStatusEditDescription
            // 
            textBoxStatusEditDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStatusEditDescription.Location = new Point(121, 86);
            textBoxStatusEditDescription.Name = "textBoxStatusEditDescription";
            textBoxStatusEditDescription.Size = new Size(228, 25);
            textBoxStatusEditDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 2;
            label2.Text = "Editar Estatus:";
            // 
            // comboBoxStatusEdit
            // 
            comboBoxStatusEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatusEdit.FormattingEnabled = true;
            comboBoxStatusEdit.Location = new Point(121, 42);
            comboBoxStatusEdit.Name = "comboBoxStatusEdit";
            comboBoxStatusEdit.Size = new Size(228, 25);
            comboBoxStatusEdit.TabIndex = 1;
            comboBoxStatusEdit.SelectedIndexChanged += comboBoxStatusEdit_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 45);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 0;
            label8.Text = "Estatus:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1196, 578);
            panel2.TabIndex = 2;
            // 
            // StatusUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "StatusUserControl";
            Size = new Size(1196, 578);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
