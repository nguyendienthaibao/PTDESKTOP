using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
	internal class LoaiMatHang
	{
		public int MaLoai { get; set; }
		public string TenLoai { get; set; }

		public LoaiMatHang(DataRow row)
		{
			MaLoai = Convert.ToInt32(row["MaLoai"]);
			TenLoai = row["TenLoai"].ToString();
		}
	}
}
