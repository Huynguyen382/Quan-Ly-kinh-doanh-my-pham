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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HUYNGU;Initial Catalog=BaiTapLon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableHoaDon = new DataTable();

        // load data vào table khách hàng
        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hienHoaDon";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            tableHoaDon.Clear();
            adapter.Fill(tableHoaDon);
            dataGridView_HoaDon.DataSource = tableHoaDon;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void textBox_MaHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (textBox_MaHoaDon.Text.Length > 0)
            {
                button_ThemMoiHD.Enabled = true;
                button_ChinhSuaHD.Enabled = true;
                button_XoaHD.Enabled = true;
            }
            else
            {
                button_ThemMoiHD.Enabled = false;
                button_ChinhSuaHD.Enabled = false;
                button_XoaHD.Enabled = false;
            }
        }

        private void dataGridView_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaHoaDon.ReadOnly = true;
            int i;
            i = dataGridView_HoaDon.CurrentRow.Index;
            textBox_MaHoaDon.Text = dataGridView_HoaDon.Rows[i].Cells[0].Value.ToString();
            textBox_MaNhanVien.Text = dataGridView_HoaDon.Rows[i].Cells[1].Value.ToString();
            textBox_MaKhachHang.Text = dataGridView_HoaDon.Rows[i].Cells[2].Value.ToString();
            dateTimePicker_NgayLap.Text = dataGridView_HoaDon.Rows[i].Cells[3].Value.ToString();
            
        }

        private void button_XoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM tblHoaDon WHERE sSoHD = @mahd";
                command.Parameters.Add("@mahd", SqlDbType.VarChar, 20).Value = textBox_MaHoaDon.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void button_ThemMoiHD_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "themHoaDon";
                command.Parameters.Add("@sohd", SqlDbType.VarChar, 20).Value = textBox_MaHoaDon.Text;
                command.Parameters.Add("@manv", SqlDbType.VarChar, 20).Value = textBox_MaNhanVien.Text;
                command.Parameters.Add("@makh", SqlDbType.VarChar, 20).Value = textBox_MaKhachHang.Text;
                command.Parameters.Add("@ngaylap", SqlDbType.DateTime).Value = dateTimePicker_NgayLap.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void button_ChinhSuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "suaHoaDon";
                command.Parameters.Add("@sohd", SqlDbType.VarChar, 20).Value = textBox_MaHoaDon.Text;
                command.Parameters.Add("@manv", SqlDbType.VarChar, 20).Value = textBox_MaNhanVien.Text;
                command.Parameters.Add("@makh", SqlDbType.VarChar, 20).Value = textBox_MaKhachHang.Text;
                command.Parameters.Add("@ngaylap", SqlDbType.DateTime).Value = dateTimePicker_NgayLap.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void btn_DeleteTextBoxHD_Click(object sender, EventArgs e)
        {
            textBox_MaHoaDon.Clear();
            textBox_MaNhanVien.Clear();
            textBox_MaKhachHang.Clear();
            dateTimePicker_NgayLap.Value = DateTime.Now;
            textBox_MaHoaDon.ReadOnly = false;
        }
    }
}
