using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_List.WorkWithDatabase;

namespace ToDo_List
{
    public partial class MainForm : Form
    {
        content c;
        Button currentbutton;
        public MainForm()
        {
            InitializeComponent();
            c = new content();
            currentbutton = new Button();
        }

        private void btnaddnewtask_Click(object sender, EventArgs e)
        {
            frmaddedittask frmaddedittask = new frmaddedittask(frmaddedittask.Mode.Add);
            if(frmaddedittask.ShowDialog()==DialogResult.OK)
            {
                this.UpdateList();
            }
        }

        private void btnalltasks_Click(object sender, EventArgs e)
        {
            currentbutton = btnalltasks;
            pltasks.Controls.Clear();
            foreach (var task in c.All_Tasks())
            {
                uctaskview uctaskview = new uctaskview(task.TaskID,this);
                pltasks.Controls.Add(uctaskview);
                uctaskview.Dock = DockStyle.Top;
            }
        }
        public void UpdateList()
        {
            if(currentbutton!=new Button())
                currentbutton.PerformClick();
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            currentbutton = btndone;
            pltasks.Controls.Clear();
            foreach (var task in c.All_Tasks())
            {
                if (!task.TaskState)
                    continue;
                uctaskview uctaskview = new uctaskview(task.TaskID, this);
                pltasks.Controls.Add(uctaskview);
                uctaskview.Dock = DockStyle.Top;
            }
        }

        private void btndidnt_Click(object sender, EventArgs e)
        {
            currentbutton = btndidnt;
            pltasks.Controls.Clear();
            foreach (var task in c.All_Tasks())
            {
                if (task.TaskState)
                    continue;
                uctaskview uctaskview = new uctaskview(task.TaskID, this);
                pltasks.Controls.Add(uctaskview);
                uctaskview.Dock = DockStyle.Top;
            }
        }

        private void btnalltasks_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}
