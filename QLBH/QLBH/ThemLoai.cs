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

namespace QLBH
{
	public partial class ThemLoai : Form
	{
		public ThemLoai()
		{
			InitializeComponent();
		}

		private void btnThemLoai_Click(object sender, EventArgs e)
		{
			var tenMatHang = txtTenLoai.Text;
			if (tenMatHang == "")
				MessageBox.Show("Chưa nhập tên loại, vui lòng nhập lại ");
			else
			{
				var connString = Utilities.connectionString;
				var conn = new SqlConnection(connString);

				try
				{
					conn.Open();

					var command = conn.CreateCommand();
					command.CommandText = "ThemLoaiMatHang";
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@TenLoai", tenMatHang);

					command.ExecuteNonQuery();

					MessageBox.Show("Thêm mặt hàng thành công!");
					txtTenLoai.ResetText();
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
		}
	}
}
