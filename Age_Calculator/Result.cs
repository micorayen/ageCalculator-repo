using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Age_Calculator
{
    public partial class Result : Form
    {
        DateTime age, nbdAge, newInputDate;
        TimeSpan difference, nbdDifference;
        int inputYear, currentYear, resultYear;
        public Result(DateTime chkindate)
        {
            // 
            // Birth Date & Today's Date
            // 
            InitializeComponent();
            lbl_bdate.Text = chkindate.ToString("MM/dd/yyyy");
            lbl_tdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            // 
            // Determine Age
            // 
            difference = DateTime.Now.Subtract(chkindate);
            age = DateTime.MinValue + difference;
            int years = age.Year - 1;
            int months = age.Month - 1;
            int days = age.Day - 1;
            lbl_ayears.Text = years.ToString();
            lbl_amonths.Text = months.ToString();
            lbl_adays.Text = days.ToString();
            // 
            // Next Birthday
            // 
            Double m1 = Convert.ToDouble(chkindate.Month);
            Double m2 = Convert.ToDouble(DateTime.Now.Month);
            Double d1 = Convert.ToDouble(chkindate.Day);
            Double d2 = Convert.ToDouble(DateTime.Now.Day);

            inputYear = Convert.ToInt16(chkindate.Year);
            currentYear = Convert.ToInt16(DateTime.Now.Year);
            resultYear = currentYear - inputYear;
            if(m1 < m2)
            {   
                newInputDate = chkindate.AddYears(resultYear + 1);
                getNextBirthday();
            }
            else if (m1 > m2)
            {
                newInputDate = chkindate.AddYears(resultYear);
                getNextBirthday();
            }
            else if (m1 == m2)
            {
                if (d1 > d2)
                {
                    newInputDate = chkindate.AddYears(resultYear);
                    getNextBirthday();
                }
                else if (d1 < d2)
                {
                    newInputDate = chkindate.AddYears(resultYear + 1);
                    getNextBirthday();
                }
                else if (d1 == d2)
                {
                    lbl_nbd.Text = "12 Months | 0 Days";
                }
            }
            // 
            // Total Summary
            // 
            int smonths = (years * 12) + months;
            lbl_syears.Text = lbl_ayears.Text;
            lbl_smonths.Text = smonths.ToString();
            lbl_sdays.Text = difference.TotalDays.ToString("#");
        }

        public void getNextBirthday()
        {
            nbdDifference = newInputDate.Subtract(DateTime.Now);
            nbdAge = DateTime.MinValue + nbdDifference;
            int nbdMonths = nbdAge.Month - 1;
            int nbdDays = nbdAge.Day;
            lbl_nbd.Text = nbdMonths.ToString() + " Months | " + nbdDays.ToString() + " Days";
        }

        // Enter new Date
        public void isOpen()
        {
            foreach (var OpenForm in Application.OpenForms)
            {
                if ((OpenForm) is Enter_dates)
                {
                    ((Enter_dates)OpenForm).Show();
                }
            }
        }
        
        private void pbEnterNewDate2_Click(object sender, EventArgs e)
        {
            isOpen();
            this.Close();
        }

        private void pbEnterNewDate1_MouseMove(object sender, MouseEventArgs e)
        {
            pbEnterNewDate2.BringToFront();
        }

        private void pbEnterNewDate2_MouseLeave(object sender, EventArgs e)
        {
            pbEnterNewDate1.BringToFront();
        }
    }
}
