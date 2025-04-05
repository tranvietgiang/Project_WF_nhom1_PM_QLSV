namespace Login
{
    partial class GV_CLASS
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
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.btn_exist = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cob_schedule = new System.Windows.Forms.ComboBox();
            this.cob_classID = new System.Windows.Forms.ComboBox();
            this.cob_buoi_day = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_class
            // 
            this.dgv_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_class.Location = new System.Drawing.Point(0, 195);
            this.dgv_class.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.RowHeadersWidth = 51;
            this.dgv_class.Size = new System.Drawing.Size(1534, 281);
            this.dgv_class.TabIndex = 57;
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1399, 152);
            this.btn_exist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(119, 39);
            this.btn_exist.TabIndex = 56;
            this.btn_exist.Text = "Quay Lại";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cob_schedule);
            this.panel4.Controls.Add(this.cob_classID);
            this.panel4.Controls.Add(this.cob_buoi_day);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 195);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1534, 484);
            this.panel4.TabIndex = 55;
            // 
            // cob_schedule
            // 
            this.cob_schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_schedule.FormattingEnabled = true;
            this.cob_schedule.Items.AddRange(new object[] {
            "Sang: 7H-11H45",
            "Chieu12H45-17H",
            "CN: 7H-11H45",
            "CN: 12H45-17H"});
            this.cob_schedule.Location = new System.Drawing.Point(521, 457);
            this.cob_schedule.Name = "cob_schedule";
            this.cob_schedule.Size = new System.Drawing.Size(162, 24);
            this.cob_schedule.TabIndex = 52;
            // 
            // cob_classID
            // 
            this.cob_classID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_classID.FormattingEnabled = true;
            this.cob_classID.Items.AddRange(new object[] {
            "THỨ 2",
            "THỨ 3",
            "THỨ 4",
            "THỨ 5",
            "THỨ 6",
            "THỨ 7",
            "CN"});
            this.cob_classID.Location = new System.Drawing.Point(521, 350);
            this.cob_classID.Name = "cob_classID";
            this.cob_classID.Size = new System.Drawing.Size(162, 24);
            this.cob_classID.TabIndex = 53;
            // 
            // cob_buoi_day
            // 
            this.cob_buoi_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_buoi_day.FormattingEnabled = true;
            this.cob_buoi_day.Items.AddRange(new object[] {
            "THỨ 2",
            "THỨ 3",
            "THỨ 4",
            "THỨ 5",
            "THỨ 6",
            "THỨ 7",
            "CN"});
            this.cob_buoi_day.Location = new System.Drawing.Point(521, 411);
            this.cob_buoi_day.Name = "cob_buoi_day";
            this.cob_buoi_day.Size = new System.Drawing.Size(162, 24);
            this.cob_buoi_day.TabIndex = 54;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(757, 328);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 43);
            this.btn_update.TabIndex = 51;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Lịch Giảng Dậy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Buổi Giảng Dậy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Mã Lớp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.TDC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1534, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GV_CLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1534, 679);
            this.Controls.Add(this.dgv_class);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GV_CLASS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GV_CLASS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GV_CLASS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_class;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cob_schedule;
        private System.Windows.Forms.ComboBox cob_classID;
        private System.Windows.Forms.ComboBox cob_buoi_day;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}