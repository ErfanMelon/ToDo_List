using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ToDo_List.Utility
{
    public partial class ucdatepicker : UserControl
    {
        public int year { get; set; }
        public int month { get; set; }
        public PersianCalendar shamsidate { get; set; }
        Dictionary<string, int> months = new Dictionary<string, int>();
        private PersianCalendar _shamsidate;
        List<Label> days;


        public ucdatepicker()
        {
            InitializeComponent();

            _shamsidate = new PersianCalendar();
            days = new List<Label>();

            #region DefineAllLabels
            days.Add(lbl0);
            days.Add(lbl1);
            days.Add(lbl2);
            days.Add(lbl3);
            days.Add(lbl4);
            days.Add(lbl5);
            days.Add(lbl6);
            days.Add(lbl7);
            days.Add(lbl8);
            days.Add(lbl9);
            days.Add(lbl10);
            days.Add(lbl11);
            days.Add(lbl12);
            days.Add(lbl13);
            days.Add(lbl14);
            days.Add(lbl15);
            days.Add(lbl16);
            days.Add(lbl17);
            days.Add(lbl18);
            days.Add(lbl19);
            days.Add(lbl20);
            days.Add(lbl21);
            days.Add(lbl22);
            days.Add(lbl23);
            days.Add(lbl24);
            days.Add(lbl25);
            days.Add(lbl26);
            days.Add(lbl27);
            days.Add(lbl28);
            days.Add(lbl29);
            days.Add(lbl30);
            days.Add(lbl31);
            days.Add(lbl32);
            days.Add(lbl33);
            days.Add(lbl34);
            days.Add(lbl35);
            days.Add(lbl36);
            days.Add(lbl37);
            days.Add(lbl38);
            days.Add(lbl39);
            days.Add(lbl40);
            days.Add(lbl41);
            #endregion

            #region AddMonthNames
            months.Add("فروردین", 1);
            months.Add("اردیبهشت", 2);
            months.Add("خرداد", 3);
            months.Add("تیر", 4);
            months.Add("مرداد", 5);
            months.Add("شهریور", 6);
            months.Add("مهر", 7);
            months.Add("آبان", 8);
            months.Add("آذر", 9);
            months.Add("دی", 10);
            months.Add("بهمن", 11);
            months.Add("اسفند", 12);

            cbmonth.DataSource = new BindingSource(months, null);
            cbmonth.DisplayMember = "Key";
            cbmonth.ValueMember = "Value";
            #endregion

            #region DefaultValues
            txtyear.Value = _shamsidate.GetYear(DateTime.Now);
            cbmonth.SelectedIndex = _shamsidate.GetMonth(DateTime.Now) - 1;
            #endregion
        }
        private void uccalender_Load(object sender, EventArgs e)
        {
            LoadDays();
        }

        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = cbmonth.SelectedIndex + 1;
            LoadDays();
        }
        void LoadDays()
        {
            DateTime monthmiladi = new DateTime((int)txtyear.Value, month, 1, _shamsidate);
            DayOfWeek firstdayofmonth = _shamsidate.GetDayOfWeek(monthmiladi);
            int maxdayofmonth = _shamsidate.GetDaysInMonth((int)txtyear.Value, month);



            foreach (var item in days)
            {
                item.Text = "";
            }
            int counter = 1;
            switch (firstdayofmonth)
            {
                case DayOfWeek.Sunday:
                    foreach (var item in days)
                    {
                        if (item == days[0])
                            continue;
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                case DayOfWeek.Monday:
                    foreach (var item in days)
                    {
                        if (item == days[0] || item == days[1])
                            continue;
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                case DayOfWeek.Tuesday:
                    foreach (var item in days)
                    {
                        if (item == days[0] || item == days[1] || item == days[2])
                            continue;
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    foreach (var item in days)
                    {
                        if (item == days[0] || item == days[1] || item == days[2] || item == days[3])
                            continue;
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                case DayOfWeek.Thursday:
                    foreach (var item in days)
                    {
                        if (item == days[0] || item == days[1] || item == days[2] || item == days[3] || item == days[4])
                            continue;
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                case DayOfWeek.Friday:
                    foreach (var item in days)
                    {
                        if (item == days[0] || item == days[1] || item == days[2] || item == days[3] || item == days[4] || item == days[5])
                            continue;
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                case DayOfWeek.Saturday:
                    foreach (var item in days)
                    {
                        item.Text = counter.ToString();
                        counter++;
                        if (maxdayofmonth < counter)
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtyear_ValueChanged(object sender, EventArgs e)
        {
            year = (int)txtyear.Value;
            LoadDays();
        }

        private void lbl41_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hi");
            //var x = this.ActiveControl;

        }

        private void lbl41_MouseClick(object sender, MouseEventArgs e)
        {
            var x=e.Button;
        }
    }
}
