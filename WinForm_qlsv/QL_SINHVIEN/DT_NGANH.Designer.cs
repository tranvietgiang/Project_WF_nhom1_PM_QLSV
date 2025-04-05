namespace Login
{
    partial class DT_NGANH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbmagv = new System.Windows.Forms.ComboBox();
            this.txtmatim = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_exist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbmagv);
            this.panel1.Controls.Add(this.txtmatim);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.dgvhienthi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 516);
            this.panel1.TabIndex = 73;
            // 
            // cbbmagv
            // 
            this.cbbmagv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmagv.FormattingEnabled = true;
            this.cbbmagv.Location = new System.Drawing.Point(155, 431);
            this.cbbmagv.Name = "cbbmagv";
            this.cbbmagv.Size = new System.Drawing.Size(242, 24);
            this.cbbmagv.TabIndex = 12;
            this.cbbmagv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtmatim
            // 
            this.txtmatim.Location = new System.Drawing.Point(603, 397);
            this.txtmatim.Multiline = true;
            this.txtmatim.Name = "txtmatim";
            this.txtmatim.Size = new System.Drawing.Size(252, 40);
            this.txtmatim.TabIndex = 11;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(465, 397);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 40);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(606, 295);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 40);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(755, 295);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 40);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(38, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên ngành";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(155, 360);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(242, 31);
            this.txtten.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(38, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã ngành";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(155, 295);
            this.txtma.Multiline = true;
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(242, 31);
            this.txtma.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(465, 295);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 40);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
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
            this.dgvhienthi.Size = new System.Drawing.Size(1381, 269);
            this.dgvhienthi.TabIndex = 0;
            this.dgvhienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhienthi_CellClick);
            this.dgvhienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pic_logo
            // 
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_logo.Image = global::Login.Properties.Resources.TDC;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(1381, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 72;
            this.pic_logo.TabStop = false;
            // 
            // btn_exist
            // 
            this.btn_exist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exist.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exist.Location = new System.Drawing.Point(1250, 136);
            this.btn_exist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(119, 39);
            this.btn_exist.TabIndex = 78;
            this.btn_exist.Text = "Quay Lại";
            this.btn_exist.UseVisualStyleBackColor = false;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // DT_NGANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 696);
            this.Controls.Add(this.btn_exist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_logo);
            this.Name = "DT_NGANH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DT_NGANH";
            this.Load += new System.EventHandler(this.DT_KHOA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvhienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmatim;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbmagv;
        private System.Windows.Forms.Button btn_exist;
    }
}