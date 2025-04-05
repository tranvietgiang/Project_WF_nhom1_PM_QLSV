namespace Login
{
    partial class DT_THONGKE
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
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_logo.Image = global::Login.Properties.Resources.TDC;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(1301, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 75;
            this.pic_logo.TabStop = false;
            // 
            // dgvhienthi
            // 
            this.dgvhienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvhienthi.Location = new System.Drawing.Point(0, 180);
            this.dgvhienthi.Name = "dgvhienthi";
            this.dgvhienthi.RowHeadersWidth = 51;
            this.dgvhienthi.RowTemplate.Height = 24;
            this.dgvhienthi.Size = new System.Drawing.Size(1301, 392);
            this.dgvhienthi.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 42);
            this.button1.TabIndex = 81;
            this.button1.Text = "tổng sinh viên trong các ngành";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 644);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 42);
            this.button2.TabIndex = 82;
            this.button2.Text = "tổng số lượng sinh viên trong truòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(565, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 42);
            this.button3.TabIndex = 83;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DT_THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 754);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvhienthi);
            this.Controls.Add(this.pic_logo);
            this.Name = "DT_THONGKE";
            this.Text = "DT_THONGKE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DT_THONGKE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.DataGridView dgvhienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}