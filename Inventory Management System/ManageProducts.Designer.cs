
namespace Inventory_Management_System
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProQuanTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.HomeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ModifyBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.SearchBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RefreshBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(825, 100);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(788, 9);
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
            this.label2.Location = new System.Drawing.Point(162, 9);
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
            this.label1.Location = new System.Drawing.Point(294, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // ProNameTb
            // 
            this.ProNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProNameTb.ForeColor = System.Drawing.Color.White;
            this.ProNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProNameTb.HintText = "";
            this.ProNameTb.isPassword = false;
            this.ProNameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProNameTb.LineIdleColor = System.Drawing.Color.White;
            this.ProNameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProNameTb.LineThickness = 3;
            this.ProNameTb.Location = new System.Drawing.Point(13, 180);
            this.ProNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProNameTb.Name = "ProNameTb";
            this.ProNameTb.Size = new System.Drawing.Size(211, 44);
            this.ProNameTb.TabIndex = 13;
            this.ProNameTb.Text = "Product Name";
            this.ProNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProIdTb
            // 
            this.ProIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProIdTb.ForeColor = System.Drawing.Color.White;
            this.ProIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProIdTb.HintText = "";
            this.ProIdTb.isPassword = false;
            this.ProIdTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProIdTb.LineIdleColor = System.Drawing.Color.White;
            this.ProIdTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProIdTb.LineThickness = 3;
            this.ProIdTb.Location = new System.Drawing.Point(13, 128);
            this.ProIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProIdTb.Name = "ProIdTb";
            this.ProIdTb.Size = new System.Drawing.Size(211, 44);
            this.ProIdTb.TabIndex = 12;
            this.ProIdTb.Text = "Product ID";
            this.ProIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProQuanTb
            // 
            this.ProQuanTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProQuanTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProQuanTb.ForeColor = System.Drawing.Color.White;
            this.ProQuanTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProQuanTb.HintText = "";
            this.ProQuanTb.isPassword = false;
            this.ProQuanTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProQuanTb.LineIdleColor = System.Drawing.Color.White;
            this.ProQuanTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProQuanTb.LineThickness = 3;
            this.ProQuanTb.Location = new System.Drawing.Point(13, 232);
            this.ProQuanTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProQuanTb.Name = "ProQuanTb";
            this.ProQuanTb.Size = new System.Drawing.Size(211, 44);
            this.ProQuanTb.TabIndex = 14;
            this.ProQuanTb.Text = "Product Quantity";
            this.ProQuanTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProPriceTb
            // 
            this.ProPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProPriceTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProPriceTb.ForeColor = System.Drawing.Color.White;
            this.ProPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProPriceTb.HintText = "";
            this.ProPriceTb.isPassword = false;
            this.ProPriceTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.ProPriceTb.LineIdleColor = System.Drawing.Color.White;
            this.ProPriceTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProPriceTb.LineThickness = 3;
            this.ProPriceTb.Location = new System.Drawing.Point(13, 284);
            this.ProPriceTb.Margin = new System.Windows.Forms.Padding(4);
            this.ProPriceTb.Name = "ProPriceTb";
            this.ProPriceTb.Size = new System.Drawing.Size(211, 44);
            this.ProPriceTb.TabIndex = 15;
            this.ProPriceTb.Text = "Product Price";
            this.ProPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCombo
            // 
            this.CatCombo.BackColor = System.Drawing.SystemColors.Window;
            this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(13, 354);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(155, 25);
            this.CatCombo.TabIndex = 16;
            this.CatCombo.Text = "Product Category";
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
            this.HomeBt.Location = new System.Drawing.Point(95, 463);
            this.HomeBt.Margin = new System.Windows.Forms.Padding(5);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(73, 41);
            this.HomeBt.TabIndex = 28;
            this.HomeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.ActiveBorderThickness = 1;
            this.DeleteBt.ActiveCornerRadius = 20;
            this.DeleteBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DeleteBt.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBt.BackColor = System.Drawing.Color.Teal;
            this.DeleteBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBt.BackgroundImage")));
            this.DeleteBt.ButtonText = "Delete";
            this.DeleteBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBt.IdleBorderThickness = 1;
            this.DeleteBt.IdleCornerRadius = 20;
            this.DeleteBt.IdleFillColor = System.Drawing.Color.White;
            this.DeleteBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DeleteBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBt.Location = new System.Drawing.Point(178, 412);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(73, 41);
            this.DeleteBt.TabIndex = 27;
            this.DeleteBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // ModifyBt
            // 
            this.ModifyBt.ActiveBorderThickness = 1;
            this.ModifyBt.ActiveCornerRadius = 20;
            this.ModifyBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ModifyBt.ActiveForecolor = System.Drawing.Color.White;
            this.ModifyBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ModifyBt.BackColor = System.Drawing.Color.Teal;
            this.ModifyBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModifyBt.BackgroundImage")));
            this.ModifyBt.ButtonText = "Modify";
            this.ModifyBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifyBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.ModifyBt.IdleBorderThickness = 1;
            this.ModifyBt.IdleCornerRadius = 20;
            this.ModifyBt.IdleFillColor = System.Drawing.Color.White;
            this.ModifyBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ModifyBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ModifyBt.Location = new System.Drawing.Point(95, 412);
            this.ModifyBt.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyBt.Name = "ModifyBt";
            this.ModifyBt.Size = new System.Drawing.Size(73, 41);
            this.ModifyBt.TabIndex = 26;
            this.ModifyBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModifyBt.Click += new System.EventHandler(this.ModifyBt_Click);
            // 
            // AddBt
            // 
            this.AddBt.ActiveBorderThickness = 1;
            this.AddBt.ActiveCornerRadius = 20;
            this.AddBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddBt.ActiveForecolor = System.Drawing.Color.White;
            this.AddBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddBt.BackColor = System.Drawing.Color.Teal;
            this.AddBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBt.BackgroundImage")));
            this.AddBt.ButtonText = "Add";
            this.AddBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBt.IdleBorderThickness = 1;
            this.AddBt.IdleCornerRadius = 20;
            this.AddBt.IdleFillColor = System.Drawing.Color.White;
            this.AddBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddBt.Location = new System.Drawing.Point(12, 412);
            this.AddBt.Margin = new System.Windows.Forms.Padding(5);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(73, 41);
            this.AddBt.TabIndex = 25;
            this.AddBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Products List";
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsGV.EnableHeadersVisualStyles = false;
            this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.Location = new System.Drawing.Point(269, 180);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowTemplate.Height = 30;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(544, 381);
            this.ProductsGV.TabIndex = 29;
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
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 10);
            this.panel2.TabIndex = 31;
            // 
            // SearchCombo
            // 
            this.SearchCombo.BackColor = System.Drawing.SystemColors.Window;
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(382, 149);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(155, 25);
            this.SearchCombo.TabIndex = 32;
            this.SearchCombo.Text = "Select Category";
            // 
            // SearchBt
            // 
            this.SearchBt.ActiveBorderThickness = 1;
            this.SearchBt.ActiveCornerRadius = 20;
            this.SearchBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SearchBt.ActiveForecolor = System.Drawing.Color.White;
            this.SearchBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SearchBt.BackColor = System.Drawing.Color.Teal;
            this.SearchBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBt.BackgroundImage")));
            this.SearchBt.ButtonText = "Search";
            this.SearchBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchBt.IdleBorderThickness = 1;
            this.SearchBt.IdleCornerRadius = 20;
            this.SearchBt.IdleFillColor = System.Drawing.Color.White;
            this.SearchBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SearchBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SearchBt.Location = new System.Drawing.Point(545, 138);
            this.SearchBt.Margin = new System.Windows.Forms.Padding(5);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(92, 41);
            this.SearchBt.TabIndex = 33;
            this.SearchBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // RefreshBt
            // 
            this.RefreshBt.ActiveBorderThickness = 1;
            this.RefreshBt.ActiveCornerRadius = 20;
            this.RefreshBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.RefreshBt.ActiveForecolor = System.Drawing.Color.White;
            this.RefreshBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.RefreshBt.BackColor = System.Drawing.Color.Teal;
            this.RefreshBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBt.BackgroundImage")));
            this.RefreshBt.ButtonText = "Refresh";
            this.RefreshBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.RefreshBt.IdleBorderThickness = 1;
            this.RefreshBt.IdleCornerRadius = 20;
            this.RefreshBt.IdleFillColor = System.Drawing.Color.White;
            this.RefreshBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.RefreshBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.RefreshBt.Location = new System.Drawing.Point(647, 138);
            this.RefreshBt.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshBt.Name = "RefreshBt";
            this.RefreshBt.Size = new System.Drawing.Size(92, 41);
            this.RefreshBt.TabIndex = 34;
            this.RefreshBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshBt.Click += new System.EventHandler(this.RefreshBt_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.RefreshBt);
            this.Controls.Add(this.SearchBt);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.ModifyBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.ProPriceTb);
            this.Controls.Add(this.ProQuanTb);
            this.Controls.Add(this.ProNameTb);
            this.Controls.Add(this.ProIdTb);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProQuanTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProPriceTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBt;
        private Bunifu.Framework.UI.BunifuThinButton2 ModifyBt;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox SearchCombo;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchBt;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshBt;
    }
}