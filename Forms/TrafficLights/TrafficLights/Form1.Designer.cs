namespace TrafficLights
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
            this.components = new System.ComponentModel.Container();
            this.lblRedLight = new System.Windows.Forms.Label();
            this.lblYellowLight = new System.Windows.Forms.Label();
            this.lblGreenLight = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRedLight
            // 
            this.lblRedLight.AutoSize = true;
            this.lblRedLight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRedLight.ForeColor = System.Drawing.Color.Red;
            this.lblRedLight.Location = new System.Drawing.Point(52, 38);
            this.lblRedLight.Name = "lblRedLight";
            this.lblRedLight.Size = new System.Drawing.Size(172, 168);
            this.lblRedLight.TabIndex = 0;
            this.lblRedLight.Text = "O";
            // 
            // lblYellowLight
            // 
            this.lblYellowLight.AutoSize = true;
            this.lblYellowLight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYellowLight.ForeColor = System.Drawing.Color.DimGray;
            this.lblYellowLight.Location = new System.Drawing.Point(51, 187);
            this.lblYellowLight.Name = "lblYellowLight";
            this.lblYellowLight.Size = new System.Drawing.Size(172, 168);
            this.lblYellowLight.TabIndex = 1;
            this.lblYellowLight.Text = "O";
            // 
            // lblGreenLight
            // 
            this.lblGreenLight.AutoSize = true;
            this.lblGreenLight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreenLight.ForeColor = System.Drawing.Color.DimGray;
            this.lblGreenLight.Location = new System.Drawing.Point(52, 340);
            this.lblGreenLight.Name = "lblGreenLight";
            this.lblGreenLight.Size = new System.Drawing.Size(172, 168);
            this.lblGreenLight.TabIndex = 2;
            this.lblGreenLight.Text = "O";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("FandG Display Bank Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(394, 104);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(180, 90);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("FandG Display Bank Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecond.Location = new System.Drawing.Point(820, 104);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(180, 90);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = "00";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("FandG Display Bank Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinute.Location = new System.Drawing.Point(607, 104);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(180, 90);
            this.lblMinute.TabIndex = 5;
            this.lblMinute.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FandG Display Bank Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(767, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 90);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FandG Display Bank Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(555, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 90);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Elephant", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(394, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(468, 103);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "##-##-##";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 543);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblGreenLight);
            this.Controls.Add(this.lblYellowLight);
            this.Controls.Add(this.lblRedLight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRedLight;
        private Label lblYellowLight;
        private Label lblGreenLight;
        private System.Windows.Forms.Timer timer1;
        private Label lblHour;
        private Label lblSecond;
        private Label lblMinute;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer2;
        private Label lblDate;
    }
}