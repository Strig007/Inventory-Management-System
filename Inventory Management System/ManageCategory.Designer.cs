
namespace Inventory_Management_System
{
    partial class ManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CatNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HomeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ModifyBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriesGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Categories";
            // 
            // CatNameTb
            // 
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CatNameTb.ForeColor = System.Drawing.Color.White;
            this.CatNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatNameTb.HintText = "";
            this.CatNameTb.isPassword = false;
            this.CatNameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CatNameTb.LineIdleColor = System.Drawing.Color.White;
            this.CatNameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CatNameTb.LineThickness = 3;
            this.CatNameTb.Location = new System.Drawing.Point(13, 200);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(211, 44);
            this.CatNameTb.TabIndex = 11;
            this.CatNameTb.Text = "Category Name";
            this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CatIdTb.ForeColor = System.Drawing.Color.White;
            this.CatIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatIdTb.HintText = "";
            this.CatIdTb.isPassword = false;
            this.CatIdTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.CatIdTb.LineIdleColor = System.Drawing.Color.White;
            this.CatIdTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CatIdTb.LineThickness = 3;
            this.CatIdTb.Location = new System.Drawing.Point(13, 148);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(211, 44);
            this.CatIdTb.TabIndex = 10;
            this.CatIdTb.Text = "Category ID";
            this.CatIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.HomeBt.Location = new System.Drawing.Point(96, 372);
            this.HomeBt.Margin = new System.Windows.Forms.Padding(5);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(73, 41);
            this.HomeBt.TabIndex = 24;
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
            this.DeleteBt.Location = new System.Drawing.Point(179, 321);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(73, 41);
            this.DeleteBt.TabIndex = 23;
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
            this.ModifyBt.Location = new System.Drawing.Point(96, 321);
            this.ModifyBt.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyBt.Name = "ModifyBt";
            this.ModifyBt.Size = new System.Drawing.Size(73, 41);
            this.ModifyBt.TabIndex = 22;
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
            this.AddBt.Location = new System.Drawing.Point(13, 321);
            this.AddBt.Margin = new System.Windows.Forms.Padding(5);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(73, 41);
            this.AddBt.TabIndex = 21;
            this.AddBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Categories List";
            // 
            // CategoriesGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CategoriesGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoriesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesGV.BackgroundColor = System.Drawing.Color.White;
            this.CategoriesGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategoriesGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoriesGV.EnableHeadersVisualStyles = false;
            this.CategoriesGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesGV.Location = new System.Drawing.Point(308, 157);
            this.CategoriesGV.Name = "CategoriesGV";
            this.CategoriesGV.RowHeadersVisible = false;
            this.CategoriesGV.RowTemplate.Height = 30;
            this.CategoriesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGV.Size = new System.Drawing.Size(505, 381);
            this.CategoriesGV.TabIndex = 25;
            this.CategoriesGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CategoriesGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategoriesGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategoriesGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategoriesGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategoriesGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.CategoriesGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategoriesGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategoriesGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategoriesGV.ThemeStyle.HeaderStyle.Height = 25;
            this.CategoriesGV.ThemeStyle.ReadOnly = false;
            this.CategoriesGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategoriesGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoriesGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.CategoriesGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesGV.ThemeStyle.RowsStyle.Height = 30;
            this.CategoriesGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategoriesGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategoriesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesGV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 10);
            this.panel2.TabIndex = 27;
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoriesGV);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.ModifyBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategory";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatIdTb;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBt;
        private Bunifu.Framework.UI.BunifuThinButton2 ModifyBt;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView CategoriesGV;
        private System.Windows.Forms.Panel panel2;
    }
}