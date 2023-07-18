namespace QLyNguoiNghien.View
{
    partial class fDataNguoiCaiNghien
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
            this.cmbPhuongPhap = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgNguoiCaiNghien = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxDiaChi = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiThuoc = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNguoiCaiNghien)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPhuongPhap
            // 
            this.cmbPhuongPhap.FormattingEnabled = true;
            this.cmbPhuongPhap.Items.AddRange(new object[] {
            "Hít",
            "Hút",
            "Ngửi khói",
            "Tiêm bắp"});
            this.cmbPhuongPhap.Location = new System.Drawing.Point(162, 418);
            this.cmbPhuongPhap.Name = "cmbPhuongPhap";
            this.cmbPhuongPhap.Size = new System.Drawing.Size(242, 28);
            this.cmbPhuongPhap.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(410, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(473, 35);
            this.label8.TabIndex = 43;
            this.label8.Text = "Bảng thông tin người cai nghiện";
            // 
            // dtgNguoiCaiNghien
            // 
            this.dtgNguoiCaiNghien.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtgNguoiCaiNghien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNguoiCaiNghien.Location = new System.Drawing.Point(419, 133);
            this.dtgNguoiCaiNghien.Name = "dtgNguoiCaiNghien";
            this.dtgNguoiCaiNghien.RowHeadersWidth = 51;
            this.dtgNguoiCaiNghien.RowTemplate.Height = 29;
            this.dtgNguoiCaiNghien.Size = new System.Drawing.Size(464, 309);
            this.dtgNguoiCaiNghien.TabIndex = 42;
            this.dtgNguoiCaiNghien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNguoiCaiNghien_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Phương pháp ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Loại Thuốc";
            // 
            // rtxDiaChi
            // 
            this.rtxDiaChi.Location = new System.Drawing.Point(162, 252);
            this.rtxDiaChi.Name = "rtxDiaChi";
            this.rtxDiaChi.Size = new System.Drawing.Size(242, 90);
            this.rtxDiaChi.TabIndex = 33;
            this.rtxDiaChi.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(82, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã";
            // 
            // txtLoaiThuoc
            // 
            this.txtLoaiThuoc.Location = new System.Drawing.Point(162, 365);
            this.txtLoaiThuoc.Name = "txtLoaiThuoc";
            this.txtLoaiThuoc.Size = new System.Drawing.Size(242, 27);
            this.txtLoaiThuoc.TabIndex = 34;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(162, 190);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(242, 27);
            this.txtTuoi.TabIndex = 32;
            this.txtTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuoi_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(162, 138);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(242, 27);
            this.txtHoTen.TabIndex = 31;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress_1);
            // 
            // txtMaNN
            // 
            this.txtMaNN.Location = new System.Drawing.Point(162, 74);
            this.txtMaNN.Name = "txtMaNN";
            this.txtMaNN.Size = new System.Drawing.Size(242, 27);
            this.txtMaNN.TabIndex = 30;
            this.txtMaNN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNN_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(468, 507);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 52);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(633, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 52);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(789, 507);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 52);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(162, 507);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 27);
            this.txtSearch.TabIndex = 47;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tìm kiếm";
            // 
            // fDataNguoiCaiNghien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(926, 591);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgNguoiCaiNghien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPhuongPhap);
            this.Controls.Add(this.txtLoaiThuoc);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNN);
            this.Name = "fDataNguoiCaiNghien";
            this.Text = "fDataNguoiCaiNghien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNguoiCaiNghien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private DataGridView dtgNguoiCaiNghien;
        private Label label6;
        private Label label5;
        private RichTextBox rtxDiaChi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPhuongPhap;
        private TextBox txtLoaiThuoc;
        private TextBox txtTuoi;
        private TextBox txtHoTen;
        private TextBox txtMaNN;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label label7;
    }
}