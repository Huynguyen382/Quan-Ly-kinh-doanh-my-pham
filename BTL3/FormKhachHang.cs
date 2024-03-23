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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HUYNGU;Initial Catalog=BaiTapLon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableKhachHang = new DataTable();
        DataTable tableGioiTinh = new DataTable();
        // load data vào table khách hàng
        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hienKhachHang";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            tableKhachHang.Clear();
            adapter.Fill(tableKhachHang);
            dataGridView_KhachHang.DataSource = tableKhachHang;
        }

        /*
        public void loadDataCombobox()
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "layGioiTinhKhachHang";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(tableGioiTinh);
            comboBox_GioiTinh.DataSource = tableGioiTinh;
        }
        */
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
           
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private void textBox_MaKhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaKhachHang.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_MaKhachHang, "Mã khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_MaKhachHang, null);
            }
        }

        private void textBox_TenKhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_TenKhachHang.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_TenKhachHang, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_TenKhachHang, null);
            }
        }

        private void textBox_MaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (textBox_MaKhachHang.Text.Length > 0)
            {
                button_ThemMoiKH.Enabled = true;
                button_ChinhSuaKH.Enabled = true;
                button_XoaKH.Enabled = true;
            }
            else
            {
                button_ThemMoiKH.Enabled = false;
                button_ChinhSuaKH.Enabled = false;
                button_XoaKH.Enabled = false;
            }    
        }

        private void dataGridView_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaKhachHang.ReadOnly = true;
            int i;
            i = dataGridView_KhachHang.CurrentRow.Index;
            textBox_MaKhachHang.Text = dataGridView_KhachHang.Rows[i].Cells[0].Value.ToString();
            textBox_TenKhachHang.Text = dataGridView_KhachHang.Rows[i].Cells[1].Value.ToString();
            textBox_DiaChi.Text = dataGridView_KhachHang.Rows[i].Cells[2].Value.ToString();
            dateTimePicker_NgaySinhKH.Text = dataGridView_KhachHang.Rows[i].Cells[3].Value.ToString();
            textBox_SDTKH.Text = dataGridView_KhachHang.Rows[i].Cells[4].Value.ToString();
            comboBox_GioiTinh.Text = dataGridView_KhachHang.Rows[i].Cells[5].Value.ToString();
            textBox_TongTien.Text = dataGridView_KhachHang.Rows[i].Cells[6].Value.ToString();
        }

        private void button_ThemMoiKH_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "themKhachHang";
                command.Parameters.Add("@maKH", SqlDbType.VarChar, 20).Value = textBox_MaKhachHang.Text;
                command.Parameters.Add("@tenKH", SqlDbType.NVarChar, 50).Value = textBox_TenKhachHang.Text;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50).Value = textBox_DiaChi.Text;
                command.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = dateTimePicker_NgaySinhKH.Value.ToString("yyyy/MM/d");
                command.Parameters.Add("@sdt", SqlDbType.VarChar, 20).Value = textBox_SDTKH.Text;
                command.Parameters.Add("@gioiTinh", SqlDbType.NVarChar, 10).Value = comboBox_GioiTinh.Text;
                command.Parameters.Add("@tongTien", SqlDbType.Float).Value = textBox_TongTien.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void button_ChinhSuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "suaKhachHang";
                command.Parameters.Add("@maKH", SqlDbType.VarChar, 20).Value = textBox_MaKhachHang.Text;
                command.Parameters.Add("@tenKH", SqlDbType.NVarChar, 50).Value = textBox_TenKhachHang.Text;
                command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 50).Value = textBox_DiaChi.Text;
                command.Parameters.Add("@ngaySinh", SqlDbType.DateTime).Value = dateTimePicker_NgaySinhKH.Value.ToString("yyyy/MM/d");
                command.Parameters.Add("@sdt", SqlDbType.VarChar, 20).Value = textBox_SDTKH.Text;
                command.Parameters.Add("@gioiTinh", SqlDbType.NVarChar, 10).Value = comboBox_GioiTinh.Text;
                command.Parameters.Add("@tongTien", SqlDbType.Float).Value = textBox_TongTien.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void button_XoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "xoaKhachHang";
                command.Parameters.Add("@maKH", SqlDbType.VarChar, 20).Value = textBox_MaKhachHang.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void btn_DeleteTextBoxSP_Click(object sender, EventArgs e)
        {
            textBox_MaKhachHang.Clear();
            textBox_TenKhachHang.Clear();
            textBox_DiaChi.Clear();
            dateTimePicker_NgaySinhKH.Value = DateTime.Now;
            textBox_SDTKH.Clear();
            comboBox_GioiTinh.SelectedIndex = 0;
            textBox_TongTien.Clear();
            textBox_MaKhachHang.ReadOnly = false;
        }
    }
}
