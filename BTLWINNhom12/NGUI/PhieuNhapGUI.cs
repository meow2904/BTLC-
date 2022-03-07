using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BTLWINNhom12
{
	public partial class PhieuNhapGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();

		public PhieuNhapGUI()
		{
			InitializeComponent();
		}
		//Duyệt ký tự số
		public bool IsNumber(string pText)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(pText);
		}

		private void PhieuNhapGUI_Load(object sender, EventArgs e)
		{
			loadcbnv();
			loadcbncc();
			loadmasp();
			cb_masp.Enabled = false;
			txt_slnhap.Enabled = false;
			btn_themsp.Enabled = false;
			//hienthi();
		}
		//Load combobox mã sản phẩm
		private void loadmasp()
		{
			var sp = from a in db.SanPhams
					 select a;
			cb_masp.DataSource = sp;
			cb_masp.DisplayMember = "TenSP";
			cb_masp.ValueMember = "MaSP";
		}
		//Load combobox nhà cung cấp
		private void loadcbncc()
		{
			var ncc = from a in db.NhaCungCaps
					  select a;
			cb_mancc.DataSource = ncc;
			cb_mancc.DisplayMember = "TenNCC";
			cb_mancc.ValueMember = "MaNCC";
		}
		//Load combobox hiển thị nhân viên
		private void loadcbnv()
		{
			var nv = from b in db.NhanViens
					 select b;
			cb_manv.DataSource = nv;
			cb_manv.DisplayMember = "TenNV";
			cb_manv.ValueMember = "MaNV";

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime date = DateTime.Now;
				//Xử lý 
				btn_themphieu.Enabled = false;
				txt_maphieu.Enabled = false;
				cb_mancc.Enabled = false;
				cb_manv.Enabled = false;
				cb_masp.Enabled = true;
				txt_slnhap.Enabled = true;
				btn_themsp.Enabled = true;
				//Tạo phiếu nhập mới
				if (txt_maphieu.Text.Equals(""))
				{
					MessageBox.Show("Mã phiếu không được để trống!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				}
				else
				{
					HoaDonNhap hdnmoi = new HoaDonNhap();
					hdnmoi.MaHDN = txt_maphieu.Text;
					var sp = from b in db.HoaDonNhaps
							 where b.MaHDN.Contains(txt_maphieu.Text)
							 select b;
					if (sp.Count() != 0)
					{
						MessageBox.Show("Trùng mã phiếu, vui lòng nhập mã phiếu khác " + txt_maphieu.Text);
					}
					else
					{
						DialogResult p = MessageBox.Show("Nhập thêm sản phẩm", "Thông báo!", MessageBoxButtons.YesNo);
						if(p==DialogResult.Yes)
						{
							hdnmoi.MaHDN = txt_maphieu.Text;
							hdnmoi.NgayNhap = date;
							hdnmoi.MaNCC = cb_mancc.SelectedValue.ToString();
							hdnmoi.MaNV = cb_manv.SelectedValue.ToString();
							db.HoaDonNhaps.InsertOnSubmit(hdnmoi);
							db.SubmitChanges();
							hienthi();
							lb_maphieu.Text = "Mã phiếu " + txt_maphieu.Text;
							lb_ngaynhap.Text = "Ngày nhập: " + hdnmoi.NgayNhap.ToString();
							lb_tennv.Text = "Tên nhân viên:" + cb_manv.SelectedValue.ToString();
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi, vui lòng kiểm tra lại hoặc gọi hỗ trợ");
			}
		}
		//Hiển thị mảng chi tiết nhập
		//By Tuấn Anh
		private void hienthi()
		{
			dataGridView1.Rows.Clear();
			var sp = from b in db.ChiTietNhaps
					 where b.MaHDN.Contains(txt_maphieu.Text.Trim())
					 select new
					 {
						 b.SanPham.TenSP,
						 b.SLNhap,
					 };
			foreach (var item in sp)
			{
				DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
				dongmoi.Cells[0].Value = item.TenSP;
				dongmoi.Cells[1].Value = item.SLNhap;
				dataGridView1.Rows.Add(dongmoi);
			}
		}
		//Thêm sản phẩm vào bảng chi tiết nhập
		//By Tuấn Anh
		private void btn_themsp_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult s = MessageBox.Show("Chắc chẳn nhập chưa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if(s==DialogResult.Yes)
				{
					if (txt_slnhap.Text.Equals("") || (int.Parse(txt_slnhap.Text) < 0) || (!IsNumber(txt_slnhap.Text)))
					{
						MessageBox.Show("Số lượng không hợp lệ, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if (txt_dongia.Text.Equals("") || (int.Parse(txt_dongia.Text) < 0) || (!IsNumber(txt_dongia.Text)))
						{
							MessageBox.Show("Đơn giá không hợp lệ, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							int n = dataGridView1.Rows.Add();
							dataGridView1.Rows[n].Cells[0].Value = cb_masp.SelectedValue.ToString();
							dataGridView1.Rows[n].Cells[1].Value = txt_slnhap.Text;
							dataGridView1.Rows[n].Cells[2].Value = txt_dongia.Text;
							dataGridView1.Rows[n].Cells[3].Value = Convert.ToString(Convert.ToInt32(txt_slnhap.Text) * Convert.ToInt32(txt_dongia.Text));
							dataGridView1.Rows[n].Cells[4].Value = "Xóa";

							int tien = dataGridView1.Rows.Count;
							int thanhtien = 0;
							int tongsoluong = 0;
							for (int i = 0; i < tien - 1; i++)
							{
								thanhtien += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
								tongsoluong = tongsoluong + Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
							}
							txt_tongtien.Text = thanhtien.ToString();
							txt_tongsoluong.Text = tongsoluong.ToString();
						}
					}
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Có lỗi, vui lòng kiểm tra lại hoặc liên hệ hỗ trợ");
			}
		}

		private void btn_reset_Click(object sender, EventArgs e)
		{
			btn_themphieu.Enabled = true;
			txt_maphieu.Clear();
			txt_maphieu.Enabled = true;
			cb_mancc.Enabled = true;
			cb_manv.Enabled = true;
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_xoaphieu_Click(object sender, EventArgs e)
		{
			try
			{
				HoaDonNhap hd = db.HoaDonNhaps.SingleOrDefault(p => p.MaHDN == txt_maphieu.Text.Trim());
				DialogResult a = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
				if (a == DialogResult.Yes)
				{
					db.HoaDonNhaps.DeleteOnSubmit(hd);
					db.SubmitChanges();
					MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.YesNo);
					lb_ngaynhap.Text = "";
					lb_tennv.Text = "";
					lb_maphieu.Text = "";
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Chỉ xóa được ngay sau khi thêm mới phiếu");
			}

		}

		private void btn_luu_Click(object sender, EventArgs e)
		{
			try
			{
				
					ChiTietNhap ctn = new ChiTietNhap();
					SanPham sp = new SanPham();
					sp = db.SanPhams.SingleOrDefault(s => s.MaSP == cb_masp.SelectedValue.ToString());
					ctn.MaHDN = txt_maphieu.Text;
					ctn.MaSP = cb_masp.SelectedValue.ToString();
					ctn.SLNhap = int.Parse(txt_slnhap.Text);
					sp.SLCo = sp.SLCo + int.Parse(txt_slnhap.Text);
					sp.GiaNhap = int.Parse(txt_dongia.Text);
					db.ChiTietNhaps.InsertOnSubmit(ctn);
					db.SubmitChanges();
					
				MessageBox.Show("Lưu thành công!!!");
			}
			catch (Exception e1)
			{

				MessageBox.Show("Có lỗi" + e1.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
		}

		private void btn_huy_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();
			txt_tongsoluong.Clear();
			txt_tongtien.Clear();
		}

		private void cb_masp_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
