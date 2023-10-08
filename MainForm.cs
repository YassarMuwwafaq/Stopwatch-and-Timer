using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class MainForm : Form
    {
        
        //1. buat form menjadi objek
        Stopwatch stopwatch;
        formtimer timer;

        //2. buat prosedur closed_stopwatch dan closed_timer
        void stopwatch_formClosed(object sender, FormClosedEventArgs e)
        {
            stopwatch = null;
        }

        void timer_formClosed(object sender, FormClosedEventArgs e)
        {
            timer = null;
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Submenu_StopWatch_Click(object sender, EventArgs e)
        {
            if (stopwatch == null)
            {
                stopwatch = new Stopwatch();
                stopwatch.MdiParent= this;
                //panggil void form close yang sudah dibuat
                stopwatch.FormClosed += new FormClosedEventHandler(stopwatch_formClosed);
                stopwatch.Show();
            }
            else
            {
                stopwatch.Activate();
            }
        }

        private void Submenu_Timer_Click(object sender, EventArgs e)
        {
            if (timer== null)
            {
                timer = new formtimer();
                timer.MdiParent= this;
                //panggil void form close yang sudah dibuat
                timer.FormClosed += new FormClosedEventHandler(timer_formClosed);
                timer.Show();
            }
            else
            {
                timer.Activate();
            }
        }

        
    }
}
