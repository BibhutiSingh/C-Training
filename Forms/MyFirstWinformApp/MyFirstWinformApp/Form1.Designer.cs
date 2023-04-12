namespace MyFirstWinformApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnCheckAge = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(211, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Please enter your Date of Birth";
            // 
            // btnCheckAge
            // 
            this.btnCheckAge.Location = new System.Drawing.Point(440, 46);
            this.btnCheckAge.Name = "btnCheckAge";
            this.btnCheckAge.Size = new System.Drawing.Size(179, 37);
            this.btnCheckAge.TabIndex = 2;
            this.btnCheckAge.Text = "Check age";
            this.btnCheckAge.UseVisualStyleBackColor = true;
            this.btnCheckAge.Click += new System.EventHandler(this.btnCheckAge_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(46, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 46);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "##";
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(37, 49);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(397, 27);
            this.dtDOB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 208);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckAge);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "My Winform Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Button btnCheckAge;
        private Label lblResult;
        private DateTimePicker dtDOB;
    }
}