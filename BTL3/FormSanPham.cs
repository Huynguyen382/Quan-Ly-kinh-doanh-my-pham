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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=HUYNGU;Initial Catalog=BaiTapLon;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableSanPham = new DataTable();

        // load data vào table sản phẩm
        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "hienSanPham";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            tableSanPham.Clear();
            adapter.Fill(tableSanPham);
            dataGridView_SanPham.DataSource = tableSanPham;
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private void textBox_MaSanPham_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaSanPham.Text))
            {
            e.Cancel = true;
            errorProvider.SetError(textBox_MaSanPham, "Mã sản phẩm không được để trống!");
            }
            else
            {
            e.Cancel = false;
            errorProvider.SetError(textBox_MaSanPham, null);
            }
        }

        private void textBox_TenSanPham_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_TenSanPham.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox_TenSanPham, "Mã sản phẩm không được để trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox_TenSanPham, null);
            }
        }

        private void textBox_MaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (textBox_MaSanPham.Text.Length > 0)
            {
                button_ThemMoiSP.Enabled = true;
                button_ChinhSuaSP.Enabled = true;
                button_XoaSP.Enabled = true;
            }
            else
            {
                button_ThemMoiSP.Enabled = false;
                button_ChinhSuaSP.Enabled = false;
                button_XoaSP.Enabled = false;
            }
        }

        
        private void dataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaSanPham.ReadOnly = true;
            int i;
            i = dataGridView_SanPham.CurrentRow.Index;
            textBox_MaSanPham.Text = dataGridView_SanPham.Rows[i].Cells[0].Value.ToString();
            textBox_TenSanPham.Text = dataGridView_SanPham.Rows[i].Cells[1].Value.ToString();
            textBox_DonGia.Text = dataGridView_SanPham.Rows[i].Cells[2].Value.ToString();
            textBox_NuocSanXuat.Text = dataGridView_SanPham.Rows[i].Cells[3].Value.ToString();
            textBox_MaNSX.Text = dataGridView_SanPham.Rows[i].Cells[4].Value.ToString();
            textBox_MaLoai.Text = dataGridView_SanPham.Rows[i].Cells[5].Value.ToString();
            textBox_MaNCC.Text = dataGridView_SanPham.Rows[i].Cells[6].Value.ToString();
            textBox_SoLuongKho.Text = dataGridView_SanPham.Rows[i].Cells[7].Value.ToString();
        }

        private void button_ThemMoiSP_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "themSanPham";
                command.Parameters.Add("@maSP", SqlDbType.VarChar, 50).Value = textBox_MaSanPham.Text;
                command.Parameters.Add("@tenSP", SqlDbType.NVarChar, 50).Value = textBox_TenSanPham.Text;
                command.Parameters.Add("@donGia", SqlDbType.Float).Value = textBox_DonGia.Text;
                command.Parameters.Add("@nuocSanXuat", SqlDbType.NVarChar, 30).Value = textBox_NuocSanXuat.Text;
                command.Parameters.Add("@maNSX", SqlDbType.VarChar, 20).Value = textBox_MaNSX.Text;
                command.Parameters.Add("@maLoai", SqlDbType.VarChar, 20).Value = textBox_MaLoai.Text;
                command.Parameters.Add("@maNCC", SqlDbType.VarChar, 20).Value = textBox_MaNCC.Text;
                command.Parameters.Add("@soLuongKho", SqlDbType.Float).Value = textBox_SoLuongKho.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void button_ChinhSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "suaSanPham";
                command.Parameters.Add("@maSP", SqlDbType.VarChar, 50).Value = textBox_MaSanPham.Text;
                command.Parameters.Add("@tenSP", SqlDbType.NVarChar, 50).Value = textBox_TenSanPham.Text;
                command.Parameters.Add("@donGia", SqlDbType.Float).Value = textBox_DonGia.Text;
                command.Parameters.Add("@nuocSanXuat", SqlDbType.NVarChar, 30).Value = textBox_NuocSanXuat.Text;
                command.Parameters.Add("@maNSX", SqlDbType.VarChar, 20).Value = textBox_MaNSX.Text;
                command.Parameters.Add("@maLoai", SqlDbType.VarChar, 20).Value = textBox_MaLoai.Text;
                command.Parameters.Add("@maNCC", SqlDbType.VarChar, 20).Value = textBox_MaNCC.Text;
                command.Parameters.Add("@soLuongKho", SqlDbType.Float).Value = textBox_SoLuongKho.Text;
                command.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void button_XoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "suaSanPham";
                command.Parameters.Add("@maSP", SqlDbType.VarChar, 50).Value = textBox_MaSanPham.Text;
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

        }
    }
}
