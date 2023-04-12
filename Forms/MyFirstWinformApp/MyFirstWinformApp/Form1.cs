namespace MyFirstWinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckAge_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime strAge = dtDOB.Value;
                int age = ((DateTime.Now - strAge).Days)/365;

                if (age > 18)
                {
                    lblResult.Text = $"You are of age {age} and is eligible for voting.";
                    lblResult.ForeColor = Color.FromArgb(0, 204, 153);
                }
                else
                {
                    lblResult.Text = $"You are of age {age} and is not eligible for voting.";
                    lblResult.ForeColor = Color.Red;
                }
            }
            catch (FormatException)
            {

                lblResult.Text = "Invalid Age.";
            }
            catch (Exception)
            {

                lblResult.Text = "Invalid Age.";
            }


        }
    }
}