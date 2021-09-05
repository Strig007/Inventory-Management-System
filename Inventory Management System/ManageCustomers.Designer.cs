
namespace Inventory_Management_System
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CustIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ModifyBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customers";
            // 
            // CustPhoneTb
            // 
            this.CustPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustPhoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustPhoneTb.ForeColor = System.Drawing.Color.White;
            this.CustPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustPhoneTb.HintText = "";
            this.CustPhoneTb.isPassword = false;
            this.CustPhoneTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CustPhoneTb.LineIdleColor = System.Drawing.Color.White;
            this.CustPhoneTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CustPhoneTb.LineThickness = 3;
            this.CustPhoneTb.Location = new System.Drawing.Point(13, 253);
            this.CustPhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.CustPhoneTb.Name = "CustPhoneTb";
            this.CustPhoneTb.Size = new System.Drawing.Size(211, 44);
            this.CustPhoneTb.TabIndex = 9;
            this.CustPhoneTb.Text = "Customer Phone";
            this.CustPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustNameTb
            // 
            this.CustNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustNameTb.ForeColor = System.Drawing.Color.White;
            this.CustNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustNameTb.HintText = "";
            this.CustNameTb.isPassword = false;
            this.CustNameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CustNameTb.LineIdleColor = System.Drawing.Color.White;
            this.CustNameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CustNameTb.LineThickness = 3;
            this.CustNameTb.Location = new System.Drawing.Point(13, 201);
            this.CustNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(211, 44);
            this.CustNameTb.TabIndex = 7;
            this.CustNameTb.Text = "Customer Name";
            this.CustNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CustIdTb
            // 
            this.CustIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CustIdTb.ForeColor = System.Drawing.Color.White;
            this.CustIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustIdTb.HintText = "";
            this.CustIdTb.isPassword = false;
            this.CustIdTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CustIdTb.LineIdleColor = System.Drawing.Color.White;
            this.CustIdTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CustIdTb.LineThickness = 3;
            this.CustIdTb.Location = new System.Drawing.Point(13, 149);
            this.CustIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.CustIdTb.Name = "CustIdTb";
            this.CustIdTb.Size = new System.Drawing.Size(211, 44);
            this.CustIdTb.TabIndex = 6;
            this.CustIdTb.Text = "Customer ID";
            this.CustIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 15;
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
            this.CustomersGV.Location = new System.Drawing.Point(308, 163);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.RowHeadersVisible = false;
            this.CustomersGV.RowTemplate.Height = 30;
            this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGV.Size = new System.Drawing.Size(505, 295);
            this.CustomersGV.TabIndex = 14;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 10);
            this.panel2.TabIndex = 16;
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
            this.HomeBt.Location = new System.Drawing.Point(90, 391);
            this.HomeBt.Margin = new System.Windows.Forms.Padding(5);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(73, 41);
            this.HomeBt.TabIndex = 20;
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
            this.DeleteBt.Location = new System.Drawing.Point(173, 340);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(73, 41);
            this.DeleteBt.TabIndex = 19;
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
            this.ModifyBt.Location = new System.Drawing.Point(90, 340);
            this.ModifyBt.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyBt.Name = "ModifyBt";
            this.ModifyBt.Size = new System.Drawing.Size(73, 41);
            this.ModifyBt.TabIndex = 18;
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
            this.AddBt.Location = new System.Drawing.Point(7, 340);
            this.AddBt.Margin = new System.Windows.Forms.Padding(5);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(73, 41);
            this.AddBt.TabIndex = 17;
            this.AddBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.OrderLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(338, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 76);
            this.panel3.TabIndex = 21;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.BackColor = System.Drawing.Color.White;
            this.OrderLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(44, 34);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(76, 24);
            this.OrderLabel.TabIndex = 2;
            this.OrderLabel.Text = "Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Orders Count";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.AmountLabel);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(610, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 76);
            this.panel4.TabIndex = 22;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.White;
            this.AmountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AmountLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(40, 34);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(93, 24);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Orders Amount";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.ModifyBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.CustPhoneTb);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.CustIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustPhoneTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustIdTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBt;
        private Bunifu.Framework.UI.BunifuThinButton2 ModifyBt;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label7;
    }
}