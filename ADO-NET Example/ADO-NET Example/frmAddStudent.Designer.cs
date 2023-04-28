namespace ADO_NET_Example
{
    partial class frmAddStudent
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
            btnSave = new Button();
            lblName = new Label();
            txtName = new TextBox();
            txtDob = new DateTimePicker();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(574, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add Student";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(37, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(569, 27);
            txtName.TabIndex = 2;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(139, 114);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(569, 27);
            txtDob.TabIndex = 3;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(139, 185);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(569, 28);
            cmbGender.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 121);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 5;
            label1.Text = "Date Of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 188);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 7;
            label2.Text = "Gender";
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 325);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(txtDob);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Name = "frmAddStudent";
            Text = "Add Students";
            Load += frmAddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblName;
        private TextBox txtName;
        private DateTimePicker txtDob;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
    }
}