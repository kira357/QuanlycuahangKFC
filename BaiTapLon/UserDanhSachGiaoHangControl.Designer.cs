
namespace BaiTapLon
{
    partial class UserDanhSachGiaoHangControl
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

        #region Component Designer generated code

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
            this.dgvDSGH = new System.Windows.Forms.DataGridView();
            this.btnCTDH = new System.Windows.Forms.Button();
            this.btnThatBai = new System.Windows.Forms.Button();
            this.btnThanhCong = new System.Windows.Forms.Button();
            this.dgvLSGH = new System.Windows.Forms.DataGridView();
            this.btnCTDH_LSGH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSGH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSGH
            // 
            this.dgvDSGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSGH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSGH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSGH.Location = new System.Drawing.Point(40, 33);
            this.dgvDSGH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSGH.Name = "dgvDSGH";
            this.dgvDSGH.RowHeadersWidth = 51;
            this.dgvDSGH.RowTemplate.Height = 24;
            this.dgvDSGH.Size = new System.Drawing.Size(1541, 417);
            this.dgvDSGH.TabIndex = 0;
            this.dgvDSGH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGH_CellClick);
            // 
            // btnCTDH
            // 
            this.btnCTDH.BackColor = System.Drawing.Color.White;
            this.btnCTDH.BackgroundImage = global::BaiTapLon.Properties.Resources.icons8_show_property_48;
            this.btnCTDH.FlatAppearance.BorderSize = 0;
            this.btnCTDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTDH.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTDH.ForeColor = System.Drawing.Color.White;
            this.btnCTDH.Location = new System.Drawing.Point(1531, 464);
            this.btnCTDH.Margin = new System.Windows.Forms.Padding(2);
            this.btnCTDH.Name = "btnCTDH";
            this.btnCTDH.Size = new System.Drawing.Size(50, 50);
            this.btnCTDH.TabIndex = 10;
            this.btnCTDH.UseVisualStyleBackColor = false;
            this.btnCTDH.Click += new System.EventHandler(this.btnCTDH_DSGH_Click);
            // 
            // btnThatBai
            // 
            this.btnThatBai.BackColor = System.Drawing.Color.White;
            this.btnThatBai.BackgroundImage = global::BaiTapLon.Properties.Resources.icons8_cross_mark_48;
            this.btnThatBai.FlatAppearance.BorderSize = 0;
            this.btnThatBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThatBai.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThatBai.ForeColor = System.Drawing.Color.White;
            this.btnThatBai.Location = new System.Drawing.Point(123, 464);
            this.btnThatBai.Margin = new System.Windows.Forms.Padding(2);
            this.btnThatBai.Name = "btnThatBai";
            this.btnThatBai.Size = new System.Drawing.Size(50, 50);
            this.btnThatBai.TabIndex = 11;
            this.btnThatBai.UseVisualStyleBackColor = false;
            this.btnThatBai.Click += new System.EventHandler(this.btnThatBai_Click);
            // 
            // btnThanhCong
            // 
            this.btnThanhCong.BackColor = System.Drawing.Color.White;
            this.btnThanhCong.BackgroundImage = global::BaiTapLon.Properties.Resources.icons8_check_mark_48;
            this.btnThanhCong.FlatAppearance.BorderSize = 0;
            this.btnThanhCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhCong.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhCong.ForeColor = System.Drawing.Color.White;
            this.btnThanhCong.Location = new System.Drawing.Point(38, 464);
            this.btnThanhCong.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhCong.Name = "btnThanhCong";
            this.btnThanhCong.Size = new System.Drawing.Size(50, 50);
            this.btnThanhCong.TabIndex = 12;
            this.btnThanhCong.UseVisualStyleBackColor = false;
            this.btnThanhCong.Click += new System.EventHandler(this.btnThanhCong_Click);
            // 
            // dgvLSGH
            // 
            this.dgvLSGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSGH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLSGH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLSGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLSGH.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLSGH.Location = new System.Drawing.Point(38, 527);
            this.dgvLSGH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLSGH.Name = "dgvLSGH";
            this.dgvLSGH.RowHeadersWidth = 51;
            this.dgvLSGH.RowTemplate.Height = 24;
            this.dgvLSGH.Size = new System.Drawing.Size(1541, 417);
            this.dgvLSGH.TabIndex = 13;
            this.dgvLSGH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSGH_CellClick);
            // 
            // btnCTDH_LSGH
            // 
            this.btnCTDH_LSGH.BackColor = System.Drawing.Color.White;
            this.btnCTDH_LSGH.BackgroundImage = global::BaiTapLon.Properties.Resources.icons8_show_property_48;
            this.btnCTDH_LSGH.FlatAppearance.BorderSize = 0;
            this.btnCTDH_LSGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTDH_LSGH.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTDH_LSGH.ForeColor = System.Drawing.Color.White;
            this.btnCTDH_LSGH.Location = new System.Drawing.Point(1529, 958);
            this.btnCTDH_LSGH.Margin = new System.Windows.Forms.Padding(2);
            this.btnCTDH_LSGH.Name = "btnCTDH_LSGH";
            this.btnCTDH_LSGH.Size = new System.Drawing.Size(50, 50);
            this.btnCTDH_LSGH.TabIndex = 14;
            this.btnCTDH_LSGH.UseVisualStyleBackColor = false;
            this.btnCTDH_LSGH.Click += new System.EventHandler(this.btnCTDH_LSGH_Click);
            // 
            // UserDanhSachGiaoHangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvLSGH);
            this.Controls.Add(this.btnCTDH_LSGH);
            this.Controls.Add(this.btnThanhCong);
            this.Controls.Add(this.btnCTDH);
            this.Controls.Add(this.btnThatBai);
            this.Controls.Add(this.dgvDSGH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserDanhSachGiaoHangControl";
            this.Size = new System.Drawing.Size(1620, 1030);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSGH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSGH;
        private System.Windows.Forms.Button btnCTDH;
        private System.Windows.Forms.Button btnThatBai;
        private System.Windows.Forms.Button btnThanhCong;
        private System.Windows.Forms.DataGridView dgvLSGH;
        private System.Windows.Forms.Button btnCTDH_LSGH;
    }
}
