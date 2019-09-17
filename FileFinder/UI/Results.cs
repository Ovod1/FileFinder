using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class Results : Form
    {
        private DateTime StartTime;
        public Results()
        {
            InitializeComponent();
            StartTime = DateTime.Now;
            Thread myThread = new Thread(new ThreadStart(Call_Tick));
            myThread.Start();
        }
        private void Call_Tick()
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(tmrClock_Tick);
            System.Threading.Timer timer = new System.Threading.Timer(tm, num, 0, 100);
        }
        private void tmrClock_Tick(object obj)
        {
                TimeSpan elapsed = DateTime.Now - StartTime;
                string text = "";
                //if (elapsed.Days > 0)
                //    text += elapsed.Days.ToString() + ".";
                int tenths = elapsed.Milliseconds / 100;
                text +=
                    elapsed.Hours.ToString("00") + ":" +
                    elapsed.Minutes.ToString("00") + ":" +
                    elapsed.Seconds.ToString("00") + "." +
                    tenths.ToString("0");
               textBox3.Text = text;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
