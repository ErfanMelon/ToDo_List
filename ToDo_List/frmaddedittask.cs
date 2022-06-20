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
    public partial class frmaddedittask : Form
    {
        content c;
        Mode mod;
        WorkWithDatabase.Task task;
        public enum Mode
        {
            Add,
            Edit
        }
        public frmaddedittask(Mode mode, int taskid = 0)
        {
            InitializeComponent();
            c = new content();
            mod = mode;
            switch (mode)
            {
                case Mode.Add:
                    this.Text = "افزودن";
                    btnadd.Text = "افزودن";
                    break;
                case Mode.Edit:
                    this.Text = "ویرایش";
                    btnadd.Text = "ویرایش";
                    task = c.FindTaskByID(taskid);
                    txttaskname.Text = task.TaskName;
                    txtdetail.Text = task.TaskDetail;
                    cbstate.Checked = task.TaskState;
                    break;
                default:
                    break;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txttaskname.Text.Trim() != "")
            {
                switch (mod)
                {
                    case Mode.Add:

                        bool addtask = c.AddTask(new WorkWithDatabase.Task() { TaskName = txttaskname.Text.Trim(), TaskState = cbstate.Checked, TaskDetail = txtdetail.Text.Trim() });
                        nishowresult.Text = "افزودن کا جدید";
                        if (addtask)
                        {
                            nishowresult.BalloonTipText = "عملیات با موفقیت انجام شد";
                        }
                        else
                        {
                            nishowresult.BalloonTipText = "عملیات با خطا مواجه شد !";
                        }
                        nishowresult.ShowBalloonTip(3000);
                        DialogResult = DialogResult.OK;
                        nishowresult.Dispose();
                        break;
                    case Mode.Edit:

                        bool edittask = c.EditTask(new WorkWithDatabase.Task() { TaskID = task.TaskID, TaskDetail = txtdetail.Text.Trim(), TaskName = txttaskname.Text.Trim(), TaskState = cbstate.Checked });
                        if (edittask)
                        {
                            nishowresult.BalloonTipText = "عملیات با موفقیت انجام شد";
                        }
                        else
                        {
                            nishowresult.BalloonTipText = "عملیات با خطا مواجه شد !";
                        }
                        nishowresult.ShowBalloonTip(3000);
                        DialogResult = DialogResult.OK;
                        nishowresult.Dispose();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("نام کار نمیتواند خالی باشد !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
