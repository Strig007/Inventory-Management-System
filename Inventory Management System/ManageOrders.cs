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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        // Declaring variables for Order lists
        int no = 0, quantity, price;
        long totalPrice;
        string productName;

        void deleteOrderTable()
        {
            Con.Open();
            string myQuery = "delete from OrderTable";
            SqlCommand cmd = new SqlCommand(myQuery, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        void showInfoCustomers()
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

        void showInfoProducts()
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

        void showInfoOrders()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from OrderTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGv.DataSource = ds.Tables[0];
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
                string myQuery = "select * from ProductTable where ProCategory='" + SearchCombo.SelectedValue.ToString() + "'";
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
            deleteOrderTable();
            Application.Exit();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            showInfoCustomers();
            showInfoProducts();
            fillcategory();
        }

        bool flag = false;
        int stock;

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productName = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            price = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = true;
        }

        private void CustomerNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        void updateProductTable()
        { 
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQuantity = stock - Convert.ToInt32(QuantityTb.Text);
            if (newQuantity < 0)
            {
                MessageBox.Show("Operation Failed!");
            }
            else
            {
                Con.Open();
                string query = "update ProductTable set ProQuantity = " + newQuantity + "where ProID = " + id + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                showInfoProducts();
            }
        }

        long sum = 0;

        private void AddingOrderBt_Click(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "")
            {
                MessageBox.Show("Enter Quantity of Product!");
            }
            else if (flag == false)
            {
                MessageBox.Show("Please The Select Product!");
            }
            else if (Convert.ToInt32(QuantityTb.Text) > stock)
            {
                MessageBox.Show("Not enough stock available!");
            }
            else
            {
                no = no + 1;
                quantity = Convert.ToInt32(QuantityTb.Text);
                totalPrice = quantity * price;

                //Inserting values for Final Order Table by this order:
                //no, productName, quantity, price, totalPrice
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderTable values('" + no + "', '" + productName + "', '" + quantity + "', '" + price + "', '" + totalPrice + "')", Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                showInfoOrders();
                flag = false;
            }
            sum += totalPrice;
            TotalAmount.Text = sum.ToString();
            updateProductTable();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text == "" || CustomerIdTb.Text == "" || CustomerNameTb.Text == "" || TotalAmount.Text == "")
            {
                MessageBox.Show("Fill the data correctly!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CalculationTable values('" + OrderIdTb.Text + "', '" + CustomerIdTb.Text + "', '" + CustomerNameTb.Text + "', '" + TotalAmount.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully!");
                    Con.Close();
                    //showInfo();
                }
                catch
                {

                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            deleteOrderTable();
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }
    }
}
