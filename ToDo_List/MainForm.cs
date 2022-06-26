using System;
using System.Media;
using System.Windows.Forms;
using ToDo_List.Properties;
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
            if (frmaddedittask.ShowDialog() == DialogResult.OK)
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
                uctaskview uctaskview = new uctaskview(task.TaskID, this);
                pltasks.Controls.Add(uctaskview);
                uctaskview.Dock = DockStyle.Top;
            }
        }
        public void UpdateList()
        {
            if (currentbutton != new Button())
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


        private void btndeletedb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف همه اطلاعات مظمئن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                nideletedbmessege.Visible = true;
                nideletedbmessege.BalloonTipTitle = "حذف داده ها";
                if (c.RemoveDB())
                {
                    nideletedbmessege.BalloonTipText = "تمامی داده ها پاک شد";
                    currentbutton.PerformClick();
                }
                else
                {
                    nideletedbmessege.BalloonTipText = "خطایی رخ داد ";
                }
                nideletedbmessege.ShowBalloonTip(3000);
            }
        }

        private void nideletedbmessege_BalloonTipClosed(object sender, EventArgs e)
        {
            nideletedbmessege.Visible = false;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length != 1)
            {
                SoundPlayer player = new SoundPlayer() { Stream = Resources.Alarm };
                player.Play();
                //ID#TaskName#Date
                if (MessageBox.Show($"Your task : {args[2]}\nDo you want to dismiss?", $"Alarm {args[2]}", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    c.DeleteReminder(int.Parse(args[1]));
                }
                else
                {
                    //remind later code
                }
                Application.Exit();
            }
        }

        private void btndebug_Click(object sender, EventArgs e)
        {
            c.removeempty();
        }
    }
}
