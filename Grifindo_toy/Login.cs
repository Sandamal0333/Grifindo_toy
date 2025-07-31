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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        DBConnect dbc = new DBConnect();

        string username, password;
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.conn();
                SqlDataReader read = dbc.reader("Select * from Login where username='" + txt_uname.Text + "' and password='" + txt_password.Text + "'  ");
                while (read.Read())
                {
                    username = read[0].ToString();
                    password = read[1].ToString();
                }
                if (username == txt_uname.Text && password == txt_password.Text)
                {
                    frm_dashboard dash = new frm_dashboard();
                    this.Hide();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Grifindo Toy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                dbc.closeCon();
            }
            
        }
    }
}
