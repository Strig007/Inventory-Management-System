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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void showInfo()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void AddBt_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + unameTb.Text + "','" + FnameTb.Text + "','" + passwordTb.Text + "','" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully!");
                Con.Close();
                showInfo();
            }
            catch
            {
                
            }
        }

        private void unameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Please Enter User's Phone Number");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from UserTable where UPhone='" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully!");
                Con.Close();
                showInfo();
            }
        }

        private void FnameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void UsersGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            passwordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModifyBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set UName='"+unameTb.Text+"',UFullName='"+FnameTb.Text+"',UPassword='"+passwordTb.Text+"' where UPhone='"+PhoneTb.Text+"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Modified Successfully!");
                Con.Close();
                showInfo();
            }
            catch
            {

            }
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
