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

namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTb.isPassword = false;
            }
            else
            {
                PasswordTb.isPassword = true;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTable where UName = '" + UnameTb.Text + "' and UPassword = '" + PasswordTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }    
            Con.Close();
        }
    }
}
