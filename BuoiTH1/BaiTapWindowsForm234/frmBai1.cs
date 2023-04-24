using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm2
{
    public partial class frmBai1 : Form
    {
        List<ThietBi> danhSachThietBi = new List<ThietBi>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            string maThietBi = txtMaThietBi.Text;
            string tenThietBi = txtTenThietBi.Text;
            string nuocSanXuat = txtNuocSanXuat.Text;
            float donGia = float.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            ThietBi newThietBi = new ThietBi(maThietBi,tenThietBi,nuocSanXuat,donGia,soLuong);
            danhSachThietBi.Add(newThietBi);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string maThietBi = txtMaThietBi.Text;
            string tenThietBi = txtTenThietBi.Text;
            string nuocSanXuat = txtNuocSanXuat.Text;
            float donGia = float.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            ThietBi thietBiMoi = new ThietBi(maThietBi, tenThietBi, nuocSanXuat, donGia, soLuong);
            lblSoTien.Text = thietBiMoi.ThanhTien();
        }

        private void btnHienThongTinThietBi_Click(object sender, EventArgs e)
        {
            foreach (ThietBi item in danhSachThietBi)
            {
                if (txtTimMaThietBi.Text == item.MaThietBi)
                {
                    txtMaThietBi.Text = item.MaThietBi;
                    txtTenThietBi.Text = item.TenThietBi;
                    txtNuocSanXuat.Text = item.NuocSanXuat;
                    txtDonGia.Text = item.DonGia.ToString();
                    txtSoLuong.Text = item.SoLuong.ToString();
                }
            }
        }
    }
}
