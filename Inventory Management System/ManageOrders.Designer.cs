
namespace Inventory_Management_System
{
    partial class ManageOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.OrderIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustomerNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuantityTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AddingOrderBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OrdersGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.HomeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 100);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(812, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Customers List";
            // 
            // CustomersGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersGV.EnableHeadersVisualStyles = false;
            this.CustomersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGV.Location = new System.Drawing.Point(12, 137);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.RowHeadersVisible = false;
            this.CustomersGV.RowTemplate.Height = 30;
            this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGV.Size = new System.Drawing.Size(352, 172);
            this.CustomersGV.TabIndex = 30;
            this.CustomersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.CustomersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomersGV.ThemeStyle.HeaderStyle.Height = 25;
            this.CustomersGV.ThemeStyle.ReadOnly = false;
            this.CustomersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.CustomersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersGV.ThemeStyle.RowsStyle.Height = 30;
            this.CustomersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // OrderIdTb
            // 
            this.OrderIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OrderIdTb.ForeColor = System.Drawing.Color.White;
            this.OrderIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.OrderIdTb.HintText = "";
            this.OrderIdTb.isPassword = false;
            this.OrderIdTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.OrderIdTb.LineIdleColor = System.Drawing.Color.White;
            this.OrderIdTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.OrderIdTb.LineThickness = 3;
            this.OrderIdTb.Location = new System.Drawing.Point(93, 341);
            this.OrderIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.OrderIdTb.Name = "OrderIdTb";
            this.OrderIdTb.Size = new System.Drawing.Size(98, 44);
            this.OrderIdTb.TabIndex = 31;
            this.OrderIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerIdTb
            // 
            this.CustomerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerIdTb.ForeColor = System.Drawing.Color.White;
            this.CustomerIdTb.HintForeColor = System.Drawing.Color.Black;
            this.CustomerIdTb.HintText = "";
            this.CustomerIdTb.isPassword = false;
            this.CustomerIdTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CustomerIdTb.LineIdleColor = System.Drawing.Color.White;
            this.CustomerIdTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CustomerIdTb.LineThickness = 3;
            this.CustomerIdTb.Location = new System.Drawing.Point(12, 393);
            this.CustomerIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIdTb.Name = "CustomerIdTb";
            this.CustomerIdTb.Size = new System.Drawing.Size(165, 33);
            this.CustomerIdTb.TabIndex = 32;
            this.CustomerIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustomerNameTb
            // 
            this.CustomerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustomerNameTb.ForeColor = System.Drawing.Color.White;
            this.CustomerNameTb.HintForeColor = System.Drawing.Color.Black;
            this.CustomerNameTb.HintText = "";
            this.CustomerNameTb.isPassword = false;
            this.CustomerNameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CustomerNameTb.LineIdleColor = System.Drawing.Color.White;
            this.CustomerNameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CustomerNameTb.LineThickness = 3;
            this.CustomerNameTb.Location = new System.Drawing.Point(12, 434);
            this.CustomerNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameTb.Name = "CustomerNameTb";
            this.CustomerNameTb.Size = new System.Drawing.Size(165, 32);
            this.CustomerNameTb.TabIndex = 34;
            this.CustomerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerNameTb.OnValueChanged += new System.EventHandler(this.CustomerNameTb_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 359);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "Order ID:";
            // 
            // SearchCombo
            // 
            this.SearchCombo.BackColor = System.Drawing.SystemColors.Window;
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(523, 106);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(155, 25);
            this.SearchCombo.TabIndex = 37;
            this.SearchCombo.Text = "Select Category";
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductsGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductsGV.EnableHeadersVisualStyles = false;
            this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.Location = new System.Drawing.Point(394, 137);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowTemplate.Height = 30;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(443, 172);
            this.ProductsGV.TabIndex = 36;
            this.ProductsGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProductsGV.ThemeStyle.ReadOnly = false;
            this.ProductsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.ProductsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.ThemeStyle.RowsStyle.Height = 30;
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 10);
            this.panel2.TabIndex = 38;
            // 
            // QuantityTb
            // 
            this.QuantityTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTb.ForeColor = System.Drawing.Color.White;
            this.QuantityTb.HintForeColor = System.Drawing.Color.Empty;
            this.QuantityTb.HintText = "";
            this.QuantityTb.isPassword = false;
            this.QuantityTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.QuantityTb.LineIdleColor = System.Drawing.Color.White;
            this.QuantityTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.QuantityTb.LineThickness = 4;
            this.QuantityTb.Location = new System.Drawing.Point(513, 326);
            this.QuantityTb.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTb.Name = "QuantityTb";
            this.QuantityTb.Size = new System.Drawing.Size(98, 36);
            this.QuantityTb.TabIndex = 40;
            this.QuantityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(429, 341);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 19);
            this.bunifuCustomLabel3.TabIndex = 41;
            this.bunifuCustomLabel3.Text = "Quantity:";
            // 
            // AddingOrderBt
            // 
            this.AddingOrderBt.ActiveBorderThickness = 1;
            this.AddingOrderBt.ActiveCornerRadius = 20;
            this.AddingOrderBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddingOrderBt.ActiveForecolor = System.Drawing.Color.White;
            this.AddingOrderBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddingOrderBt.BackColor = System.Drawing.Color.Teal;
            this.AddingOrderBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddingOrderBt.BackgroundImage")));
            this.AddingOrderBt.ButtonText = "Add To Order";
            this.AddingOrderBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddingOrderBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingOrderBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddingOrderBt.IdleBorderThickness = 1;
            this.AddingOrderBt.IdleCornerRadius = 20;
            this.AddingOrderBt.IdleFillColor = System.Drawing.Color.White;
            this.AddingOrderBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddingOrderBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddingOrderBt.Location = new System.Drawing.Point(633, 326);
            this.AddingOrderBt.Margin = new System.Windows.Forms.Padding(5);
            this.AddingOrderBt.Name = "AddingOrderBt";
            this.AddingOrderBt.Size = new System.Drawing.Size(119, 43);
            this.AddingOrderBt.TabIndex = 42;
            this.AddingOrderBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddingOrderBt.Click += new System.EventHandler(this.AddingOrderBt_Click);
            // 
            // OrdersGv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OrdersGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrdersGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGv.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrdersGv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersGv.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrdersGv.EnableHeadersVisualStyles = false;
            this.OrdersGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.Location = new System.Drawing.Point(246, 377);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.RowHeadersVisible = false;
            this.OrdersGv.RowTemplate.Height = 30;
            this.OrdersGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGv.Size = new System.Drawing.Size(591, 172);
            this.OrdersGv.TabIndex = 43;
            this.OrdersGv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrdersGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrdersGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.OrdersGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrdersGv.ThemeStyle.HeaderStyle.Height = 25;
            this.OrdersGv.ThemeStyle.ReadOnly = false;
            this.OrdersGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.OrdersGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrdersGv.ThemeStyle.RowsStyle.Height = 30;
            this.OrdersGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Total Amount";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.White;
            this.TotalAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(566, 562);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(0, 23);
            this.TotalAmount.TabIndex = 45;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Insert Order";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(12, 506);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(119, 43);
            this.bunifuThinButton21.TabIndex = 46;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "View Orders";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(130, 506);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(108, 43);
            this.bunifuThinButton22.TabIndex = 47;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // HomeBt
            // 
            this.HomeBt.ActiveBorderThickness = 1;
            this.HomeBt.ActiveCornerRadius = 20;
            this.HomeBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.HomeBt.ActiveForecolor = System.Drawing.Color.White;
            this.HomeBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.HomeBt.BackColor = System.Drawing.Color.Teal;
            this.HomeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBt.BackgroundImage")));
            this.HomeBt.ButtonText = "Home";
            this.HomeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.HomeBt.IdleBorderThickness = 1;
            this.HomeBt.IdleCornerRadius = 20;
            this.HomeBt.IdleFillColor = System.Drawing.Color.White;
            this.HomeBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.HomeBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.HomeBt.Location = new System.Drawing.Point(93, 555);
            this.HomeBt.Margin = new System.Windows.Forms.Padding(5);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(73, 41);
            this.HomeBt.TabIndex = 48;
            this.HomeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(849, 614);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrdersGv);
            this.Controls.Add(this.AddingOrderBt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.QuantityTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CustomerNameTb);
            this.Controls.Add(this.CustomerIdTb);
            this.Controls.Add(this.OrderIdTb);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OrderIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustomerNameTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox SearchCombo;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QuantityTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 AddingOrderBt;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersGv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalAmount;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBt;
    }
}