namespace Login
{
    partial class GV_VIPHAM
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
            this.dgv_violation = new System.Windows.Forms.DataGridView();
            this.btn_exist = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mavp = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cob_mamh = new System.Windows.Forms.ComboBox();
            this.cob_mssv = new System.Windows.Forms.ComboBox();
            this.btn_CThi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChuViPham = new System.Windows.Forms.Button();
            this.btnSVCLASSCD23TT9 = new System.Windows.Forms.Button();
            this.cob_vipham = new System.Windows.Forms.ComboBox();
            this.btn_detail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_violation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_violation
            // 
            this.dgv_violation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_violation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_violation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_violation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_violation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_violation.Location = new System.Drawing.Point(0, 146);
            this.dgv_violation.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_violation.Name = "dgv_violation";
            this.dgv_violation.RowHeadersWidth = 51;
            this.dgv_violation.Size = new System.Drawing.Size(1492, 591);
            this.dgv_violation.TabIndex = 62;
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1361, 107);
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
            this.panel4.Location = new System.Drawing.Point(0, 737);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1492, 2);
            this.panel4.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.TDC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1492, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cob_vipham);
            this.panel3.Controls.Add(this.btnChuViPham);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_CThi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_mavp);
            this.panel3.Controls.Add(this.btn_detail);
            this.panel3.Controls.Add(this.btnSVCLASSCD23TT9);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.cob_mamh);
            this.panel3.Controls.Add(this.cob_mssv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1492, 333);
            this.panel3.TabIndex = 63;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lỗi Vi Phạm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã Vi Phạm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên SV";
            // 
            // txt_mavp
            // 
            this.txt_mavp.Location = new System.Drawing.Point(360, 27);
            this.txt_mavp.Multiline = true;
            this.txt_mavp.Name = "txt_mavp";
            this.txt_mavp.Size = new System.Drawing.Size(212, 28);
            this.txt_mavp.TabIndex = 3;
            this.txt_mavp.TextChanged += new System.EventHandler(this.txt_mavp_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(724, 89);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 46);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Sửa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(724, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cob_mamh
            // 
            this.cob_mamh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_mamh.FormattingEnabled = true;
            this.cob_mamh.Location = new System.Drawing.Point(360, 150);
            this.cob_mamh.Name = "cob_mamh";
            this.cob_mamh.Size = new System.Drawing.Size(212, 24);
            this.cob_mamh.TabIndex = 0;
            // 
            // cob_mssv
            // 
            this.cob_mssv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_mssv.FormattingEnabled = true;
            this.cob_mssv.Location = new System.Drawing.Point(360, 89);
            this.cob_mssv.Name = "cob_mssv";
            this.cob_mssv.Size = new System.Drawing.Size(212, 24);
            this.cob_mssv.TabIndex = 0;
            // 
            // btn_CThi
            // 
            this.btn_CThi.Location = new System.Drawing.Point(724, 158);
            this.btn_CThi.Name = "btn_CThi";
            this.btn_CThi.Size = new System.Drawing.Size(97, 46);
            this.btn_CThi.TabIndex = 6;
            this.btn_CThi.Text = "DS SV Cấm Thi";
            this.btn_CThi.UseVisualStyleBackColor = true;
            this.btn_CThi.Click += new System.EventHandler(this.btn_CThi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChuViPham
            // 
            this.btnChuViPham.Location = new System.Drawing.Point(843, 27);
            this.btnChuViPham.Name = "btnChuViPham";
            this.btnChuViPham.Size = new System.Drawing.Size(122, 46);
            this.btnChuViPham.TabIndex = 8;
            this.btnChuViPham.Text = "SV Chua VP";
            this.btnChuViPham.UseVisualStyleBackColor = true;
            this.btnChuViPham.Click += new System.EventHandler(this.btnChuViPham_Click);
            // 
            // btnSVCLASSCD23TT9
            // 
            this.btnSVCLASSCD23TT9.Location = new System.Drawing.Point(843, 86);
            this.btnSVCLASSCD23TT9.Name = "btnSVCLASSCD23TT9";
            this.btnSVCLASSCD23TT9.Size = new System.Drawing.Size(122, 46);
            this.btnSVCLASSCD23TT9.TabIndex = 2;
            this.btnSVCLASSCD23TT9.Text = "ALL SV";
            this.btnSVCLASSCD23TT9.UseVisualStyleBackColor = true;
            this.btnSVCLASSCD23TT9.Click += new System.EventHandler(this.btnSVCLASSCD23TT9_Click);
            // 
            // cob_vipham
            // 
            this.cob_vipham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_vipham.FormattingEnabled = true;
            this.cob_vipham.Items.AddRange(new object[] {
            "Không mặc đồng phục",
            "Vắng",
            "Không tham...(bắt buộc)"});
            this.cob_vipham.Location = new System.Drawing.Point(360, 197);
            this.cob_vipham.Name = "cob_vipham";
            this.cob_vipham.Size = new System.Drawing.Size(212, 24);
            this.cob_vipham.TabIndex = 9;
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(843, 158);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(122, 46);
            this.btn_detail.TabIndex = 2;
            this.btn_detail.Text = "Chi tiết lỗi";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // GV_VIPHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1492, 739);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_violation);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GV_VIPHAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GV_VIPHAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GV_VIPHAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_violation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_violation;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cob_mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mavp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cob_mamh;
        private System.Windows.Forms.Button btn_CThi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChuViPham;
        private System.Windows.Forms.Button btnSVCLASSCD23TT9;
        private System.Windows.Forms.ComboBox cob_vipham;
        private System.Windows.Forms.Button btn_detail;
    }
}