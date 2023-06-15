using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLBH
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			LayDanhSachLoaiMH();
			LayDSMH();
		}
		public void LayDanhSachLoaiMH()
		{
			var connString = Utilities.connectionString;
			var conn = new SqlConnection(connString);

			var command = conn.CreateCommand();
			command.CommandText = "SELECT * FROM LoaiMatHang";

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable();

			conn.Open();
			adapter.Fill(table);

			conn.Close();
			conn.Dispose();

			cbbLoaiMH.DisplayMember = "TenLoai";
			cbbLoaiMH.ValueMember = "MaLoai";
			cbbLoaiMH.DataSource = table;

		}
		
		public void LayDSMH()
		{
			var connString = Utilities.connectionString;
			var conn = new SqlConnection(connString);

			var command = conn.CreateCommand();
			command.CommandText = "SELECT MatHang.MaMatHang, MatHang.TenMatHang, LoaiMatHang.TenLoai, MatHang.SoLuongTon, MatHang.DonGia FROM MatHang JOIN LoaiMatHang ON MatHang.LoaiMatHang = LoaiMatHang.MaLoai";

			var adapter = new SqlDataAdapter(command);
			var table = new DataTable();

			conn.Open();
			adapter.Fill(table);

			conn.Close();
			conn.Dispose();

			dgvDSMatHang.DataSource = table;
		}


		private void dgvDSMatHang_MouseClick(object sender, MouseEventArgs e)
		{
			if (dgvDSMatHang.SelectedRows.Count > 0)
			{
				var hangDaChon = dgvDSMatHang.SelectedRows[0];
				txtMaMH.Text = hangDaChon.Cells[0].Value.ToString();
				txtTenMH.Text = hangDaChon.Cells[1].Value.ToString();
				cbbLoaiMH.Text = hangDaChon.Cells[2].Value.ToString();
				dupSoLuongTon.Text = hangDaChon.Cells[3].Value.ToString();
				dupDonGia.Text = hangDaChon.Cells[3].Value.ToString();
			}
		}
		public void ThemMatHang(string tenMatHang, int loaiMatHang, int soLuongTon, int donGia)
		{
			
			var connString = Utilities.connectionString;
			var conn = new SqlConnection(connString);

			try
			{
				conn.Open();

				var command = conn.CreateCommand();
				command.CommandText = "ThemMatHang";
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@TenMatHang", tenMatHang);
				command.Parameters.AddWithValue("@LoaiMatHang", loaiMatHang);
				command.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
				command.Parameters.AddWithValue("@DonGia", donGia);

				command.ExecuteNonQuery();

				LayDSMH();

				MessageBox.Show("Thêm mặt hàng thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}


		public void CapNhatMatHang(int maMatHang, string tenMatHang, int loaiMatHang, int soLuongTon, int donGia)
		{
			
			var connString = Utilities.connectionString;
			var conn = new SqlConnection(connString);

			try
			{
				conn.Open();

				var command = conn.CreateCommand();
				command.CommandText = "CapNhatMatHang";
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@MaMatHang", maMatHang);
				command.Parameters.AddWithValue("@TenMatHang", tenMatHang);
				command.Parameters.AddWithValue("@LoaiMatHang", loaiMatHang);
				command.Parameters.AddWithValue("@SoLuongTon", soLuongTon);
				command.Parameters.AddWithValue("@DonGia", donGia);

				command.ExecuteNonQuery();

				LayDSMH();

				MessageBox.Show("Cập nhật mặt hàng thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtTenMH.Text == "" || cbbLoaiMH.Text == "" || dupSoLuongTon.Text ==""|| dupDonGia.Text == "")
				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			else
			{
				var tenMatHang = txtTenMH.Text;
				var loaiMatHang = Convert.ToInt32(cbbLoaiMH.SelectedValue);
				var soLuongTon = Convert.ToInt32(dupSoLuongTon.Text);
				var donGia = Convert.ToInt32(dupDonGia.Text);
				ThemMatHang(tenMatHang, loaiMatHang, soLuongTon, donGia); 
			}

		}

		private void dupSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '-')
			{
				e.Handled = true;
			}
		}

		private void dupDonGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '-')
			{
				e.Handled = true;
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (txtTenMH.Text == "" || cbbLoaiMH.Text == "" || dupSoLuongTon.Text == "" || dupDonGia.Text == "")
				MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
			else
			{
				var maMatHang = Convert.ToInt32(txtMaMH.Text);
				var tenMatHang = txtTenMH.Text;
				var loaiMatHang = Convert.ToInt32(cbbLoaiMH.SelectedValue);
				var soLuongTon = Convert.ToInt32(dupSoLuongTon.Text);
				var donGia = Convert.ToInt32(dupDonGia.Text);
				CapNhatMatHang(maMatHang, tenMatHang, loaiMatHang, soLuongTon, donGia);
			}
		}

		private void btnThemLoai_Click(object sender, EventArgs e)
		{
			ThemLoai themLoai = new ThemLoai();
			themLoai.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
			themLoai.Show(this);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cbbLoaiMH.SelectedIndex;
			cbbLoaiMH.SelectedIndex = -1;
			cbbLoaiMH.SelectedIndex = index;
			this.LayDanhSachLoaiMH();
		}

        private void cbbLoaiMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
