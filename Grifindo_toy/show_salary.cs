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
    public partial class frm_show_salary : Form
    {
        public frm_show_salary()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();

        private void cle()
        {
            txt_empID.Clear();
            txt_slID.Clear();

            MessageBox.Show("All controles are cleared!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frm_show_salary_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                dgv_salary.DataSource = dbc.showRec("select * from Salary_Details");
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cle();
        }

        private void btn_salIdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                dgv_salary.DataSource = dbc.showRec("select * from Salary_Details where salary_id='"+txt_slID.Text+"' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbc.closeCon();
                cle();
            }
        }

        private void btn_empIdSarch_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                dgv_salary.DataSource = dbc.showRec("select * from Salary_Details where emp_id='" + txt_empID.Text + "' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbc.closeCon();
                cle();
            }

        }
    }
}
