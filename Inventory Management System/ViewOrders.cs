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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-RHSOBA2\SQLEXPRESS;Initial Catalog=Inventorydb;Integrated Security=True");

        void showOrders()
        {
            try
            {
                Con.Open();
                string myQuery = "select * from CalculationTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            showOrders();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order ID:"+OrderGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Customer ID:" + OrderGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Customer Name:" + OrderGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Total Amount:" + OrderGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
        }
    }
}
