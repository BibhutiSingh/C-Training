namespace ADO_NET_Example
{
    partial class frmEditStudent
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
            label2 = new Label();
            label1 = new Label();
            cmbGender = new ComboBox();
            txtDob = new DateTimePicker();
            txtName = new TextBox();
            lblName = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 172);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 14;
            label2.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 105);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 13;
            label1.Text = "Date Of Birth";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(126, 169);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(569, 28);
            cmbGender.TabIndex = 12;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(126, 98);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(569, 27);
            txtDob.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(569, 27);
            txtName.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(561, 226);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Edit Student";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmEditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(txtDob);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Name = "frmEditStudent";
            Text = "Edit Student";
            Load += frmEditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cmbGender;
        private DateTimePicker txtDob;
        private TextBox txtName;
        private Label lblName;
        private Button btnSave;
    }
}