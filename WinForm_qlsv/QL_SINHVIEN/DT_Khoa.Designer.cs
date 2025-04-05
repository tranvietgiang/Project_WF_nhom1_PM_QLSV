namespace Login
{
    partial class DT_KHOA
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
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txtmatim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_exist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhienthi
            // 
            this.dgvhienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvhienthi.Location = new System.Drawing.Point(0, 0);
            this.dgvhienthi.Name = "dgvhienthi";
            this.dgvhienthi.RowHeadersWidth = 51;
            this.dgvhienthi.RowTemplate.Height = 24;
            this.dgvhienthi.Size = new System.Drawing.Size(1310, 269);
            this.dgvhienthi.TabIndex = 0;
            this.dgvhienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhienthi_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(474, 295);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 40);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(155, 295);
            this.txtma.Multiline = true;
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(242, 31);
            this.txtma.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(55, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khoa";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(155, 360);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(242, 31);
            this.txtten.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(55, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khoa";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(780, 297);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 40);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(624, 297);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 40);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(435, 425);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 40);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtmatim
            // 
            this.txtmatim.Location = new System.Drawing.Point(153, 425);
            this.txtmatim.Multiline = true;
            this.txtmatim.Name = "txtmatim";
            this.txtmatim.Size = new System.Drawing.Size(252, 40);
            this.txtmatim.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlammoi);
            this.panel1.Controls.Add(this.txtmatim);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.dgvhienthi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 581);
            this.panel1.TabIndex = 75;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(554, 425);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(100, 40);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_logo.Image = global::Login.Properties.Resources.TDC;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(1310, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 74;
            this.pic_logo.TabStop = false;
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1179, 136);
            this.btn_exist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(119, 39);
            this.btn_exist.TabIndex = 77;
            this.btn_exist.Text = "Quay Lại";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // DT_KHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 761);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_logo);
            this.Name = "DT_KHOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DT_KHOA";
            this.Load += new System.EventHandler(this.DT_KHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.DataGridView dgvhienthi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtmatim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btn_exist;
    }
}