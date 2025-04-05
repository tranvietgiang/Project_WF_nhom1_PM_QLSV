namespace Login
{
    partial class DT_HocPhi
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
            this.dgv_hp = new System.Windows.Forms.DataGridView();
            this.btn_exist = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_findSV = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtp_date_dong = new System.Windows.Forms.DateTimePicker();
            this.btnLM = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_daNopHP = new System.Windows.Forms.Button();
            this.btn_chuaNopHP = new System.Windows.Forms.Button();
            this.lab_class = new System.Windows.Forms.Label();
            this.btn_theoten = new System.Windows.Forms.Button();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.cob_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_tinhHP = new System.Windows.Forms.Button();
            this.lbl_totalHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hp)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hp
            // 
            this.dgv_hp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_hp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hp.Location = new System.Drawing.Point(0, 146);
            this.dgv_hp.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hp.Name = "dgv_hp";
            this.dgv_hp.RowHeadersWidth = 51;
            this.dgv_hp.Size = new System.Drawing.Size(1678, 227);
            this.dgv_hp.TabIndex = 57;
            this.dgv_hp.Click += new System.EventHandler(this.dgv_hp_Click);
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1538, 107);
            this.btn_exist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(119, 39);
            this.btn_exist.TabIndex = 56;
            this.btn_exist.Text = "Quay Lại";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ngày Đóng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1019, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nhập Sinh Viên Cần Tìm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 0;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(1022, 161);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(99, 31);
            this.btn_find.TabIndex = 6;
            this.btn_find.Text = "Tìm Mã ";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(448, 168);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(146, 42);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_findSV
            // 
            this.txt_findSV.Location = new System.Drawing.Point(1022, 114);
            this.txt_findSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_findSV.Multiline = true;
            this.txt_findSV.Name = "txt_findSV";
            this.txt_findSV.Size = new System.Drawing.Size(271, 26);
            this.txt_findSV.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(417, -4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 307);
            this.textBox1.TabIndex = 46;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(847, -1);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 307);
            this.textBox3.TabIndex = 46;
            // 
            // dtp_date_dong
            // 
            this.dtp_date_dong.CustomFormat = "dd/MM/yyyy";
            this.dtp_date_dong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date_dong.Location = new System.Drawing.Point(121, 150);
            this.dtp_date_dong.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_date_dong.Name = "dtp_date_dong";
            this.dtp_date_dong.Size = new System.Drawing.Size(165, 22);
            this.dtp_date_dong.TabIndex = 49;
            // 
            // btnLM
            // 
            this.btnLM.Location = new System.Drawing.Point(602, 40);
            this.btnLM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(110, 31);
            this.btnLM.TabIndex = 7;
            this.btnLM.Text = "Làm mới";
            this.btnLM.UseVisualStyleBackColor = true;
            this.btnLM.Click += new System.EventHandler(this.btnLM_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_totalHP);
            this.panel4.Controls.Add(this.btn_tinhHP);
            this.panel4.Controls.Add(this.btn_daNopHP);
            this.panel4.Controls.Add(this.btn_chuaNopHP);
            this.panel4.Controls.Add(this.lab_class);
            this.panel4.Controls.Add(this.btn_theoten);
            this.panel4.Controls.Add(this.txt_masv);
            this.panel4.Controls.Add(this.cob_status);
            this.panel4.Controls.Add(this.btnLM);
            this.panel4.Controls.Add(this.dtp_date_dong);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.txt_findSV);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.btn_find);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 373);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1678, 312);
            this.panel4.TabIndex = 55;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_daNopHP
            // 
            this.btn_daNopHP.Location = new System.Drawing.Point(447, 110);
            this.btn_daNopHP.Name = "btn_daNopHP";
            this.btn_daNopHP.Size = new System.Drawing.Size(122, 32);
            this.btn_daNopHP.TabIndex = 56;
            this.btn_daNopHP.Text = "Đã Nộp HP";
            this.btn_daNopHP.UseVisualStyleBackColor = true;
            this.btn_daNopHP.Click += new System.EventHandler(this.btn_daNopHP_Click);
            // 
            // btn_chuaNopHP
            // 
            this.btn_chuaNopHP.Location = new System.Drawing.Point(447, 40);
            this.btn_chuaNopHP.Name = "btn_chuaNopHP";
            this.btn_chuaNopHP.Size = new System.Drawing.Size(122, 32);
            this.btn_chuaNopHP.TabIndex = 55;
            this.btn_chuaNopHP.Text = "Chưa Nộp HP";
            this.btn_chuaNopHP.UseVisualStyleBackColor = true;
            this.btn_chuaNopHP.Click += new System.EventHandler(this.btn_chuaNopHP_Click);
            // 
            // lab_class
            // 
            this.lab_class.AutoSize = true;
            this.lab_class.Location = new System.Drawing.Point(864, 23);
            this.lab_class.Name = "lab_class";
            this.lab_class.Size = new System.Drawing.Size(65, 16);
            this.lab_class.TabIndex = 53;
            this.lab_class.Text = "CD23TT9";
            // 
            // btn_theoten
            // 
            this.btn_theoten.Location = new System.Drawing.Point(1127, 161);
            this.btn_theoten.Name = "btn_theoten";
            this.btn_theoten.Size = new System.Drawing.Size(166, 31);
            this.btn_theoten.TabIndex = 52;
            this.btn_theoten.Text = "Tìm theo tên";
            this.btn_theoten.UseVisualStyleBackColor = true;
            this.btn_theoten.Click += new System.EventHandler(this.btn_theoten_Click);
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(121, 45);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(165, 22);
            this.txt_masv.TabIndex = 51;
            this.txt_masv.TextChanged += new System.EventHandler(this.txt_masv_TextChanged);
            // 
            // cob_status
            // 
            this.cob_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_status.FormattingEnabled = true;
            this.cob_status.Items.AddRange(new object[] {
            "CHƯA ĐÓNG",
            "ĐÃ ĐÓNG"});
            this.cob_status.Location = new System.Drawing.Point(121, 96);
            this.cob_status.Name = "cob_status";
            this.cob_status.Size = new System.Drawing.Size(165, 24);
            this.cob_status.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trạng Thái";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.TDC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1678, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btn_tinhHP
            // 
            this.btn_tinhHP.Location = new System.Drawing.Point(619, 110);
            this.btn_tinhHP.Name = "btn_tinhHP";
            this.btn_tinhHP.Size = new System.Drawing.Size(136, 33);
            this.btn_tinhHP.TabIndex = 57;
            this.btn_tinhHP.Text = "Tính Học Phí";
            this.btn_tinhHP.UseVisualStyleBackColor = true;
            this.btn_tinhHP.Click += new System.EventHandler(this.btn_tinhHP_Click);
            // 
            // lbl_totalHP
            // 
            this.lbl_totalHP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_totalHP.Location = new System.Drawing.Point(616, 168);
            this.lbl_totalHP.Name = "lbl_totalHP";
            this.lbl_totalHP.Size = new System.Drawing.Size(157, 46);
            this.lbl_totalHP.TabIndex = 58;
            this.lbl_totalHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_totalHP.Click += new System.EventHandler(this.lbl_totalHP_Click);
            // 
            // DT_HocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1678, 685);
            this.Controls.Add(this.dgv_hp);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DT_HocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DT_HocPhi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DT_HocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hp;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_findSV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dtp_date_dong;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cob_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_theoten;
        private System.Windows.Forms.Label lab_class;
        private System.Windows.Forms.Button btn_daNopHP;
        private System.Windows.Forms.Button btn_chuaNopHP;
        private System.Windows.Forms.Button btn_tinhHP;
        private System.Windows.Forms.Label lbl_totalHP;
    }
}