using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_List.WorkWithDatabase;

namespace ToDo_List
{
    public partial class uctaskview : UserControl
    {
        WorkWithDatabase.Task task = new WorkWithDatabase.Task();
        content c;
        private MainForm mainForm = null;
        public uctaskview(int taskid,Form callingform)
        {
            InitializeComponent();
            c = new content();
            mainForm = callingform as MainForm;
            task = c.FindTaskByID(taskid);
            cbtasknameandstate.Text = task.TaskName;
            cbtasknameandstate.Checked = task.TaskState;
            if (task.TaskDetail != null)
                lbdescription.Text = "📝";
            else
            {
                lbdescription.Text = "";
            }
            if (task.TaskReminder != DateTime.MinValue)
                lblreminder.Text = "⌛";
            else
                lblreminder.Text = "";
        }

        private void cbtasknameandstate_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbtasknameandstate.CheckState)
            {
                case CheckState.Unchecked:
                    cbtasknameandstate.ForeColor = Color.Black;
                    cbtasknameandstate.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
                    break;
                case CheckState.Checked:
                    cbtasknameandstate.ForeColor = Color.Gray;
                    cbtasknameandstate.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Strikeout);
                    break;
                case CheckState.Indeterminate:
                    break;
                default:
                    break;
            }
            task.TaskState = cbtasknameandstate.Checked;
            c.EditTaskState(task.TaskID, task.TaskState);
        }

        private void lbdescription_MouseHover(object sender, EventArgs e)
        {
            if(lbdescription.Text== "📝")
            {
                ttdetail.SetToolTip(lbdescription, task.TaskDetail);
            }
        }

        private void uctaskview_MouseClick(object sender, EventArgs e)
        {
            EditTask();
        }
        void EditTask()
        {
            frmaddedittask frmaddedittask = new frmaddedittask(frmaddedittask.Mode.Edit, task.TaskID);
            if (frmaddedittask.ShowDialog() == DialogResult.OK)
            {
                mainForm.UpdateList();
            }
        }

        private void btnedittask_Click(object sender, EventArgs e)
        {
            EditTask();
        }

        private void btnremovetask_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show($"{task.TaskName} میخواهید این مورد را حذف کنید؟","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                ninotif.Visible = true;
                ninotif.BalloonTipTitle = "حذف";

                if (c.DeleteTask(task.TaskID))
                {
                    ninotif.BalloonTipText = "با موفقیت حذف شد !";
                    mainForm.UpdateList();
                }
                else
                {
                    ninotif.BalloonTipText = "خطا در حذف";
                }
                ninotif.ShowBalloonTip(3000);
            }
        }

        private void ninotif_BalloonTipClosed(object sender, EventArgs e)
        {
            ninotif.Visible = false;
        }
    }
}
