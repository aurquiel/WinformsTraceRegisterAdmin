namespace WinFormsAppTrazoRegistrosAdmin
{
    partial class RolesUserControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            buttonUserRoleRefreshData = new Button();
            groupBoxEditUser = new GroupBox();
            panel3 = new Panel();
            panel6 = new Panel();
            dataGridViewUserRoleEdit = new DataGridView();
            panel5 = new Panel();
            buttonUserRoleEdit = new Button();
            buttonUserRoleDelete = new Button();
            panel4 = new Panel();
            comboBoxUserRoleEdit = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            panel7 = new Panel();
            panel8 = new Panel();
            dataGridViewUserRoleAdd = new DataGridView();
            panel9 = new Panel();
            buttonUserRoleAdd = new Button();
            panel10 = new Panel();
            textBoxUserRolesNameAdd = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxEditUser.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserRoleEdit).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserRoleAdd).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 707);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBoxEditUser, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(1176, 707);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonUserRoleRefreshData);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 609);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1170, 95);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Refrescar Data";
            // 
            // buttonUserRoleRefreshData
            // 
            buttonUserRoleRefreshData.FlatAppearance.BorderColor = Color.Green;
            buttonUserRoleRefreshData.FlatStyle = FlatStyle.Flat;
            buttonUserRoleRefreshData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserRoleRefreshData.ForeColor = Color.Blue;
            buttonUserRoleRefreshData.Image = Properties.Resources.refresh;
            buttonUserRoleRefreshData.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserRoleRefreshData.Location = new Point(19, 39);
            buttonUserRoleRefreshData.Name = "buttonUserRoleRefreshData";
            buttonUserRoleRefreshData.Size = new Size(100, 30);
            buttonUserRoleRefreshData.TabIndex = 18;
            buttonUserRoleRefreshData.Text = "Refrescar";
            buttonUserRoleRefreshData.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserRoleRefreshData.UseVisualStyleBackColor = true;
            buttonUserRoleRefreshData.Click += buttonUserRoleRefreshData_Click;
            // 
            // groupBoxEditUser
            // 
            groupBoxEditUser.BackColor = Color.White;
            groupBoxEditUser.Controls.Add(panel3);
            groupBoxEditUser.Dock = DockStyle.Fill;
            groupBoxEditUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEditUser.Location = new Point(3, 3);
            groupBoxEditUser.Name = "groupBoxEditUser";
            groupBoxEditUser.Size = new Size(1170, 297);
            groupBoxEditUser.TabIndex = 20;
            groupBoxEditUser.TabStop = false;
            groupBoxEditUser.Text = "Editar Rol";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(1164, 269);
            panel3.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridViewUserRoleEdit);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 37);
            panel6.Name = "panel6";
            panel6.Size = new Size(1164, 188);
            panel6.TabIndex = 2;
            // 
            // dataGridViewUserRoleEdit
            // 
            dataGridViewUserRoleEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserRoleEdit.Dock = DockStyle.Fill;
            dataGridViewUserRoleEdit.Location = new Point(0, 0);
            dataGridViewUserRoleEdit.Name = "dataGridViewUserRoleEdit";
            dataGridViewUserRoleEdit.RowTemplate.Height = 25;
            dataGridViewUserRoleEdit.Size = new Size(1164, 188);
            dataGridViewUserRoleEdit.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonUserRoleEdit);
            panel5.Controls.Add(buttonUserRoleDelete);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(1164, 44);
            panel5.TabIndex = 1;
            // 
            // buttonUserRoleEdit
            // 
            buttonUserRoleEdit.FlatAppearance.BorderColor = Color.Green;
            buttonUserRoleEdit.FlatStyle = FlatStyle.Flat;
            buttonUserRoleEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserRoleEdit.ForeColor = Color.FromArgb(255, 128, 0);
            buttonUserRoleEdit.Image = Properties.Resources.edit;
            buttonUserRoleEdit.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserRoleEdit.Location = new Point(16, 6);
            buttonUserRoleEdit.Name = "buttonUserRoleEdit";
            buttonUserRoleEdit.Size = new Size(100, 30);
            buttonUserRoleEdit.TabIndex = 18;
            buttonUserRoleEdit.Text = "Editar";
            buttonUserRoleEdit.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserRoleEdit.UseVisualStyleBackColor = true;
            buttonUserRoleEdit.Click += buttonUserRoleEdit_Click;
            // 
            // buttonUserRoleDelete
            // 
            buttonUserRoleDelete.FlatAppearance.BorderColor = Color.Green;
            buttonUserRoleDelete.FlatStyle = FlatStyle.Flat;
            buttonUserRoleDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserRoleDelete.ForeColor = Color.FromArgb(192, 0, 0);
            buttonUserRoleDelete.Image = Properties.Resources.delete;
            buttonUserRoleDelete.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserRoleDelete.Location = new Point(122, 6);
            buttonUserRoleDelete.Name = "buttonUserRoleDelete";
            buttonUserRoleDelete.Size = new Size(100, 30);
            buttonUserRoleDelete.TabIndex = 19;
            buttonUserRoleDelete.Text = "Eliminar";
            buttonUserRoleDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserRoleDelete.UseVisualStyleBackColor = true;
            buttonUserRoleDelete.Click += buttonUserRoleDelete_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBoxUserRoleEdit);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1164, 37);
            panel4.TabIndex = 0;
            // 
            // comboBoxUserRoleEdit
            // 
            comboBoxUserRoleEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserRoleEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserRoleEdit.FormattingEnabled = true;
            comboBoxUserRoleEdit.Location = new Point(44, 3);
            comboBoxUserRoleEdit.Name = "comboBoxUserRoleEdit";
            comboBoxUserRoleEdit.Size = new Size(228, 25);
            comboBoxUserRoleEdit.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 6);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 0;
            label8.Text = "Rol:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panel7);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1170, 297);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Rol";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel10);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 25);
            panel7.Name = "panel7";
            panel7.Size = new Size(1164, 269);
            panel7.TabIndex = 22;
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridViewUserRoleAdd);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 37);
            panel8.Name = "panel8";
            panel8.Size = new Size(1164, 188);
            panel8.TabIndex = 2;
            // 
            // dataGridViewUserRoleAdd
            // 
            dataGridViewUserRoleAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserRoleAdd.Dock = DockStyle.Fill;
            dataGridViewUserRoleAdd.Location = new Point(0, 0);
            dataGridViewUserRoleAdd.Name = "dataGridViewUserRoleAdd";
            dataGridViewUserRoleAdd.RowTemplate.Height = 25;
            dataGridViewUserRoleAdd.Size = new Size(1164, 188);
            dataGridViewUserRoleAdd.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(buttonUserRoleAdd);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 225);
            panel9.Name = "panel9";
            panel9.Size = new Size(1164, 44);
            panel9.TabIndex = 1;
            // 
            // buttonUserRoleAdd
            // 
            buttonUserRoleAdd.FlatAppearance.BorderColor = Color.Green;
            buttonUserRoleAdd.FlatStyle = FlatStyle.Flat;
            buttonUserRoleAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUserRoleAdd.ForeColor = Color.Green;
            buttonUserRoleAdd.Image = Properties.Resources.add;
            buttonUserRoleAdd.ImageAlign = ContentAlignment.MiddleRight;
            buttonUserRoleAdd.Location = new Point(19, 6);
            buttonUserRoleAdd.Name = "buttonUserRoleAdd";
            buttonUserRoleAdd.Size = new Size(100, 30);
            buttonUserRoleAdd.TabIndex = 20;
            buttonUserRoleAdd.Text = "Agregar";
            buttonUserRoleAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonUserRoleAdd.UseVisualStyleBackColor = true;
            buttonUserRoleAdd.Click += buttonUserRoleAdd_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(textBoxUserRolesNameAdd);
            panel10.Controls.Add(label1);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1164, 37);
            panel10.TabIndex = 0;
            // 
            // textBoxUserRolesNameAdd
            // 
            textBoxUserRolesNameAdd.Location = new Point(117, 5);
            textBoxUserRolesNameAdd.Name = "textBoxUserRolesNameAdd";
            textBoxUserRolesNameAdd.Size = new Size(228, 29);
            textBoxUserRolesNameAdd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Rol:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1196, 727);
            panel2.TabIndex = 2;
            // 
            // RolesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "RolesUserControl";
            Size = new Size(1196, 727);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBoxEditUser.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserRoleEdit).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserRoleAdd).EndInit();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxEditUser;
        private Panel panel3;
        private Panel panel6;
        private DataGridView dataGridViewUserRoleEdit;
        private Panel panel5;
        private Button buttonUserRoleEdit;
        private Button buttonUserRoleDelete;
        private Panel panel4;
        private ComboBox comboBoxUserRoleEdit;
        private Label label8;
        private GroupBox groupBox2;
        private Button buttonUserRoleRefreshData;
        private GroupBox groupBox1;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dataGridViewUserRoleAdd;
        private Panel panel9;
        private Button buttonUserRoleAdd;
        private Panel panel10;
        private TextBox textBoxUserRolesNameAdd;
        private Label label1;
    }
}
