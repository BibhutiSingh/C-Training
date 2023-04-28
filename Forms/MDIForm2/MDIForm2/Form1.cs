using System.Windows.Forms;

namespace MDIForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog=new OpenFileDialog();
            fileDialog.Filter = "Image Files (*.png)|*.png|All Files (*.*)|*.*";
            if ( fileDialog.ShowDialog(this) == DialogResult.OK )
            {
                textBox1.Text = fileDialog.FileName;
            }
        }
    }
}