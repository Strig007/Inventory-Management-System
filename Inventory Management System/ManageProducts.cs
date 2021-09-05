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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        void showInfo()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void fillcategory()
        {
            string myQuery = "select * from CategoryTable";
            SqlCommand cmd = new SqlCommand(myQuery, Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void filterByCategory()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from ProductTable where ProCategory='"+SearchCombo.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            showInfo();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTable values('" + ProIdTb.Text + "', '" + ProNameTb.Text + "', '"+ProQuanTb.Text+"', '"+ProPriceTb.Text+"', '"+CatCombo.SelectedValue.ToString()+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully!");
                Con.Close();
                showInfo();
            }
            catch
            {

            }
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (ProIdTb.Text == "")
            {
                MessageBox.Show("Please Enter Product ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from ProductTable where ProID='" + ProIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully!");
                Con.Close();
                showInfo();
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            ProNameTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            ProQuanTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            ProPriceTb.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ModifyBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTable set ProName='" + ProNameTb.Text + "',ProQuantity='"+ProQuanTb.Text+"',ProPrice='"+ProPriceTb.Text+"',ProCategory='"+CatCombo.SelectedValue.ToString()+"' where ProID='" + ProIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Modified Successfully!");
                Con.Close();
                showInfo();
            }
            catch
            {

            }
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void RefreshBt_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
