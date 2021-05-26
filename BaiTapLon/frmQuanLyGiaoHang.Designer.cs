
namespace BaiTapLon
{
    partial class frmQuanLyGiaoHang
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
            this.btnDSDH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.userDanhSachGiaoHangControl1 = new BaiTapLon.UserDanhSachGiaoHangControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDSDH
            // 
            this.btnDSDH.BackColor = System.Drawing.Color.White;
            this.btnDSDH.FlatAppearance.BorderSize = 0;
            this.btnDSDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDSDH.ForeColor = System.Drawing.Color.Black;
            this.btnDSDH.Location = new System.Drawing.Point(0, 402);
            this.btnDSDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnDSDH.Name = "btnDSDH";
            this.btnDSDH.Size = new System.Drawing.Size(300, 70);
            this.btnDSDH.TabIndex = 4;
            this.btnDSDH.Text = "Đơn hàng";
            this.btnDSDH.UseVisualStyleBackColor = false;
            this.btnDSDH.UseWaitCursor = true;
            this.btnDSDH.Click += new System.EventHandler(this.btnDSDH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ptLogo);
            this.panel1.Controls.Add(this.btnDSDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1080);
            this.panel1.TabIndex = 6;
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Black;
            this.ptLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptLogo.Image = global::BaiTapLon.Properties.Resources.Logo;
            this.ptLogo.Location = new System.Drawing.Point(0, 0);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(300, 240);
            this.ptLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptLogo.TabIndex = 6;
            this.ptLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1620, 50);
            this.panel2.TabIndex = 8;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1520, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1570, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userDanhSachGiaoHangControl1
            // 
            this.userDanhSachGiaoHangControl1.BackColor = System.Drawing.Color.White;
            this.userDanhSachGiaoHangControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDanhSachGiaoHangControl1.Location = new System.Drawing.Point(300, 50);
            this.userDanhSachGiaoHangControl1.Margin = new System.Windows.Forms.Padding(2);
            this.userDanhSachGiaoHangControl1.Name = "userDanhSachGiaoHangControl1";
            this.userDanhSachGiaoHangControl1.Size = new System.Drawing.Size(1620, 1030);
            this.userDanhSachGiaoHangControl1.TabIndex = 9;
            // 
            // frmQuanLyGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userDanhSachGiaoHangControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyGiaoHang";
            this.Text = "Giao Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDSDH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private UserDanhSachGiaoHangControl userDanhSachGiaoHangControl1;
    }
}