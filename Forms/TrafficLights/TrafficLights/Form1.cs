namespace TrafficLights
{
    public partial class Form1 : Form
    {
        public TrafficLights CurrentLight { get; set; }

        public int CurrentHour { get; set; }
        public int CurrentMinute { get; set; }
        public int CurrentSecond { get; set; }


        public Form1()
        {
            InitializeComponent();
            CurrentLight = TrafficLights.Red;
            CurrentHour = 0;
            CurrentMinute = 0;
            CurrentSecond = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRedLight.ForeColor = Color.DimGray;
            lblYellowLight.ForeColor = Color.DimGray;
            lblGreenLight.ForeColor = Color.DimGray;
            switch (CurrentLight)
            {
                case TrafficLights.Red:
                    CurrentLight = TrafficLights.Yellow;
                    lblYellowLight.ForeColor = Color.Yellow;
                    break;
                case TrafficLights.Yellow:
                    CurrentLight = TrafficLights.Green;
                    lblGreenLight.ForeColor = Color.DarkGreen;
                    break;
                case TrafficLights.Green:
                    CurrentLight = TrafficLights.Red;
                    lblRedLight.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (CurrentSecond == 59)
            {
                CurrentSecond = 0;
                if (CurrentMinute == 59)
                {
                    CurrentMinute= 0;
                    CurrentHour++;
                }
                else
                {
                    CurrentMinute++;
                }
               
            }
            else
            {
                CurrentSecond++;
            }

            lblSecond.Text = CurrentSecond.ToString("D2");
            lblMinute.Text = CurrentMinute.ToString("D2");
            lblHour.Text = CurrentHour.ToString("D2");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
    public enum TrafficLights
    {
        Red,
        Yellow,
        Green
    }
}