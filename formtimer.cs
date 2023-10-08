using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    
    public partial class formtimer : Form
    {
        int counterMenit;
        int counterDetik;
        public formtimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. membaca inout nilai menit dan detik, kemudian menyimpan pada variabel countermenit dan counterdetik
            counterMenit = Convert.ToInt32(textBoxMenit.Text);
            counterDetik = Convert.ToInt32(textBoxDetik.Text);
            //menampilkan nilai setting menit dan detik pada label timer
            labelTimerMenit.Text=counterMenit.ToString();
            labelTimerDetik.Text = counterDetik.ToString();
            //Enable-kan timernya
            timer1.Enabled= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //kurangi nilai counterdetik dan tampilkan nilai counter detik pada labeltimerdetik
            //counterDetik--;
            //labelTimerDetik.Text=counterDetik.ToString();
            //batasi pengurangan counter detik sampai dengan 0
            //counter detik dapat dikurangi selama nilainya > 0
            //jika nilai counter detik =0 maka reset nilainya menjadi 59
            //kurangi countermenit dengan 1
            //agar timer berhenti di 0 menit dan o detik maka harus dibatasi pengurangan menit/reset detik ke 59 hanya dapat dilakukan bila nilai menit > 0
            if (counterDetik >0) 
            { 
                counterDetik--;
            }
            else
            {
                if (counterMenit>0)
                {
                    counterDetik = 59;
                    counterMenit--;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            if(counterMenit ==0 && counterDetik <= 10) 
            {
                Console.Beep(1000,100);  
            }
            labelTimerDetik.Text = counterDetik.ToString();
            labelTimerMenit.Text = counterMenit.ToString();
        }
    }
}
