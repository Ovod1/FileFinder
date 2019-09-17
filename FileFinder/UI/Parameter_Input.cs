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
    public partial class Parameter_Input : Form
    {
        public Parameter_Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Project = new Project()
            //{
            //    Name = textBox1.Text,
            //    CustomerId = int.Parse(textBox2.Text)
            //};
            //Close();
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                var form = new Results();
                form.ShowDialog();
                Find.MakeSearch(textBox1.Text, textBox2.Text, textBox3.Text);
                Close();
            }
        }
    }
}
