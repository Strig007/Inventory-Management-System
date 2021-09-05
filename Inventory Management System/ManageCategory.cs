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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        void showInfo()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from CategoryTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("insert into CategoryTable values('"+CatIdTb.Text+"', '"+CatNameTb.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully!");
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

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (CatIdTb.Text == "")
            {
                MessageBox.Show("Please Enter Category ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from CategoryTable where CatID='" + CatIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully!");
                Con.Close();
                showInfo();
            }
        }

        private void ModifyBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTable set CatName='" + CatNameTb.Text + "' where CatID='"+CatIdTb.Text+"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Modified Successfully!");
                Con.Close();
                showInfo();
            }
            catch
            {

            }
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
