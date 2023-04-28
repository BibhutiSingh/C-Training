namespace ADO_NET_Example
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            bookIssueToolStripMenuItem = new ToolStripMenuItem();
            issueABookToolStripMenuItem = new ToolStripMenuItem();
            viewHistoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, booksToolStripMenuItem, bookIssueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1338, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuMain";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem, addStudentToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(74, 24);
            studentToolStripMenuItem.Text = "Student";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(224, 26);
            listToolStripMenuItem.Text = "View Students";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click_1;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(224, 26);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, addNewBookToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(63, 24);
            booksToolStripMenuItem.Text = "Books";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(192, 26);
            viewToolStripMenuItem.Text = "View";
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(192, 26);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            // 
            // bookIssueToolStripMenuItem
            // 
            bookIssueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { issueABookToolStripMenuItem, viewHistoryToolStripMenuItem });
            bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            bookIssueToolStripMenuItem.Size = new Size(89, 24);
            bookIssueToolStripMenuItem.Text = "BookIssue";
            // 
            // issueABookToolStripMenuItem
            // 
            issueABookToolStripMenuItem.Name = "issueABookToolStripMenuItem";
            issueABookToolStripMenuItem.Size = new Size(176, 26);
            issueABookToolStripMenuItem.Text = "Issue A Book";
            // 
            // viewHistoryToolStripMenuItem
            // 
            viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            viewHistoryToolStripMenuItem.Size = new Size(176, 26);
            viewHistoryToolStripMenuItem.Text = "View History";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 625);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Main Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem bookIssueToolStripMenuItem;
        private ToolStripMenuItem issueABookToolStripMenuItem;
        private ToolStripMenuItem viewHistoryToolStripMenuItem;
    }
}