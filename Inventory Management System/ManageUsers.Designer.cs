
using System;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AddBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.HomeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ModifyBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(327, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // unameTb
            // 
            this.unameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.unameTb.ForeColor = System.Drawing.Color.White;
            this.unameTb.HintForeColor = System.Drawing.Color.Empty;
            this.unameTb.HintText = "";
            this.unameTb.isPassword = false;
            this.unameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.unameTb.LineIdleColor = System.Drawing.Color.White;
            this.unameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.unameTb.LineThickness = 3;
            this.unameTb.Location = new System.Drawing.Point(13, 148);
            this.unameTb.Margin = new System.Windows.Forms.Padding(4);
            this.unameTb.Name = "unameTb";
            this.unameTb.Size = new System.Drawing.Size(211, 44);
            this.unameTb.TabIndex = 2;
            this.unameTb.Text = "Username";
            this.unameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.unameTb.OnValueChanged += new System.EventHandler(this.unameTb_OnValueChanged);
            // 
            // FnameTb
            // 
            this.FnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FnameTb.ForeColor = System.Drawing.Color.White;
            this.FnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.FnameTb.HintText = "";
            this.FnameTb.isPassword = false;
            this.FnameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.FnameTb.LineIdleColor = System.Drawing.Color.White;
            this.FnameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.FnameTb.LineThickness = 3;
            this.FnameTb.Location = new System.Drawing.Point(13, 200);
            this.FnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.FnameTb.Name = "FnameTb";
            this.FnameTb.Size = new System.Drawing.Size(211, 44);
            this.FnameTb.TabIndex = 3;
            this.FnameTb.Text = "Full Name";
            this.FnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FnameTb.OnValueChanged += new System.EventHandler(this.FnameTb_OnValueChanged);
            // 
            // passwordTb
            // 
            this.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTb.ForeColor = System.Drawing.Color.White;
            this.passwordTb.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTb.HintText = "";
            this.passwordTb.isPassword = false;
            this.passwordTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.passwordTb.LineIdleColor = System.Drawing.Color.White;
            this.passwordTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.passwordTb.LineThickness = 3;
            this.passwordTb.Location = new System.Drawing.Point(13, 252);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(211, 44);
            this.passwordTb.TabIndex = 4;
            this.passwordTb.Text = "Password";
            this.passwordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PhoneTb.ForeColor = System.Drawing.Color.White;
            this.PhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.HintText = "";
            this.PhoneTb.isPassword = false;
            this.PhoneTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.PhoneTb.LineIdleColor = System.Drawing.Color.White;
            this.PhoneTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.PhoneTb.LineThickness = 3;
            this.PhoneTb.Location = new System.Drawing.Point(13, 304);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(211, 44);
            this.PhoneTb.TabIndex = 5;
            this.PhoneTb.Text = "Telephone";
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.AddBt.Location = new System.Drawing.Point(14, 394);
            this.AddBt.Margin = new System.Windows.Forms.Padding(5);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(73, 41);
            this.AddBt.TabIndex = 6;
            this.AddBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click_1);
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
            this.DeleteBt.Location = new System.Drawing.Point(180, 394);
            this.DeleteBt.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(73, 41);
            this.DeleteBt.TabIndex = 8;
            this.DeleteBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
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
            this.HomeBt.Location = new System.Drawing.Point(97, 445);
            this.HomeBt.Margin = new System.Windows.Forms.Padding(5);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(73, 41);
            this.HomeBt.TabIndex = 9;
            this.HomeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 10);
            this.panel2.TabIndex = 11;
            // 
            // UsersGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGV.BackgroundColor = System.Drawing.Color.White;
            this.UsersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGV.EnableHeadersVisualStyles = false;
            this.UsersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.Location = new System.Drawing.Point(308, 164);
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowTemplate.Height = 30;
            this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGV.Size = new System.Drawing.Size(505, 386);
            this.UsersGV.TabIndex = 12;
            this.UsersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.UsersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersGV.ThemeStyle.HeaderStyle.Height = 25;
            this.UsersGV.ThemeStyle.ReadOnly = false;
            this.UsersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.UsersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGV.ThemeStyle.RowsStyle.Height = 30;
            this.UsersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Users List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.ModifyBt.Location = new System.Drawing.Point(97, 394);
            this.ModifyBt.Margin = new System.Windows.Forms.Padding(5);
            this.ModifyBt.Name = "ModifyBt";
            this.ModifyBt.Size = new System.Drawing.Size(73, 41);
            this.ModifyBt.TabIndex = 14;
            this.ModifyBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModifyBt.Click += new System.EventHandler(this.ModifyBt_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.ModifyBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.FnameTb);
            this.Controls.Add(this.unameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ModifyBt_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox unameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FnameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTb;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBt;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBt;
        private Bunifu.Framework.UI.BunifuThinButton2 HomeBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private EventHandler AddBt_Click;
        private Guna.UI2.WinForms.Guna2DataGridView UsersGV;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 ModifyBt;
    }
}