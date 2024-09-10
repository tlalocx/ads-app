
namespace ads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random rnd = new();

        private void Timer1_Tick(object sender, EventArgs e)
        {

            string[] keys = { " ", "A", "S", "D", "F" };
            string keyToSend = keys[rnd.Next(keys.Length)];

            SendKeys.SendWait(keyToSend);

            timer1.Interval = rnd.Next(5000, 15000);
        }
    }
}