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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        void showInfo()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from CustomerTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTable values('" + CustIdTb.Text + "','" + CustNameTb.Text + "','" + CustPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully!");
                Con.Close();
                showInfo();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (CustIdTb.Text == "")
            {
                MessageBox.Show("Please Enter Customers's ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from CustomerTable where CustID='" + CustIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully!");
                Con.Close();
                showInfo();
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustNameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustPhoneTb.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
           
            Con.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from CalculationTable where CustId = " + CustIdTb.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmount) from CalculationTable where CustId = " + CustIdTb.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();
            
            Con.Close();
        }

        private void ModifyBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTable set CustName='"+CustNameTb.Text+"',CustPhone='"+CustPhoneTb.Text+"' where CustID='"+CustIdTb.Text+"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Modified Successfully!");
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
