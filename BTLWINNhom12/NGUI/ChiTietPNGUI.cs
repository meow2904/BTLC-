using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWINNhom12
{
	public partial class ChiTietPNGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public ChiTietPNGUI()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChiTietPNGUI_Load(object sender, EventArgs e)
		{
			string hung = this.Tag.ToString();
			grid_hd.Rows.Clear();
			grid_ct.Rows.Clear();
			var sp = from b in db.HoaDonNhaps
					 where b.MaHDN.Contains(hung)
					 select new
					 {
						 b.MaHDN,
						 b.NgayNhap,
						 b.NhanVien.TenNV,
						 b.NhaCungCap.TenNCC,
					 };
			grid_hd.DataSource = sp;
			var huhu = from b in db.ChiTietNhaps
					 where b.MaHDN.Contains(hung)
					 select new
					 {
						 b.MaHDN,
						 b.MaSP,
						 b.SLNhap,
					 };
			grid_ct.DataSource = huhu;
		}
	}
}
