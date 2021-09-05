
namespace Inventory_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ResetBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PasswordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.ResetBt);
            this.panel1.Controls.Add(this.LoginBt);
            this.panel1.Controls.Add(this.PasswordTb);
            this.panel1.Controls.Add(this.UnameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(513, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 368);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(121, 321);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ResetBt
            // 
            this.ResetBt.ActiveBorderThickness = 1;
            this.ResetBt.ActiveCornerRadius = 20;
            this.ResetBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ResetBt.ActiveForecolor = System.Drawing.Color.White;
            this.ResetBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ResetBt.BackColor = System.Drawing.Color.Teal;
            this.ResetBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetBt.BackgroundImage")));
            this.ResetBt.ButtonText = "Reset";
            this.ResetBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetBt.IdleBorderThickness = 1;
            this.ResetBt.IdleCornerRadius = 20;
            this.ResetBt.IdleFillColor = System.Drawing.Color.White;
            this.ResetBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ResetBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ResetBt.Location = new System.Drawing.Point(30, 313);
            this.ResetBt.Margin = new System.Windows.Forms.Padding(5);
            this.ResetBt.Name = "ResetBt";
            this.ResetBt.Size = new System.Drawing.Size(70, 32);
            this.ResetBt.TabIndex = 4;
            this.ResetBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBt.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTb.ForeColor = System.Drawing.Color.White;
            this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.HintText = "";
            this.PasswordTb.isPassword = true;
            this.PasswordTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTb.LineIdleColor = System.Drawing.Color.White;
            this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTb.LineThickness = 3;
            this.PasswordTb.Location = new System.Drawing.Point(15, 162);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(233, 44);
            this.PasswordTb.TabIndex = 2;
            this.PasswordTb.Text = "Password";
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UnameTb
            // 
            this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UnameTb.ForeColor = System.Drawing.Color.White;
            this.UnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UnameTb.HintText = "";
            this.UnameTb.isPassword = false;
            this.UnameTb.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.UnameTb.LineIdleColor = System.Drawing.Color.White;
            this.UnameTb.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.UnameTb.LineThickness = 3;
            this.UnameTb.Location = new System.Drawing.Point(15, 87);
            this.UnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(233, 44);
            this.UnameTb.TabIndex = 1;
            this.UnameTb.Text = "Username";
            this.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBt
            // 
            this.LoginBt.ActiveBorderThickness = 1;
            this.LoginBt.ActiveCornerRadius = 20;
            this.LoginBt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LoginBt.ActiveForecolor = System.Drawing.Color.White;
            this.LoginBt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.LoginBt.BackColor = System.Drawing.Color.Teal;
            this.LoginBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBt.BackgroundImage")));
            this.LoginBt.ButtonText = "Login";
            this.LoginBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginBt.IdleBorderThickness = 1;
            this.LoginBt.IdleCornerRadius = 20;
            this.LoginBt.IdleFillColor = System.Drawing.Color.White;
            this.LoginBt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.LoginBt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LoginBt.Location = new System.Drawing.Point(44, 238);
            this.LoginBt.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBt.Name = "LoginBt";
            this.LoginBt.Size = new System.Drawing.Size(181, 41);
            this.LoginBt.TabIndex = 3;
            this.LoginBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBt.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UnameTb;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBt;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBt;
    }
}

