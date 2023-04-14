namespace MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm= new Form2();
            frm.MdiParent= this;
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}