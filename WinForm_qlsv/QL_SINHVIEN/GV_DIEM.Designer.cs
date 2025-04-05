namespace DOAN1_LTUD
{
    partial class GV_DIEM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_xemsv = new System.Windows.Forms.Button();
            this.btn_detail_sroce = new System.Windows.Forms.Button();
            this.btn_average = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.cob_masv = new System.Windows.Forms.ComboBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exist = new System.Windows.Forms.Button();
            this.dgv_score = new System.Windows.Forms.DataGridView();
            this.cob_massv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_mssv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.TDC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1758, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cob_massv);
            this.panel4.Controls.Add(this.lab_mssv);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btn_xemsv);
            this.panel4.Controls.Add(this.btn_detail_sroce);
            this.panel4.Controls.Add(this.btn_average);
            this.panel4.Controls.Add(this.btn_sort);
            this.panel4.Controls.Add(this.cob_masv);
            this.panel4.Controls.Add(this.btn_find);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1758, 304);
            this.panel4.TabIndex = 14;
            // 
            // btn_xemsv
            // 
            this.btn_xemsv.Location = new System.Drawing.Point(698, 166);
            this.btn_xemsv.Name = "btn_xemsv";
            this.btn_xemsv.Size = new System.Drawing.Size(293, 37);
            this.btn_xemsv.TabIndex = 12;
            this.btn_xemsv.Text = "Sinh Viên";
            this.btn_xemsv.UseVisualStyleBackColor = true;
            this.btn_xemsv.Click += new System.EventHandler(this.btn_xemsv_Click);
            // 
            // btn_detail_sroce
            // 
            this.btn_detail_sroce.Location = new System.Drawing.Point(867, 104);
            this.btn_detail_sroce.Name = "btn_detail_sroce";
            this.btn_detail_sroce.Size = new System.Drawing.Size(124, 37);
            this.btn_detail_sroce.TabIndex = 12;
            this.btn_detail_sroce.Text = "detail điểm";
            this.btn_detail_sroce.UseVisualStyleBackColor = true;
            this.btn_detail_sroce.Click += new System.EventHandler(this.btn_detail_sroce_Click);
            // 
            // btn_average
            // 
            this.btn_average.Location = new System.Drawing.Point(867, 41);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(124, 37);
            this.btn_average.TabIndex = 12;
            this.btn_average.Text = "ĐTB";
            this.btn_average.UseVisualStyleBackColor = true;
            this.btn_average.Click += new System.EventHandler(this.btn_average_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(698, 100);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(124, 37);
            this.btn_sort.TabIndex = 12;
            this.btn_sort.Text = "Rank SV";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // cob_masv
            // 
            this.cob_masv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_masv.FormattingEnabled = true;
            this.cob_masv.Location = new System.Drawing.Point(80, 74);
            this.cob_masv.Name = "cob_masv";
            this.cob_masv.Size = new System.Drawing.Size(173, 24);
            this.cob_masv.TabIndex = 11;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(698, 41);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(124, 37);
            this.btn_find.TabIndex = 10;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sinh viên";
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1627, 142);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(119, 40);
            this.btn_exist.TabIndex = 40;
            this.btn_exist.Text = "Quay Lại";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // dgv_score
            // 
            this.dgv_score.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_score.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_score.Location = new System.Drawing.Point(0, 182);
            this.dgv_score.Name = "dgv_score";
            this.dgv_score.RowHeadersWidth = 51;
            this.dgv_score.RowTemplate.Height = 24;
            this.dgv_score.Size = new System.Drawing.Size(1758, 203);
            this.dgv_score.TabIndex = 41;
            // 
            // cob_massv
            // 
            this.cob_massv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_massv.FormattingEnabled = true;
            this.cob_massv.Location = new System.Drawing.Point(12, 268);
            this.cob_massv.Name = "cob_massv";
            this.cob_massv.Size = new System.Drawing.Size(155, 24);
            this.cob_massv.TabIndex = 14;
            this.cob_massv.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã SSV";
            // 
            // lab_mssv
            // 
            this.lab_mssv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab_mssv.Location = new System.Drawing.Point(283, 74);
            this.lab_mssv.Name = "lab_mssv";
            this.lab_mssv.Size = new System.Drawing.Size(158, 32);
            this.lab_mssv.TabIndex = 13;
            this.lab_mssv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_mssv.Click += new System.EventHandler(this.lab_mssv_Click);
            // 
            // GV_DIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1758, 689);
            this.Controls.Add(this.dgv_score);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GV_DIEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANGCHU_GV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DIEM_GV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.DataGridView dgv_score;
        private System.Windows.Forms.ComboBox cob_masv;
        private System.Windows.Forms.Button btn_xemsv;
        private System.Windows.Forms.Button btn_detail_sroce;
        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.ComboBox cob_massv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_mssv;
    }
}