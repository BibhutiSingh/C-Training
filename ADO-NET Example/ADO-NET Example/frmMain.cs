namespace ADO_NET_Example
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        private void listToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAllStudents frmStudent = new frmAllStudents();
            frmStudent.MdiParent = (this);
            frmStudent.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent();
            frmAddStudent.MdiParent = (this);
            frmAddStudent.Show();
        }
    }
}