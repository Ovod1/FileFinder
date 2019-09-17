using FileFinder.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            textBox1.Text = History.HistoryInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Results();
            form.ShowDialog();
            if (textBox1.Text == "Есть")
                Find.MakeOldSearch();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Parameter_Input();
            form.ShowDialog();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    db.Projects.Add(form.Project);
            //    db.SaveChanges();
            //}
        }

    }
}
