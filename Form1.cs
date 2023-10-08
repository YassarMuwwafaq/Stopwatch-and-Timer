using System.Diagnostics.Metrics;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {
        int counter = 0;
        int counterMenit = 0;
        public Stopwatch()
        {
            InitializeComponent();
        }


        private void timerstopwatch_Tick(object sender, EventArgs e)
        {
            counter++;
            labelstopwatch.Left += 4;
            //console.Beep(2000, 100);
            if (counter == 60)
            {
                labelstopwatch.Left= 20;
                counter= 0;
                counterMenit++;
            }
            labelDetik.Text = counter.ToString();
            labelMenit.Text = counterMenit.ToString();
        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            timerstopwatch.Enabled = true;
        }

        private void buttonBerhenti_Click(object sender, EventArgs e)
        {
            timerstopwatch.Enabled= false;
        }

    }
}