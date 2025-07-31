using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_toy
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();

                dbc.recOpr("Update Settings set salary_month='" + dtp_month.Text + "',salary_cycle_days='" + txt_cyDays.Text + "' ,salary_cycle_begin_date='" + dtp_startD.Text + "',salary_cycle_end_date='" + dtp_endD.Text + "',annual_leave_days='" + txt_anLeav.Text + "' where setting_id='" + txt_stID.Text + "' ");

                MessageBox.Show("Record Update Successfully!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dgv_settings.DataSource = dbc.showRec("select * from Settings");
                dbc.closeCon();
            }
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                dgv_settings.DataSource = dbc.showRec("select * from Settings");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbc.closeCon();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_dashboard dash = new frm_dashboard();
            this.Hide();
            dash.Show();

        }

       
    }
}
