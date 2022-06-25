using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ToDo_List.Utility
{
    public partial class ucdatepicker : UserControl
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public DateTime Date { get; set; }
        Dictionary<string, int> months = new Dictionary<string, int>();
        private PersianCalendar _shamsidate;
        List<customLabel> days;

        #region DefineCustomLabels
        private customLabel lbl34;
        private customLabel lbl27;
        private customLabel lbl20;
        private customLabel lbl13;
        private customLabel lbl6;
        private customLabel lbl33;
        private customLabel lbl26;
        private customLabel lbl19;
        private customLabel lbl12;
        private customLabel lbl5;
        private customLabel lbl31;
        private customLabel lbl24;
        private customLabel lbl17;
        private customLabel lbl10;
        private customLabel lbl3;
        private customLabel lbl29;
        private customLabel lbl22;
        private customLabel lbl15;
        private customLabel lbl8;
        private customLabel lbl1;
        private customLabel lbl32;
        private customLabel lbl25;
        private customLabel lbl18;
        private customLabel lbl11;
        private customLabel lbl4;
        private customLabel lbl30;
        private customLabel lbl23;
        private customLabel lbl16;
        private customLabel lbl9;
        private customLabel lbl2;
        private customLabel lbl28;
        private customLabel lbl21;
        private customLabel lbl14;
        private customLabel lbl7;
        private customLabel lbl0;
        private customLabel lbl41;
        private customLabel lbl40;
        private customLabel lbl38;
        private customLabel lbl36;
        private customLabel lbl39;
        private customLabel lbl37;
        private customLabel lbl35;
        #endregion

        public ucdatepicker()
        {
            InitializeComponent();

            _shamsidate = new PersianCalendar();
            days = new List<customLabel>();

            #region DefineAllLabels
            lbl34 = new customLabel(this);
            lbl27 = new customLabel(this);
            lbl20 = new customLabel(this);
            lbl13 = new customLabel(this);
            lbl6 = new customLabel(this);
            lbl33 = new customLabel(this);
            lbl26 = new customLabel(this);
            lbl19 = new customLabel(this);
            lbl12 = new customLabel(this);
            lbl5 = new customLabel(this);
            lbl31 = new customLabel(this);
            lbl24 = new customLabel(this);
            lbl17 = new customLabel(this);
            lbl10 = new customLabel(this);
            lbl3 = new customLabel(this);
            lbl29 = new customLabel(this);
            lbl22 = new customLabel(this);
            lbl15 = new customLabel(this);
            lbl8 = new customLabel(this);
            lbl1 = new customLabel(this);
            lbl32 = new customLabel(this);
            lbl25 = new customLabel(this);
            lbl18 = new customLabel(this);
            lbl11 = new customLabel(this);
            lbl4 = new customLabel(this);
            lbl30 = new customLabel(this);
            lbl23 = new customLabel(this);
            lbl16 = new customLabel(this);
            lbl9 = new customLabel(this);
            lbl2 = new customLabel(this);
            lbl28 = new customLabel(this);
            lbl21 = new customLabel(this);
            lbl14 = new customLabel(this);
            lbl7 = new customLabel(this);
            lbl0 = new customLabel(this);
            lbl35 = new customLabel(this);
            lbl37 = new customLabel(this);
            lbl39 = new customLabel(this);
            lbl36 = new customLabel(this);
            lbl38 = new customLabel(this);
            lbl40 = new customLabel(this);
            lbl41 = new customLabel(this);

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

            #region CustomLabelModify
            lbl34.Location = new System.Drawing.Point(16, 170);
            lbl34.Size = new System.Drawing.Size(19, 13);
            lbl27.Location = new System.Drawing.Point(16, 141);
            lbl27.Size = new System.Drawing.Size(19, 13);
            lbl20.Location = new System.Drawing.Point(16, 110);
            lbl20.Size = new System.Drawing.Size(19, 13);
            lbl13.Location = new System.Drawing.Point(16, 78);
            lbl13.Size = new System.Drawing.Size(19, 13);
            lbl6.Location = new System.Drawing.Point(16, 47);
            lbl6.Size = new System.Drawing.Size(19, 13);
            lbl33.Location = new System.Drawing.Point(64, 170);
            lbl33.Size = new System.Drawing.Size(19, 13);
            lbl26.Location = new System.Drawing.Point(64, 141);
            lbl26.Size = new System.Drawing.Size(19, 13);
            lbl19.Location = new System.Drawing.Point(64, 110);
            lbl19.Size = new System.Drawing.Size(19, 13);
            lbl12.Location = new System.Drawing.Point(64, 78);
            lbl12.Size = new System.Drawing.Size(19, 13);
            lbl5.Location = new System.Drawing.Point(64, 47);
            lbl5.Size = new System.Drawing.Size(19, 13);
            lbl31.Location = new System.Drawing.Point(160, 170);
            lbl31.Size = new System.Drawing.Size(19, 13);
            lbl24.Location = new System.Drawing.Point(160, 141);
            lbl24.Size = new System.Drawing.Size(19, 13);
            lbl17.Location = new System.Drawing.Point(160, 110);
            lbl17.Size = new System.Drawing.Size(19, 13);
            lbl10.Location = new System.Drawing.Point(160, 78);
            lbl10.Size = new System.Drawing.Size(19, 13);
            lbl3.Location = new System.Drawing.Point(160, 47);
            lbl3.Size = new System.Drawing.Size(19, 13);
            lbl29.Location = new System.Drawing.Point(254, 170);
            lbl29.Size = new System.Drawing.Size(19, 13);
            lbl22.Location = new System.Drawing.Point(254, 141);
            lbl22.Size = new System.Drawing.Size(19, 13);
            lbl15.Location = new System.Drawing.Point(254, 110);
            lbl15.Size = new System.Drawing.Size(19, 13);
            lbl8.Location = new System.Drawing.Point(254, 78);
            lbl8.Size = new System.Drawing.Size(19, 13);
            lbl1.Location = new System.Drawing.Point(254, 47);
            lbl1.Size = new System.Drawing.Size(19, 13);
            lbl32.Location = new System.Drawing.Point(112, 170);
            lbl32.Size = new System.Drawing.Size(19, 13);
            lbl25.Location = new System.Drawing.Point(112, 141);
            lbl25.Size = new System.Drawing.Size(19, 13);
            lbl18.Location = new System.Drawing.Point(112, 110);
            lbl18.Size = new System.Drawing.Size(19, 13);
            lbl11.Location = new System.Drawing.Point(112, 78);
            lbl11.Size = new System.Drawing.Size(19, 13);
            lbl4.Location = new System.Drawing.Point(112, 47);
            lbl4.Size = new System.Drawing.Size(19, 13);
            lbl30.Location = new System.Drawing.Point(209, 170);
            lbl30.Size = new System.Drawing.Size(19, 13);
            lbl23.Location = new System.Drawing.Point(209, 141);
            lbl23.Size = new System.Drawing.Size(19, 13);
            lbl16.Location = new System.Drawing.Point(209, 110);
            lbl16.Size = new System.Drawing.Size(19, 13);
            lbl9.Location = new System.Drawing.Point(209, 78);
            lbl9.Size = new System.Drawing.Size(19, 13);
            lbl2.Location = new System.Drawing.Point(209, 47);
            lbl2.Size = new System.Drawing.Size(19, 13);
            lbl28.Location = new System.Drawing.Point(304, 170);
            lbl28.Size = new System.Drawing.Size(19, 13);
            lbl21.Location = new System.Drawing.Point(304, 141);
            lbl21.Size = new System.Drawing.Size(19, 13);
            lbl14.Location = new System.Drawing.Point(304, 110);
            lbl14.Size = new System.Drawing.Size(19, 13);
            lbl7.Location = new System.Drawing.Point(304, 78);
            lbl7.Size = new System.Drawing.Size(19, 13);
            lbl0.Location = new System.Drawing.Point(304, 47);
            lbl0.Size = new System.Drawing.Size(19, 13);
            lbl35.Location = new System.Drawing.Point(304, 199);
            lbl35.Size = new System.Drawing.Size(19, 13);
            lbl37.Location = new System.Drawing.Point(209, 199);
            lbl37.Size = new System.Drawing.Size(19, 13);
            lbl39.Location = new System.Drawing.Point(112, 199);
            lbl39.Size = new System.Drawing.Size(19, 13);
            lbl36.Location = new System.Drawing.Point(254, 199);
            lbl36.Size = new System.Drawing.Size(19, 13);
            lbl38.Location = new System.Drawing.Point(160, 199);
            lbl38.Size = new System.Drawing.Size(19, 13);
            lbl40.Location = new System.Drawing.Point(64, 199);
            lbl40.Size = new System.Drawing.Size(19, 13);
            lbl41.Location = new System.Drawing.Point(16, 199);
            lbl41.Size = new System.Drawing.Size(19, 13);
            #endregion

            #region PlaceLabelsToGroupbox
            groupBox1.Controls.Add(lbl41);
            groupBox1.Controls.Add(lbl34);
            groupBox1.Controls.Add(lbl27);
            groupBox1.Controls.Add(lbl20);
            groupBox1.Controls.Add(lbl13);
            groupBox1.Controls.Add(lbl6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lbl40);
            groupBox1.Controls.Add(lbl33);
            groupBox1.Controls.Add(lbl26);
            groupBox1.Controls.Add(lbl19);
            groupBox1.Controls.Add(lbl12);
            groupBox1.Controls.Add(lbl5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbl38);
            groupBox1.Controls.Add(lbl31);
            groupBox1.Controls.Add(lbl24);
            groupBox1.Controls.Add(lbl17);
            groupBox1.Controls.Add(lbl10);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbl36);
            groupBox1.Controls.Add(lbl29);
            groupBox1.Controls.Add(lbl22);
            groupBox1.Controls.Add(lbl15);
            groupBox1.Controls.Add(lbl8);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbl39);
            groupBox1.Controls.Add(lbl32);
            groupBox1.Controls.Add(lbl25);
            groupBox1.Controls.Add(lbl18);
            groupBox1.Controls.Add(lbl11);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbl37);
            groupBox1.Controls.Add(lbl30);
            groupBox1.Controls.Add(lbl23);
            groupBox1.Controls.Add(lbl16);
            groupBox1.Controls.Add(lbl9);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl35);
            groupBox1.Controls.Add(lbl28);
            groupBox1.Controls.Add(lbl21);
            groupBox1.Controls.Add(lbl14);
            groupBox1.Controls.Add(lbl7);
            groupBox1.Controls.Add(lbl0);
            groupBox1.Controls.Add(label1);
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
            day = _shamsidate.GetDayOfMonth(DateTime.Now);
            lbldate.Text = $"{year}/{month}/{day}";
            #endregion

        }
        private void uccalender_Load(object sender, EventArgs e)
        {
            LoadDays();

            this.Size = new System.Drawing.Size(339, 32);
            btndhowhide.Text = "V";
            cbmonth.Enabled = txtyear.Enabled = false;
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

        private void btndhowhide_Click(object sender, EventArgs e)
        {
            if (btndhowhide.Text=="V")
            {
                this.Size = new System.Drawing.Size(339, 286);
                btndhowhide.Text = "^";
                cbmonth.Enabled = txtyear.Enabled = true;
            }
            else
            {
                this.Size = new System.Drawing.Size(339, 32);
                btndhowhide.Text = "V";
                cbmonth.Enabled = txtyear.Enabled = false;
            }
        }

        private void lbldate_TextChanged(object sender, EventArgs e)
        {
            Date = _shamsidate.ToDateTime(year, month, day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            btndhowhide.PerformClick();
        }
        public void Showdate(DateTime dateTime)
        {
            year = _shamsidate.GetYear(dateTime);
            month = _shamsidate.GetMonth(dateTime);
            day = _shamsidate.GetDayOfMonth(dateTime);
            lbldate.Text = $"{year}/{month}/{day}";
        }
    }
}
