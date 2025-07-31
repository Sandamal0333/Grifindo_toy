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
    public partial class frm_employee : Form
    {
        public frm_employee()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();

        private void cle()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_address.Clear();
            txt_tp.Clear();
            txt_monthlySal.Clear();
            txt_otRateHr.Clear();
            txt_allowance.Clear();
            dtp_dob.ResetText();
            rb_male.Checked = false;
            rb_female.Checked = false;

            MessageBox.Show("All controles are cleared!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        string gen;

        private void frm_employee_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                dgv_employee.DataSource = dbc.showRec("select * from Employees");
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

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Male";
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Female";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();

                dbc.recOpr("insert into Employees values('"+txt_id.Text+"','"+txt_name.Text+"','"+txt_address.Text+"','"+dtp_dob.Text+"','"+gen+"','"+txt_tp.Text+"','"+txt_monthlySal.Text+"','"+txt_otRateHr.Text+"','"+txt_allowance.Text+"')");

                MessageBox.Show("New Recoard added Succesfully !!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dgv_employee.DataSource = dbc.showRec("select * from Employees ");
                dbc.closeCon();
                cle();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try 
            {
                dbc.conn();

                dbc.recOpr("Update Employees set emp_name='" + txt_name.Text + "',address='" + txt_address.Text + "' ,dob='" + dtp_dob.Text + "',gender='" + gen + "',tp='" + txt_tp.Text + "',monthly_salary='" + txt_monthlySal.Text + "',overtime_rate_hourly='" + txt_otRateHr.Text + "',allowances='" + txt_allowance.Text + "' where emp_id='" + txt_id.Text + "' ");

                MessageBox.Show("Record Update Successfully!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dgv_employee.DataSource = dbc.showRec("select * from Employees ");
                dbc.closeCon();
                cle();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try 
            {
                dbc.conn();
                SqlDataReader read = dbc.reader("Select * from Employees where emp_id='" + txt_id.Text + "' ");

                read.Read();

                txt_name.Text = read[1].ToString();
                txt_address.Text = read[2].ToString();
                dtp_dob.Text = read[3].ToString();
                gen = read[4].ToString();

                if (gen == "Female")
                {
                    rb_female.Checked = true;
                    rb_male.Checked = false;
                }
                else if (gen == "Male")
                {
                    rb_male.Checked = true;
                    rb_female.Checked = false;
                }

                txt_tp.Text = read[5].ToString();
                txt_monthlySal.Text = read[6].ToString();
                txt_otRateHr.Text = read[7].ToString();
                txt_allowance.Text = read[8].ToString();

                MessageBox.Show("Find Recoard founded!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dirRes;
                dirRes = MessageBox.Show("Do you want to delect this record ?", "Grifindo Toy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dirRes == DialogResult.Yes)
                {
                    dbc.conn();
                    dbc.recOpr("delete from Employees where emp_id ='" + txt_id.Text + "'");
                    MessageBox.Show("Record delete successfully !", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Action Abroted !", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error  :" + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dgv_employee.DataSource = dbc.showRec("select * from Employees ");
                dbc.closeCon();
                cle();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cle();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_dashboard dash = new frm_dashboard();
            this.Hide();
            dash.Show();
        }

        private void txt_tp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
