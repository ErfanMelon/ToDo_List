using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_List.Properties;
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
                    this.Icon = Resources.addnote;
                    break;
                case Mode.Edit:
                    this.Text = "ویرایش";
                    btnadd.Text = "ویرایش";
                    this.Icon = Resources.editicon;
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
                nishowresult.Visible = true;
                switch (mod)
                {
                    case Mode.Add:
                        nishowresult.Icon = Resources.addnote;
                        bool addtask = c.AddTask(new WorkWithDatabase.Task() { TaskName = txttaskname.Text.Trim(), TaskState = cbstate.Checked, TaskDetail = txtdetail.Text.Trim() });
                        if (addtask)
                        {
                            nishowresult.BalloonTipText = "عملیات با موفقیت انجام شد";
                        }
                        else
                        {
                            nishowresult.BalloonTipIcon = ToolTipIcon.Error;
                            nishowresult.BalloonTipText = "عملیات با خطا مواجه شد !";
                        }
                        break;
                    case Mode.Edit:
                        nishowresult.Icon = Resources.editicon;
                        bool edittask = c.EditTask(new WorkWithDatabase.Task() { TaskID = task.TaskID, TaskDetail = txtdetail.Text.Trim(), TaskName = txttaskname.Text.Trim(), TaskState = cbstate.Checked });
                        if (edittask)
                        {
                            nishowresult.BalloonTipText = "عملیات با موفقیت انجام شد";
                        }
                        else
                        {
                            nishowresult.BalloonTipIcon = ToolTipIcon.Error;
                            nishowresult.BalloonTipText = "عملیات با خطا مواجه شد !";
                        }
                        break;
                    default:
                        break;
                }
                nishowresult.ShowBalloonTip(3000);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("نام کار نمیتواند خالی باشد !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nishowresult_BalloonTipClosed(object sender, EventArgs e)
        {
            nishowresult.Visible = false;
        }

        private void cbreminder_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbreminder.CheckState)
            {
                case CheckState.Unchecked:
                    label2.Enabled = label3.Enabled = label4.Enabled = txthour.Enabled = txtmin.Enabled=dtpreminder.Enabled = false;
                    break;
                case CheckState.Checked:
                    label2.Enabled = label3.Enabled = label4.Enabled = txthour.Enabled = txtmin.Enabled = dtpreminder.Enabled = true;
                    break;
                case CheckState.Indeterminate:
                    break;
                default:
                    break;
            }
        }
    }
}
