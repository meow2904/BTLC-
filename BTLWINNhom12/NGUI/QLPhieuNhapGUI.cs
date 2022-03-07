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
	public partial class QLPhieuNhapGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public QLPhieuNhapGUI()
		{
			InitializeComponent();
		}

		private void QLPhieuNhapGUI_Load(object sender, EventArgs e)
		{
			hienthi();
		}

		private void hienthi()
		{
			dataGridView1.Rows.Clear();
			var pn = from b in db.HoaDonNhaps
					 select new
					 {
						 b.MaHDN,
						 b.NgayNhap,
						 b.NhanVien.TenNV,
						 b.NhaCungCap.TenNCC

					 };
			foreach (var item in pn)
			{
				DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
				dongmoi.Cells[0].Value = item.MaHDN;
				dongmoi.Cells[1].Value = item.NgayNhap;
				dongmoi.Cells[2].Value = item.TenNV;
				dongmoi.Cells[3].Value = item.TenNCC;
				dongmoi.Cells[4].Value = "Chi tiết";
				dongmoi.Cells[5].Value = "Xóa";
				dataGridView1.Rows.Add(dongmoi);
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			PhieuNhapGUI myform = new PhieuNhapGUI();
			myform.ShowDialog();
		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_all_Click(object sender, EventArgs e)
		{
			hienthi();
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			var sp = from b in db.HoaDonNhaps
					 where b.MaHDN.Contains(txt_maphieu.Text)
					 select new
					 {
						 b.MaHDN,
						 b.NgayNhap,
						 b.NhanVien.TenNV,
						 b.NhaCungCap.TenNCC

					 };
			if (sp.Count() == 0) MessageBox.Show("Không thấy phiếu có mã này " + txt_maphieu.Text);
			else
			{
				foreach (var item in sp)
				{
					DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
					dongmoi.Cells[0].Value = item.MaHDN;
					dongmoi.Cells[1].Value = item.NgayNhap;
					dongmoi.Cells[2].Value = item.TenNV;
					dongmoi.Cells[3].Value = item.TenNCC;
					dongmoi.Cells[4].Value = "Chi tiết";
					dongmoi.Cells[5].Value = "Xóa";
					dataGridView1.Rows.Add(dongmoi);
				}
			}	
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string maphieunhap = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				HoaDonNhap hdn = db.HoaDonNhaps.SingleOrDefault(p => p.MaHDN == maphieunhap);
				if (e.ColumnIndex == 5)
				{
					DialogResult a = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
					if (a == DialogResult.Yes)
					{
						db.HoaDonNhaps.DeleteOnSubmit(hdn);
						db.SubmitChanges();
						hienthi();
					}
				}
				else if (e.ColumnIndex == 4)
				{
					ChiTietPNGUI myform = new ChiTietPNGUI();
					myform.Tag = maphieunhap;
					myform.ShowDialog();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể xóa hóa đơn, vui lòng liên hệ hoặc kiểm tra lại");
				
			}
		}
	}
}
