using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_List.Properties;

namespace ToDo_List
{
    public partial class Form1 : Form
    {
        string[] arg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    var d=DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            //    var s = DateTime.ParseExact(d, "dd-MM-yyyy HH:mm:ss",CultureInfo.InvariantCulture);

            string[] args = Environment.GetCommandLineArgs();
            arg = args;
            if(args.Length!=1)
            {
                MessageBox.Show($"{args[1]}");
            }
                

        }

        private void uccalender1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility.Reminder r = new Utility.Reminder();
            r.CreateTask("Tk248483", "Erfan", "des", DateTime.Now, "id1", "2022-06-26T11:41:00", "2022-06-26T11:42:00", "aid", arg[0], "Hello now");
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        }
    }
}
