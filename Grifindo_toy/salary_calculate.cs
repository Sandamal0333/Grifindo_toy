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
    public partial class frm_salaryCal : Form
    {
        public frm_salaryCal()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();
        Salary slryEmp = new Salary();

        private void cle()
        {
            txt_empID.Clear();
            txt_monthlySal.Clear();
            txt_otRateHr.Clear();
            txt_allowance.Clear();
            txt_cyDays.Clear();
            dtp_startD.ResetText();
            dtp_endD.ResetText();
            txt_anLeav.Clear();
            txt_workedDy.Clear();
            txt_otHours.Clear();
            txt_sal_ID.Clear();
            txt_noPay.Clear();
            txt_grossPay.Clear();
            txt_basePay.Clear();

            MessageBox.Show("All controles are cleared!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void txt_cyDays_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btn_getData_Click(object sender, EventArgs e)
        {
            if (txt_empID.Text=="")
            {
                MessageBox.Show("Please enter data to feilds", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    dbc.conn();
                    SqlDataReader read = dbc.reader("Select * from Employees where emp_id='" + txt_empID.Text + "' ");
                    read.Read();
                    txt_monthlySal.Text = read[6].ToString();
                    txt_otRateHr.Text = read[7].ToString();
                    txt_allowance.Text = read[8].ToString();

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
        }

        private void btn_getStingDetails_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                SqlDataReader read2 = dbc.reader("Select * from Settings where setting_id=1 ");
                read2.Read();
                txt_cyDays.Text = read2[2].ToString();
                dtp_startD.Text = read2[3].ToString();
                dtp_endD.Text = read2[4].ToString();
                txt_anLeav.Text = read2[5].ToString();
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

        private void dtp_startD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtp_startD_MouseEnter(object sender, EventArgs e)
        {
            
        }

        int basic_salary,no_pay,date_range,worked_days,ab_days;
        int base_pay, ot_hours, ot_rate, allowance;

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_grossPay.Text == "")
            {
                MessageBox.Show("Please Calculate Salaries First", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try
                {
                    dbc.conn();
                    dbc.recOpr("insert into Salary_Details values('"+txt_sal_ID.Text+"','"+txt_empID.Text+"','"+dtp_startD.Text+"','"+dtp_endD.Text+"','"+ab_days+"','"+ot_hours+"','"+no_pay+"','"+base_pay+"','"+gross_pay+"') ");
                    MessageBox.Show("Salary Details added Succesfully!", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cle();
        }

        int gross_pay, taxRT;
    
        private void btn_grossPayCal_Click(object sender, EventArgs e)
        {
            if (txt_basePay.Text == "")
            {
                MessageBox.Show("Please Calculate Base Pay First", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                if (base_pay > 100000)
                {
                    taxRT = 10;
                }
                else
                {
                    taxRT = 0;
                }

                base_pay = Convert.ToInt32(txt_basePay.Text);
                no_pay = Convert.ToInt32(txt_noPay.Text);

                gross_pay = slryEmp.grossPay(base_pay, no_pay, taxRT);
                txt_grossPay.Text = gross_pay.ToString();

            }
        }

        

        private void btn_basePayCal_Click(object sender, EventArgs e)
        {
            if (txt_otHours.Text == "")
            {
                MessageBox.Show("Please enter data to feilds", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                allowance = Convert.ToInt32(txt_allowance.Text);
                ot_rate = Convert.ToInt32(txt_otRateHr.Text);
                ot_hours = Convert.ToInt32(txt_otHours.Text);
                base_pay = slryEmp.basePay(basic_salary, allowance, ot_rate, ot_hours);
                txt_basePay.Text = base_pay.ToString();
            }
        }

        private void btn_noPayCal_Click(object sender, EventArgs e)
        {
            if (txt_workedDy.Text == "")
            {
                MessageBox.Show("please fill the fields first ", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                basic_salary = Convert.ToInt32(txt_monthlySal.Text);
                date_range = Convert.ToInt32(txt_cyDays.Text);
                worked_days = Convert.ToInt32(txt_workedDy.Text);
                ab_days = slryEmp.findAbDays(worked_days, date_range);
                no_pay = slryEmp.noPay(basic_salary, date_range, ab_days);
                txt_noPay.Text = no_pay.ToString();
            }
        }
    }
}
