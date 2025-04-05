namespace Login
{
    partial class GV_SinhVien
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
            this.btn_exist = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_find = new System.Windows.Forms.Button();
            this.cob_masv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1365, 107);
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
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 590);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1487, 2);
            this.panel4.TabIndex = 55;
            // 
            // dgv_students
            // 
            this.dgv_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_students.Location = new System.Drawing.Point(0, 146);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.RowHeadersWidth = 51;
            this.dgv_students.RowTemplate.Height = 24;
            this.dgv_students.Size = new System.Drawing.Size(1487, 444);
            this.dgv_students.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cob_masv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_find);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 212);
            this.panel1.TabIndex = 58;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(632, 52);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(77, 41);
            this.btn_find.TabIndex = 0;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cob_masv
            // 
            this.cob_masv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_masv.FormattingEnabled = true;
            this.cob_masv.Location = new System.Drawing.Point(342, 52);
            this.cob_masv.Name = "cob_masv";
            this.cob_masv.Size = new System.Drawing.Size(269, 24);
            this.cob_masv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "MÃ SV";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Làm Mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Login.Properties.Resources.TDC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1487, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // GV_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1487, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GV_SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GV_SinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GV_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ComboBox cob_masv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}