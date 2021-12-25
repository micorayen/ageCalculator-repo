using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Enter_dates : Form
    {
        public Enter_dates()
        {
            InitializeComponent();
        }

        // put action to button "Calculate"
        private void button1_Click(object sender, EventArgs e)
        {
            int compareDates = DateTime.Now.CompareTo(dtp_bdate.Value);
            if (compareDates > 0)
            {
                Result frm_Result = new Result(dtp_bdate.Value);
                this.Hide();
                frm_Result.ShowDialog();
            }
            else if (compareDates < 0)
            {
                MessageBox.Show("You can't Enter Date Later than Current Date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Exit program
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
