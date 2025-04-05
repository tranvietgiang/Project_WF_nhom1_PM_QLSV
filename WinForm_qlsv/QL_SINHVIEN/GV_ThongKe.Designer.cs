namespace Login
{
    partial class GV_ThongKe
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
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.btn_exist = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            this.bntnam = new System.Windows.Forms.Button();
            this.btnnu = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatim = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_thongke.Location = new System.Drawing.Point(0, 146);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.Size = new System.Drawing.Size(1343, 472);
            this.dgv_thongke.TabIndex = 62;
            this.dgv_thongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongke_CellContentClick);
            // 
            // btn_exist
            // 
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1217, 107);
            this.btn_exist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(119, 39);
            this.btn_exist.TabIndex = 61;
            this.btn_exist.Text = "Quay Lại";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 618);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1343, 2);
            this.panel4.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.TDC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1343, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // dgvhienthi
            // 
            this.dgvhienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvhienthi.Location = new System.Drawing.Point(0, 146);
            this.dgvhienthi.Name = "dgvhienthi";
            this.dgvhienthi.RowHeadersWidth = 51;
            this.dgvhienthi.RowTemplate.Height = 24;
            this.dgvhienthi.Size = new System.Drawing.Size(1343, 230);
            this.dgvhienthi.TabIndex = 63;
            // 
            // bntnam
            // 
            this.bntnam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntnam.Location = new System.Drawing.Point(330, 527);
            this.bntnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntnam.Name = "bntnam";
            this.bntnam.Size = new System.Drawing.Size(223, 34);
            this.bntnam.TabIndex = 59;
            this.bntnam.Text = "sinh viên nam";
            this.bntnam.UseVisualStyleBackColor = false;
            this.bntnam.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnnu
            // 
            this.btnnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnnu.Location = new System.Drawing.Point(645, 527);
            this.btnnu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnu.Name = "btnnu";
            this.btnnu.Size = new System.Drawing.Size(223, 34);
            this.btnnu.TabIndex = 60;
            this.btnnu.Text = "sinh viên nữ";
            this.btnnu.UseVisualStyleBackColor = false;
            this.btnnu.Click += new System.EventHandler(this.btnnu_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.Location = new System.Drawing.Point(645, 433);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 34);
            this.button8.TabIndex = 61;
            this.button8.Text = "Sinh viên điểm >= 5";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.Location = new System.Drawing.Point(330, 433);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(223, 34);
            this.button9.TabIndex = 62;
            this.button9.Text = "Sinh viên điểm < 5";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "TÌm theo tên sinh viên";
            // 
            // txtmatim
            // 
            this.txtmatim.Location = new System.Drawing.Point(931, 439);
            this.txtmatim.Multiline = true;
            this.txtmatim.Name = "txtmatim";
            this.txtmatim.Size = new System.Drawing.Size(279, 28);
            this.txtmatim.TabIndex = 65;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.Location = new System.Drawing.Point(1229, 436);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 31);
            this.button6.TabIndex = 66;
            this.button6.Text = "Tìm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlammoi.Location = new System.Drawing.Point(1185, 530);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(102, 31);
            this.btnlammoi.TabIndex = 67;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // GV_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 620);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtmatim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntnam);
            this.Controls.Add(this.btnnu);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dgvhienthi);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GV_ThongKe";
            this.Text = "GV_ThongKe";
            this.Load += new System.EventHandler(this.GV_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvhienthi;
        private System.Windows.Forms.Button bntnam;
        private System.Windows.Forms.Button btnnu;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatim;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnlammoi;
    }
}