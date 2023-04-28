namespace ADO_NET_Example
{
    partial class frmAllStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgStudent = new DataGridView();
            lblName = new Label();
            lblGender = new Label();
            lblId = new Label();
            lblDOB = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            SuspendLayout();
            // 
            // dgStudent
            // 
            dgStudent.AllowUserToAddRows = false;
            dgStudent.AllowUserToDeleteRows = false;
            dgStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Location = new Point(12, 31);
            dgStudent.Name = "dgStudent";
            dgStudent.ReadOnly = true;
            dgStudent.RowHeadersWidth = 51;
            dgStudent.RowTemplate.Height = 29;
            dgStudent.Size = new Size(615, 558);
            dgStudent.TabIndex = 0;
            dgStudent.CellContentClick += dgStudent_CellContentClick;
            dgStudent.RowEnter += dgStudent_RowEnter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(728, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name : ##";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(728, 173);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(86, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender : ##";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(728, 52);
            lblId.Name = "lblId";
            lblId.Size = new Size(51, 20);
            lblId.TabIndex = 3;
            lblId.Text = "Id : ##";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(728, 131);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(69, 20);
            lblDOB.TabIndex = 4;
            lblDOB.Text = "DOB : ##";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(873, 289);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(194, 48);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1073, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 48);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmAllStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 601);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblDOB);
            Controls.Add(lblId);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(dgStudent);
            Name = "frmAllStudents";
            Text = "View Students";
            Load += frmAllStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgStudent;
        private Label lblName;
        private Label lblGender;
        private Label lblId;
        private Label lblDOB;
        private Button btnEdit;
        private Button btnDelete;
    }
}