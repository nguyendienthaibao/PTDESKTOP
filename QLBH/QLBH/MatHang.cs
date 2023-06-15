using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH
{
	internal class MatHang
	{
		public int MaMatHang { get; set; }
		public string TenMatHang { get; set; }
		public int LoaiMatHang{get;set;}
		public int SoLuongTon { get; set; }
		public int DonGia { get; set; }

		public MatHang(DataRow row)
		{
			MaMatHang = Convert.ToInt32(row ["MaMatHang"]);
			TenMatHang = row["TenMatHang"].ToString();
			LoaiMatHang = Convert.ToInt32(row["LoaiMatHang"]);
			SoLuongTon = Convert.ToInt32(row["SoLuongTon"]);
			DonGia = Convert.ToInt32(row["DonGia"]);
		}
	}
}
