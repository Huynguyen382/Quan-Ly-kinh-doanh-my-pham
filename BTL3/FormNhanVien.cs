using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL3
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HUYNGU;Initial Catalog=BaiTapLon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableNhanVien = new DataTable();

        // load data vào table nhân viên
        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hienNhanVien";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            tableNhanVien.Clear();
            adapter.Fill(tableNhanVien);
            dataGridView_NhanVien.DataSource = tableNhanVien;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private void textBox_MaNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaNhanVien.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_MaNhanVien, "Mã nhân viên không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_MaNhanVien, null);
            }
        }

        private void textBox_TenNhanVien_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_TenNhanVien.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_TenNhanVien, "Tên nhân viên không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_TenNhanVien, null);
            }
        }

        // validate CCCD
        // Check xem số CCCD có toàn số không
        public bool IsIDNumber(string strValue)
        {
            foreach (Char ch in strValue)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox_CCCD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_CCCD.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_CCCD, "Số căn cước công dân không được để trống!");
            }
            else
            {
                if (!IsIDNumber(textBox_CCCD.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBox_CCCD, "Số căn cước công dân không đúng định dạng");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBox_CCCD, null);

                }
            }
        }

        // textChanged mã NV (nếu mã nhân viên được nhập vào thì ô thêm mới, sửa và xóa sáng lên)
        private void textBox_MaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (textBox_MaNhanVien.Text.Length > 0)
            {
                button_ThemMoi.Enabled = true;
                button_ChinhSua.Enabled = true;
                button_Xoa.Enabled = true;
            }
            else
            {
                button_ThemMoi.Enabled = false;
                button_ChinhSua.Enabled = false;
                button_Xoa.Enabled = false;
            }
        }

        // đóng form bằng nút
        private void button_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // đóng form bằng dấu x
        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        // hàm ấn vào thông tin của một người thì tất cả các textbox hiện thông tin
        private void dataGridView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaNhanVien.ReadOnly = true;
            int i;
            i = dataGridView_NhanVien.CurrentRow.Index;
            textBox_MaNhanVien.Text = dataGridView_NhanVien.Rows[i].Cells[0].Value.ToString();
            textBox_TenNhanVien.Text = dataGridView_NhanVien.Rows[i].Cells[1].Value.ToString();
            textBox_DiaChi.Text = dataGridView_NhanVien.Rows[i].Cells[2].Value.ToString();
            dateTimePicker_NgaySinh.Text = dataGridView_NhanVien.Rows[i].Cells[3].Value.ToString();
            dateTimePicker_NgayVaoLam.Text = dataGridView_NhanVien.Rows[i].Cells[4].Value.ToString();
            textBox_CCCD.Text = dataGridView_NhanVien.Rows[i].Cells[5].Value.ToString();
            textBox_LuongCoBan.Text = dataGridView_NhanVien.Rows[i].Cells[6].Value.ToString();
            textBox_PhuCap.Text = dataGridView_NhanVien.Rows[i].Cells[7].Value.ToString();
        }

        // Thêm vào bảng nhân viên
        private void button_ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "themNhanVien";
                command.Parameters.Add("@manv", SqlDbType.VarChar, 20).Value = textBox_MaNhanVien.Text;
                command.Parameters.Add("@tennv", SqlDbType.NVarChar, 50).Value = textBox_TenNhanVien.Text;
                command.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = textBox_DiaChi.Text;
                command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = dateTimePicker_NgaySinh.Value.ToString("yyyy/MM/d");
                command.Parameters.Add("@ngayvaolam", SqlDbType.DateTime).Value = dateTimePicker_NgayVaoLam.Value.ToString("yyyy/MM/d");
                command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = textBox_CCCD.Text;
                command.Parameters.Add("luongcoban", SqlDbType.Float).Value = textBox_LuongCoBan.Text;
                command.Parameters.Add("@phucap", SqlDbType.Float).Value = textBox_PhuCap.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        // Xóa khỏi bảng nhân viên
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "xoaNhanVien";
                command.Parameters.Add("@manv", SqlDbType.VarChar, 20).Value = textBox_MaNhanVien.Text;

                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }


        // Chỉnh sửa
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "suaNhanVien";
                command.Parameters.Add("@manv", SqlDbType.VarChar, 20).Value = textBox_MaNhanVien.Text;
                command.Parameters.Add("@tennv", SqlDbType.NVarChar, 50).Value = textBox_TenNhanVien.Text;
                command.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = textBox_DiaChi.Text;
                command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = dateTimePicker_NgaySinh.Value.ToString("yyyy/MM/d");
                command.Parameters.Add("@ngayvaolam", SqlDbType.DateTime).Value = dateTimePicker_NgayVaoLam.Value.ToString("yyyy/MM/d");
                command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = textBox_CCCD.Text;
                command.Parameters.Add("luongcoban", SqlDbType.Float).Value = textBox_LuongCoBan.Text;
                command.Parameters.Add("@phucap", SqlDbType.Float).Value = textBox_PhuCap.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void btn_DeleteTextBox_Click(object sender, EventArgs e)
        {
            textBox_MaNhanVien.Clear();
            textBox_TenNhanVien.Clear();
            textBox_DiaChi.Clear();
            textBox_CCCD.Clear();
            dateTimePicker_NgaySinh.Value = DateTime.Now;
            dateTimePicker_NgayVaoLam.Value = DateTime.Now;
            textBox_LuongCoBan.Clear();
            textBox_PhuCap.Clear();
            textBox_MaNhanVien.ReadOnly = false;
        }

        private void button_InBaoCao_Click(object sender, EventArgs e)
        {
            command.CommandText = "hienNhanVien";
            command.Parameters.Clear();
            command.Parameters.Add("@manv", SqlDbType.VarChar, 20).Value = textBox_MaNhanVien.Text;
            command.Parameters.Add("@tennv", SqlDbType.NVarChar, 50).Value = textBox_TenNhanVien.Text;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = textBox_DiaChi.Text;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = dateTimePicker_NgaySinh.Value.ToString("yyyy/MM/d");
            command.Parameters.Add("@ngayvaolam", SqlDbType.DateTime).Value = dateTimePicker_NgayVaoLam.Value.ToString("yyyy/MM/d");
            command.Parameters.Add("@cccd", SqlDbType.VarChar).Value = textBox_CCCD.Text;
            command.Parameters.Add("luongcoban", SqlDbType.Float).Value = textBox_LuongCoBan.Text;
            command.Parameters.Add("@phucap", SqlDbType.Float).Value = textBox_PhuCap.Text;

            ReportNhanVien baocao = new ReportNhanVien();
            baocao.SetDataSource(tableNhanVien);
            // Hiển thị báo cáo
            FormInBaoCao frmInBaoCao = new FormInBaoCao();
            frmInBaoCao.crystalReportViewer1.ReportSource = baocao;
            frmInBaoCao.ShowDialog();
        }
    }
}
