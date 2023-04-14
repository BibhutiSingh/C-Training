namespace CrossformCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            if(string.IsNullOrEmpty(name) )
            {
                MessageBox.Show("Please provide correct name.");
            }
            else
            {
                frmWelcome frmWelcome= new frmWelcome(name);

                frmWelcome.Show();
                this.Hide();
            }
        }
    }
}