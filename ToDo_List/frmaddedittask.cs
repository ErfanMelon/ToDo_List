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
using ToDo_List.Utility;
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
                    txthour.Value = DateTime.Now.Hour;
                    txtmin.Value = DateTime.Now.Minute;
                    
                    break;
                case Mode.Edit:
                    this.Text = "ویرایش";
                    btnadd.Text = "ویرایش";
                    this.Icon = Resources.editicon;
                    task = c.FindTaskByID(taskid);
                    txttaskname.Text = task.TaskName;
                    txtdetail.Text = task.TaskDetail;
                    cbstate.Checked = task.TaskState;
                    
                    if (task.TaskReminder != DateTime.MinValue)
                    {
                        txthour.Value = task.TaskReminder.Hour;
                        txtmin.Value = task.TaskReminder.Minute;
                        dtpreminder.Showdate(task.TaskReminder);
                        cbreminder.Checked = true;
                    }
                        
                    break;
                default:
                    break;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Operation();
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
                    label2.Enabled = label3.Enabled = label4.Enabled = txthour.Enabled = txtmin.Enabled = dtpreminder.Enabled = false;
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
        private void Operation()
        {
            DateTime dt = DateTime.MinValue;
            if (cbreminder.CheckState == CheckState.Checked)
            {
                dt = new DateTime(dtpreminder.Date.Year,dtpreminder.Date.Month,dtpreminder.Date.Day,int.Parse(txthour.Value.ToString()),int.Parse(txtmin.Value.ToString()),0);
            }
            nishowresult.Visible = true;
            switch (mod)
            {
                case Mode.Add:
                    nishowresult.Icon = Resources.addnote;
                    bool addtask = c.AddTask(new WorkWithDatabase.Task() { TaskName = txttaskname.Text.Trim(), TaskState = cbstate.Checked, TaskDetail = txtdetail.Text.Trim(), TaskReminder=dt });
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
                    bool edittask = c.EditTask(new WorkWithDatabase.Task() { TaskID = task.TaskID, TaskDetail = txtdetail.Text.Trim(), TaskName = txttaskname.Text.Trim(), TaskState = cbstate.Checked,TaskReminder=dt });
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
        private bool Validation()
        {
            if (txttaskname.Text.Trim() == "")//validate taskname
            {
                MessageBox.Show("نام کار نمیتواند خالی باشد !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            switch (cbreminder.CheckState)
            {
                case CheckState.Unchecked:
                    break;
                case CheckState.Checked:
                    if (int.Parse(txthour.Value.ToString()) > 23 || int.Parse(txthour.Value.ToString()) < 0 || int.Parse(txtmin.Value.ToString()) < 0 || int.Parse(txtmin.Value.ToString()) > 59)
                    {
                        MessageBox.Show("زمان معتبر نیست !");
                        return false;
                    }
                    if (DateTime.Compare(DateTime.Now.Date, dtpreminder.Date.Date) > 0)
                    {
                        MessageBox.Show("تاریخ گذشته است !");
                        return false;
                    }
                    else if (DateTime.Compare(DateTime.Now.Date, dtpreminder.Date.Date) == 0)
                    {
                        if (DateTime.Compare(new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0), new DateTime(1, 1, 1, int.Parse(txthour.Value.ToString()), int.Parse(txtmin.Value.ToString()), 0)) >= 0)
                        {
                            MessageBox.Show("زمان گذشته است !");
                            return false;
                        }
                    }
                    break;
                case CheckState.Indeterminate:
                    break;
                default:
                    break;
            }//validate date and time
            return true;
        }
    }
}
