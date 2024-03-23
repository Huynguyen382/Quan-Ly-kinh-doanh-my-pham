
namespace BTL3
{
    partial class FormSanPham
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
            this.label_SoLuongKho = new System.Windows.Forms.Label();
            this.label_MaNCC = new System.Windows.Forms.Label();
            this.label_MaLoai = new System.Windows.Forms.Label();
            this.label_MaNSX = new System.Windows.Forms.Label();
            this.label_NuocSanXuat = new System.Windows.Forms.Label();
            this.label_DonGia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_TenSanPham = new System.Windows.Forms.Label();
            this.label_MaSanPham = new System.Windows.Forms.Label();
            this.button_InBaoCaoSP = new System.Windows.Forms.Button();
            this.btn_DeleteTextBoxSP = new System.Windows.Forms.Button();
            this.button_XoaSP = new System.Windows.Forms.Button();
            this.button_ChinhSuaSP = new System.Windows.Forms.Button();
            this.button_ThemMoiSP = new System.Windows.Forms.Button();
            this.textBox_SoLuongKho = new System.Windows.Forms.TextBox();
            this.textBox_MaNCC = new System.Windows.Forms.TextBox();
            this.textBox_NuocSanXuat = new System.Windows.Forms.TextBox();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.groupBox_DanhSachSanPham = new System.Windows.Forms.GroupBox();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.textBox_TenSanPham = new System.Windows.Forms.TextBox();
            this.textBox_MaSanPham = new System.Windows.Forms.TextBox();
            this.groupBox_ThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.textBox_MaNSX = new System.Windows.Forms.TextBox();
            this.textBox_MaLoai = new System.Windows.Forms.TextBox();
            this.groupBox_DanhSachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.groupBox_ThongTinNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SoLuongKho
            // 
            this.label_SoLuongKho.AutoSize = true;
            this.label_SoLuongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoLuongKho.Location = new System.Drawing.Point(501, 209);
            this.label_SoLuongKho.Name = "label_SoLuongKho";
            this.label_SoLuongKho.Size = new System.Drawing.Size(114, 20);
            this.label_SoLuongKho.TabIndex = 37;
            this.label_SoLuongKho.Text = "Số lượng kho";
            // 
            // label_MaNCC
            // 
            this.label_MaNCC.AutoSize = true;
            this.label_MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaNCC.Location = new System.Drawing.Point(501, 154);
            this.label_MaNCC.Name = "label_MaNCC";
            this.label_MaNCC.Size = new System.Drawing.Size(74, 20);
            this.label_MaNCC.TabIndex = 36;
            this.label_MaNCC.Text = "Mã NCC";
            // 
            // label_MaLoai
            // 
            this.label_MaLoai.AutoSize = true;
            this.label_MaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaLoai.Location = new System.Drawing.Point(501, 96);
            this.label_MaLoai.Name = "label_MaLoai";
            this.label_MaLoai.Size = new System.Drawing.Size(66, 20);
            this.label_MaLoai.TabIndex = 35;
            this.label_MaLoai.Text = "Mã loại";
            // 
            // label_MaNSX
            // 
            this.label_MaNSX.AutoSize = true;
            this.label_MaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaNSX.Location = new System.Drawing.Point(501, 42);
            this.label_MaNSX.Name = "label_MaNSX";
            this.label_MaNSX.Size = new System.Drawing.Size(74, 20);
            this.label_MaNSX.TabIndex = 34;
            this.label_MaNSX.Text = "Mã NSX";
            // 
            // label_NuocSanXuat
            // 
            this.label_NuocSanXuat.AutoSize = true;
            this.label_NuocSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NuocSanXuat.Location = new System.Drawing.Point(30, 209);
            this.label_NuocSanXuat.Name = "label_NuocSanXuat";
            this.label_NuocSanXuat.Size = new System.Drawing.Size(123, 20);
            this.label_NuocSanXuat.TabIndex = 33;
            this.label_NuocSanXuat.Text = "Nước sản xuất";
            // 
            // label_DonGia
            // 
            this.label_DonGia.AutoSize = true;
            this.label_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DonGia.Location = new System.Drawing.Point(30, 154);
            this.label_DonGia.Name = "label_DonGia";
            this.label_DonGia.Size = new System.Drawing.Size(71, 20);
            this.label_DonGia.TabIndex = 32;
            this.label_DonGia.Text = "Đơn giá";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(731, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 52);
            this.button1.TabIndex = 31;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_TenSanPham
            // 
            this.label_TenSanPham.AutoSize = true;
            this.label_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenSanPham.Location = new System.Drawing.Point(30, 96);
            this.label_TenSanPham.Name = "label_TenSanPham";
            this.label_TenSanPham.Size = new System.Drawing.Size(122, 20);
            this.label_TenSanPham.TabIndex = 30;
            this.label_TenSanPham.Text = "Tên sản phẩm";
            // 
            // label_MaSanPham
            // 
            this.label_MaSanPham.AutoSize = true;
            this.label_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaSanPham.Location = new System.Drawing.Point(30, 42);
            this.label_MaSanPham.Name = "label_MaSanPham";
            this.label_MaSanPham.Size = new System.Drawing.Size(116, 20);
            this.label_MaSanPham.TabIndex = 29;
            this.label_MaSanPham.Text = "Mã sản phẩm";
            // 
            // button_InBaoCaoSP
            // 
            this.button_InBaoCaoSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InBaoCaoSP.Location = new System.Drawing.Point(731, 337);
            this.button_InBaoCaoSP.Name = "button_InBaoCaoSP";
            this.button_InBaoCaoSP.Size = new System.Drawing.Size(170, 50);
            this.button_InBaoCaoSP.TabIndex = 28;
            this.button_InBaoCaoSP.Text = "In báo cáo";
            this.button_InBaoCaoSP.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteTextBoxSP
            // 
            this.btn_DeleteTextBoxSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTextBoxSP.Location = new System.Drawing.Point(34, 337);
            this.btn_DeleteTextBoxSP.Name = "btn_DeleteTextBoxSP";
            this.btn_DeleteTextBoxSP.Size = new System.Drawing.Size(407, 50);
            this.btn_DeleteTextBoxSP.TabIndex = 25;
            this.btn_DeleteTextBoxSP.Text = "Đặt lại về mặc định";
            this.btn_DeleteTextBoxSP.UseVisualStyleBackColor = true;
            this.btn_DeleteTextBoxSP.Click += new System.EventHandler(this.btn_DeleteTextBoxSP_Click);
            // 
            // button_XoaSP
            // 
            this.button_XoaSP.Enabled = false;
            this.button_XoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaSP.Location = new System.Drawing.Point(321, 264);
            this.button_XoaSP.Name = "button_XoaSP";
            this.button_XoaSP.Size = new System.Drawing.Size(120, 50);
            this.button_XoaSP.TabIndex = 24;
            this.button_XoaSP.Text = "Xóa";
            this.button_XoaSP.UseVisualStyleBackColor = true;
            this.button_XoaSP.Click += new System.EventHandler(this.button_XoaSP_Click);
            // 
            // button_ChinhSuaSP
            // 
            this.button_ChinhSuaSP.Enabled = false;
            this.button_ChinhSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaSP.Location = new System.Drawing.Point(181, 263);
            this.button_ChinhSuaSP.Name = "button_ChinhSuaSP";
            this.button_ChinhSuaSP.Size = new System.Drawing.Size(120, 50);
            this.button_ChinhSuaSP.TabIndex = 23;
            this.button_ChinhSuaSP.Text = "Chỉnh sửa";
            this.button_ChinhSuaSP.UseVisualStyleBackColor = true;
            this.button_ChinhSuaSP.Click += new System.EventHandler(this.button_ChinhSuaSP_Click);
            // 
            // button_ThemMoiSP
            // 
            this.button_ThemMoiSP.Enabled = false;
            this.button_ThemMoiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemMoiSP.Location = new System.Drawing.Point(34, 262);
            this.button_ThemMoiSP.Name = "button_ThemMoiSP";
            this.button_ThemMoiSP.Size = new System.Drawing.Size(120, 50);
            this.button_ThemMoiSP.TabIndex = 22;
            this.button_ThemMoiSP.Text = "Thêm mới";
            this.button_ThemMoiSP.UseVisualStyleBackColor = true;
            this.button_ThemMoiSP.Click += new System.EventHandler(this.button_ThemMoiSP_Click);
            // 
            // textBox_SoLuongKho
            // 
            this.textBox_SoLuongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_SoLuongKho.Location = new System.Drawing.Point(631, 202);
            this.textBox_SoLuongKho.Name = "textBox_SoLuongKho";
            this.textBox_SoLuongKho.Size = new System.Drawing.Size(270, 30);
            this.textBox_SoLuongKho.TabIndex = 21;
            // 
            // textBox_MaNCC
            // 
            this.textBox_MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_MaNCC.Location = new System.Drawing.Point(631, 147);
            this.textBox_MaNCC.Name = "textBox_MaNCC";
            this.textBox_MaNCC.Size = new System.Drawing.Size(270, 30);
            this.textBox_MaNCC.TabIndex = 20;
            // 
            // textBox_NuocSanXuat
            // 
            this.textBox_NuocSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_NuocSanXuat.Location = new System.Drawing.Point(171, 202);
            this.textBox_NuocSanXuat.Name = "textBox_NuocSanXuat";
            this.textBox_NuocSanXuat.Size = new System.Drawing.Size(270, 30);
            this.textBox_NuocSanXuat.TabIndex = 17;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_DonGia.Location = new System.Drawing.Point(171, 147);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(270, 30);
            this.textBox_DonGia.TabIndex = 16;
            // 
            // groupBox_DanhSachSanPham
            // 
            this.groupBox_DanhSachSanPham.AutoSize = true;
            this.groupBox_DanhSachSanPham.Controls.Add(this.dataGridView_SanPham);
            this.groupBox_DanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_DanhSachSanPham.Location = new System.Drawing.Point(26, 458);
            this.groupBox_DanhSachSanPham.Name = "groupBox_DanhSachSanPham";
            this.groupBox_DanhSachSanPham.Size = new System.Drawing.Size(929, 343);
            this.groupBox_DanhSachSanPham.TabIndex = 41;
            this.groupBox_DanhSachSanPham.TabStop = false;
            this.groupBox_DanhSachSanPham.Text = "Danh sách sản phẩm";
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Location = new System.Drawing.Point(34, 41);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.Size = new System.Drawing.Size(867, 270);
            this.dataGridView_SanPham.TabIndex = 27;
            this.dataGridView_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SanPham_CellContentClick);
            // 
            // textBox_TenSanPham
            // 
            this.textBox_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_TenSanPham.Location = new System.Drawing.Point(171, 90);
            this.textBox_TenSanPham.Name = "textBox_TenSanPham";
            this.textBox_TenSanPham.Size = new System.Drawing.Size(270, 30);
            this.textBox_TenSanPham.TabIndex = 15;
            this.textBox_TenSanPham.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_TenSanPham_Validating);
            // 
            // textBox_MaSanPham
            // 
            this.textBox_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_MaSanPham.Location = new System.Drawing.Point(171, 35);
            this.textBox_MaSanPham.Name = "textBox_MaSanPham";
            this.textBox_MaSanPham.Size = new System.Drawing.Size(270, 30);
            this.textBox_MaSanPham.TabIndex = 14;
            this.textBox_MaSanPham.TextChanged += new System.EventHandler(this.textBox_MaSanPham_TextChanged);
            this.textBox_MaSanPham.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaSanPham_Validating);
            // 
            // groupBox_ThongTinNhanVien
            // 
            this.groupBox_ThongTinNhanVien.AutoSize = true;
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_MaNSX);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_MaLoai);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_SoLuongKho);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_MaNCC);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_MaLoai);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_MaNSX);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_NuocSanXuat);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_DonGia);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button1);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_TenSanPham);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_MaSanPham);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_InBaoCaoSP);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.btn_DeleteTextBoxSP);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_XoaSP);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_ChinhSuaSP);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_ThemMoiSP);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_SoLuongKho);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_MaNCC);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_NuocSanXuat);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_DonGia);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_TenSanPham);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_MaSanPham);
            this.groupBox_ThongTinNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_ThongTinNhanVien.Location = new System.Drawing.Point(26, 21);
            this.groupBox_ThongTinNhanVien.Name = "groupBox_ThongTinNhanVien";
            this.groupBox_ThongTinNhanVien.Size = new System.Drawing.Size(930, 416);
            this.groupBox_ThongTinNhanVien.TabIndex = 40;
            this.groupBox_ThongTinNhanVien.TabStop = false;
            this.groupBox_ThongTinNhanVien.Text = "Thông tin sản phẩm";
            // 
            // textBox_MaNSX
            // 
            this.textBox_MaNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_MaNSX.Location = new System.Drawing.Point(631, 35);
            this.textBox_MaNSX.Name = "textBox_MaNSX";
            this.textBox_MaNSX.Size = new System.Drawing.Size(270, 30);
            this.textBox_MaNSX.TabIndex = 39;
            // 
            // textBox_MaLoai
            // 
            this.textBox_MaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_MaLoai.Location = new System.Drawing.Point(631, 89);
            this.textBox_MaLoai.Name = "textBox_MaLoai";
            this.textBox_MaLoai.Size = new System.Drawing.Size(270, 30);
            this.textBox_MaLoai.TabIndex = 38;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 831);
            this.Controls.Add(this.groupBox_DanhSachSanPham);
            this.Controls.Add(this.groupBox_ThongTinNhanVien);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.groupBox_DanhSachSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.groupBox_ThongTinNhanVien.ResumeLayout(false);
            this.groupBox_ThongTinNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SoLuongKho;
        private System.Windows.Forms.Label label_MaNCC;
        private System.Windows.Forms.Label label_MaLoai;
        private System.Windows.Forms.Label label_MaNSX;
        private System.Windows.Forms.Label label_NuocSanXuat;
        private System.Windows.Forms.Label label_DonGia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_TenSanPham;
        private System.Windows.Forms.Label label_MaSanPham;
        private System.Windows.Forms.Button button_InBaoCaoSP;
        private System.Windows.Forms.Button btn_DeleteTextBoxSP;
        private System.Windows.Forms.Button button_XoaSP;
        private System.Windows.Forms.Button button_ChinhSuaSP;
        private System.Windows.Forms.Button button_ThemMoiSP;
        private System.Windows.Forms.TextBox textBox_SoLuongKho;
        private System.Windows.Forms.TextBox textBox_MaNCC;
        private System.Windows.Forms.TextBox textBox_NuocSanXuat;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.GroupBox groupBox_DanhSachSanPham;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.TextBox textBox_TenSanPham;
        private System.Windows.Forms.TextBox textBox_MaSanPham;
        private System.Windows.Forms.GroupBox groupBox_ThongTinNhanVien;
        private System.Windows.Forms.TextBox textBox_MaNSX;
        private System.Windows.Forms.TextBox textBox_MaLoai;
    }
}