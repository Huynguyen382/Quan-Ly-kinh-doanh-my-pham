
namespace BTL3
{
    partial class FormNhanVien
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
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_DeleteTextBox = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_ChinhSua = new System.Windows.Forms.Button();
            this.button_ThemMoi = new System.Windows.Forms.Button();
            this.textBox_PhuCap = new System.Windows.Forms.TextBox();
            this.textBox_LuongCoBan = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.textBox_CCCD = new System.Windows.Forms.TextBox();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox_TenNhanVien = new System.Windows.Forms.TextBox();
            this.textBox_MaNhanVien = new System.Windows.Forms.TextBox();
            this.button_InBaoCao = new System.Windows.Forms.Button();
            this.label_MaNhanVien = new System.Windows.Forms.Label();
            this.label_TenNhanVien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_CCCD = new System.Windows.Forms.Label();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_LuongCoBan = new System.Windows.Forms.Label();
            this.label_PhuCap = new System.Windows.Forms.Label();
            this.groupBox_ThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.groupBox_DanhSachNhanVien = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.groupBox_ThongTinNhanVien.SuspendLayout();
            this.groupBox_DanhSachNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(34, 41);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(867, 270);
            this.dataGridView_NhanVien.TabIndex = 27;
            this.dataGridView_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NhanVien_CellContentClick);
            // 
            // btn_DeleteTextBox
            // 
            this.btn_DeleteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTextBox.Location = new System.Drawing.Point(34, 337);
            this.btn_DeleteTextBox.Name = "btn_DeleteTextBox";
            this.btn_DeleteTextBox.Size = new System.Drawing.Size(407, 50);
            this.btn_DeleteTextBox.TabIndex = 25;
            this.btn_DeleteTextBox.Text = "Đặt lại về mặc định";
            this.btn_DeleteTextBox.UseVisualStyleBackColor = true;
            this.btn_DeleteTextBox.Click += new System.EventHandler(this.btn_DeleteTextBox_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Enabled = false;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(321, 264);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(120, 50);
            this.button_Xoa.TabIndex = 24;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_ChinhSua
            // 
            this.button_ChinhSua.Enabled = false;
            this.button_ChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSua.Location = new System.Drawing.Point(181, 263);
            this.button_ChinhSua.Name = "button_ChinhSua";
            this.button_ChinhSua.Size = new System.Drawing.Size(120, 50);
            this.button_ChinhSua.TabIndex = 23;
            this.button_ChinhSua.Text = "Chỉnh sửa";
            this.button_ChinhSua.UseVisualStyleBackColor = true;
            this.button_ChinhSua.Click += new System.EventHandler(this.button_ChinhSua_Click);
            // 
            // button_ThemMoi
            // 
            this.button_ThemMoi.Enabled = false;
            this.button_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemMoi.Location = new System.Drawing.Point(34, 262);
            this.button_ThemMoi.Name = "button_ThemMoi";
            this.button_ThemMoi.Size = new System.Drawing.Size(120, 50);
            this.button_ThemMoi.TabIndex = 22;
            this.button_ThemMoi.Text = "Thêm mới";
            this.button_ThemMoi.UseVisualStyleBackColor = true;
            this.button_ThemMoi.Click += new System.EventHandler(this.button_ThemMoi_Click);
            // 
            // textBox_PhuCap
            // 
            this.textBox_PhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_PhuCap.Location = new System.Drawing.Point(631, 202);
            this.textBox_PhuCap.Name = "textBox_PhuCap";
            this.textBox_PhuCap.Size = new System.Drawing.Size(270, 30);
            this.textBox_PhuCap.TabIndex = 21;
            // 
            // textBox_LuongCoBan
            // 
            this.textBox_LuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_LuongCoBan.Location = new System.Drawing.Point(631, 147);
            this.textBox_LuongCoBan.Name = "textBox_LuongCoBan";
            this.textBox_LuongCoBan.Size = new System.Drawing.Size(270, 30);
            this.textBox_LuongCoBan.TabIndex = 20;
            // 
            // dateTimePicker_NgayVaoLam
            // 
            this.dateTimePicker_NgayVaoLam.Location = new System.Drawing.Point(631, 96);
            this.dateTimePicker_NgayVaoLam.Name = "dateTimePicker_NgayVaoLam";
            this.dateTimePicker_NgayVaoLam.Size = new System.Drawing.Size(270, 24);
            this.dateTimePicker_NgayVaoLam.TabIndex = 19;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(631, 41);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(270, 24);
            this.dateTimePicker_NgaySinh.TabIndex = 18;
            // 
            // textBox_CCCD
            // 
            this.textBox_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_CCCD.Location = new System.Drawing.Point(171, 202);
            this.textBox_CCCD.Name = "textBox_CCCD";
            this.textBox_CCCD.Size = new System.Drawing.Size(270, 30);
            this.textBox_CCCD.TabIndex = 17;
            this.textBox_CCCD.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_CCCD_Validating);
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_DiaChi.Location = new System.Drawing.Point(171, 147);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(270, 30);
            this.textBox_DiaChi.TabIndex = 16;
            // 
            // textBox_TenNhanVien
            // 
            this.textBox_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_TenNhanVien.Location = new System.Drawing.Point(171, 90);
            this.textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            this.textBox_TenNhanVien.Size = new System.Drawing.Size(270, 30);
            this.textBox_TenNhanVien.TabIndex = 15;
            this.textBox_TenNhanVien.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_TenNhanVien_Validating);
            // 
            // textBox_MaNhanVien
            // 
            this.textBox_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_MaNhanVien.Location = new System.Drawing.Point(171, 35);
            this.textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            this.textBox_MaNhanVien.Size = new System.Drawing.Size(270, 30);
            this.textBox_MaNhanVien.TabIndex = 14;
            this.textBox_MaNhanVien.TextChanged += new System.EventHandler(this.textBox_MaNhanVien_TextChanged);
            this.textBox_MaNhanVien.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_MaNhanVien_Validating);
            // 
            // button_InBaoCao
            // 
            this.button_InBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InBaoCao.Location = new System.Drawing.Point(731, 337);
            this.button_InBaoCao.Name = "button_InBaoCao";
            this.button_InBaoCao.Size = new System.Drawing.Size(170, 50);
            this.button_InBaoCao.TabIndex = 28;
            this.button_InBaoCao.Text = "In báo cáo";
            this.button_InBaoCao.UseVisualStyleBackColor = true;
            this.button_InBaoCao.Click += new System.EventHandler(this.button_InBaoCao_Click);
            // 
            // label_MaNhanVien
            // 
            this.label_MaNhanVien.AutoSize = true;
            this.label_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaNhanVien.Location = new System.Drawing.Point(30, 42);
            this.label_MaNhanVien.Name = "label_MaNhanVien";
            this.label_MaNhanVien.Size = new System.Drawing.Size(115, 20);
            this.label_MaNhanVien.TabIndex = 29;
            this.label_MaNhanVien.Text = "Mã nhân viên";
            // 
            // label_TenNhanVien
            // 
            this.label_TenNhanVien.AutoSize = true;
            this.label_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenNhanVien.Location = new System.Drawing.Point(30, 96);
            this.label_TenNhanVien.Name = "label_TenNhanVien";
            this.label_TenNhanVien.Size = new System.Drawing.Size(121, 20);
            this.label_TenNhanVien.TabIndex = 30;
            this.label_TenNhanVien.Text = "Tên nhân viên";
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
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaChi.Location = new System.Drawing.Point(30, 154);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(64, 20);
            this.label_DiaChi.TabIndex = 32;
            this.label_DiaChi.Text = "Địa chỉ";
            // 
            // label_CCCD
            // 
            this.label_CCCD.AutoSize = true;
            this.label_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CCCD.Location = new System.Drawing.Point(30, 209);
            this.label_CCCD.Name = "label_CCCD";
            this.label_CCCD.Size = new System.Drawing.Size(58, 20);
            this.label_CCCD.TabIndex = 33;
            this.label_CCCD.Text = "CCCD";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgaySinh.Location = new System.Drawing.Point(501, 42);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(87, 20);
            this.label_NgaySinh.TabIndex = 34;
            this.label_NgaySinh.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ngày vào làm";
            // 
            // label_LuongCoBan
            // 
            this.label_LuongCoBan.AutoSize = true;
            this.label_LuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LuongCoBan.Location = new System.Drawing.Point(501, 154);
            this.label_LuongCoBan.Name = "label_LuongCoBan";
            this.label_LuongCoBan.Size = new System.Drawing.Size(118, 20);
            this.label_LuongCoBan.TabIndex = 36;
            this.label_LuongCoBan.Text = "Lương cơ bản";
            // 
            // label_PhuCap
            // 
            this.label_PhuCap.AutoSize = true;
            this.label_PhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhuCap.Location = new System.Drawing.Point(501, 209);
            this.label_PhuCap.Name = "label_PhuCap";
            this.label_PhuCap.Size = new System.Drawing.Size(74, 20);
            this.label_PhuCap.TabIndex = 37;
            this.label_PhuCap.Text = "Phụ cấp";
            // 
            // groupBox_ThongTinNhanVien
            // 
            this.groupBox_ThongTinNhanVien.AutoSize = true;
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_PhuCap);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_LuongCoBan);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label1);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_NgaySinh);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_CCCD);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_DiaChi);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button1);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_TenNhanVien);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.label_MaNhanVien);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_InBaoCao);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.btn_DeleteTextBox);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_Xoa);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_ChinhSua);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.button_ThemMoi);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_PhuCap);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_LuongCoBan);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.dateTimePicker_NgayVaoLam);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.dateTimePicker_NgaySinh);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_CCCD);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_DiaChi);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_TenNhanVien);
            this.groupBox_ThongTinNhanVien.Controls.Add(this.textBox_MaNhanVien);
            this.groupBox_ThongTinNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_ThongTinNhanVien.Location = new System.Drawing.Point(26, 21);
            this.groupBox_ThongTinNhanVien.Name = "groupBox_ThongTinNhanVien";
            this.groupBox_ThongTinNhanVien.Size = new System.Drawing.Size(930, 416);
            this.groupBox_ThongTinNhanVien.TabIndex = 38;
            this.groupBox_ThongTinNhanVien.TabStop = false;
            this.groupBox_ThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // groupBox_DanhSachNhanVien
            // 
            this.groupBox_DanhSachNhanVien.AutoSize = true;
            this.groupBox_DanhSachNhanVien.Controls.Add(this.dataGridView_NhanVien);
            this.groupBox_DanhSachNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_DanhSachNhanVien.Location = new System.Drawing.Point(26, 458);
            this.groupBox_DanhSachNhanVien.Name = "groupBox_DanhSachNhanVien";
            this.groupBox_DanhSachNhanVien.Size = new System.Drawing.Size(929, 343);
            this.groupBox_DanhSachNhanVien.TabIndex = 39;
            this.groupBox_DanhSachNhanVien.TabStop = false;
            this.groupBox_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 831);
            this.Controls.Add(this.groupBox_DanhSachNhanVien);
            this.Controls.Add(this.groupBox_ThongTinNhanVien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.groupBox_ThongTinNhanVien.ResumeLayout(false);
            this.groupBox_ThongTinNhanVien.PerformLayout();
            this.groupBox_DanhSachNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_NhanVien;
        private System.Windows.Forms.Button btn_DeleteTextBox;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_ChinhSua;
        private System.Windows.Forms.Button button_ThemMoi;
        private System.Windows.Forms.TextBox textBox_PhuCap;
        private System.Windows.Forms.TextBox textBox_LuongCoBan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayVaoLam;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.TextBox textBox_CCCD;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.TextBox textBox_TenNhanVien;
        private System.Windows.Forms.TextBox textBox_MaNhanVien;
        private System.Windows.Forms.Button button_InBaoCao;
        private System.Windows.Forms.Label label_MaNhanVien;
        private System.Windows.Forms.Label label_TenNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_CCCD;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_LuongCoBan;
        private System.Windows.Forms.Label label_PhuCap;
        private System.Windows.Forms.GroupBox groupBox_ThongTinNhanVien;
        private System.Windows.Forms.GroupBox groupBox_DanhSachNhanVien;
    }
}