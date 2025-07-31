using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_toy
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            frm_settings sett = new frm_settings();
            this.Hide();
            sett.Show();
        }

        private void btn_emoloyee_Click(object sender, EventArgs e)
        {
            frm_employee empl = new frm_employee();
            this.Hide();
            empl.Show();

        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            frm_salaryCal salCal = new frm_salaryCal();
            this.Hide();
            salCal.Show();

        }

        private void btn_showSal_Click(object sender, EventArgs e)
        {
            frm_show_salary shwSal = new frm_show_salary();
            this.Hide();
            shwSal.Show();
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            this.Hide();
            login.Show();
        }
    }
}
