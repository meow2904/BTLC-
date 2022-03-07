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
	public partial class SuaSP : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public SuaSP()
		{
			InitializeComponent();
		}
		//Duyệt ký tự số
		public bool IsNumber(string pText)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(pText);
		}
		private void btn_sua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_masp.Text.Equals(""))
				{
					MessageBox.Show("Mã sản phẩm không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (txt_tensp.Text.Equals(""))
					{
						MessageBox.Show("Tên sản phẩm không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if (txt_hangsx.Text.Equals(""))
						{
							MessageBox.Show("Hãng sản xuất không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							if (txt_gianhap.Text.Equals("") || (int.Parse(txt_gianhap.Text) < 0) || (!IsNumber(txt_gianhap.Text)))
							{
								MessageBox.Show("Giá nhập không hợp lệ, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								if (txt_giaban.Text.Equals("") || (int.Parse(txt_gianhap.Text) < 0) || (!IsNumber(txt_gianhap.Text)))
								{
									MessageBox.Show("Giá bán không hợp lệ, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
								else
								{
									if (txt_thongso.Text.Equals(""))
									{
										MessageBox.Show("Thông số không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
									else
									{
										if (txt_sl.Text.Equals("") || (int.Parse(txt_sl.Text) < 0) || (!IsNumber(txt_sl.Text)))
										{
											MessageBox.Show("Số lượng không hợp lệ, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
										else
										{
											SanPham spmoi = db.SanPhams.SingleOrDefault(sp => sp.MaSP == txt_masp.Text);
											spmoi.MaSP = txt_masp.Text;
											spmoi.TenSP = txt_tensp.Text;
											spmoi.HangSX = txt_hangsx.Text;
											spmoi.ThongSo = txt_thongso.Text;
											spmoi.SLCo = int.Parse(txt_sl.Text);
											spmoi.GiaBan = int.Parse(txt_giaban.Text);
											spmoi.GiaNhap = int.Parse(txt_gianhap.Text);
											spmoi.MaLoai = cb_loaisp.SelectedValue.ToString();
											db.SubmitChanges();
											MessageBox.Show("Sửa thành công");
										}
									}
								}
							}
						}
					}
				}
			}
	
			catch (Exception)
			{
				MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại nhập dữ liệu hoặc liên hệ hỗ trợ");
			}
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void SuaSP_Load_1(object sender, EventArgs e)
		{
			SanPham sp = (SanPham)this.Tag;
			txt_masp.Text = sp.MaSP;
			txt_tensp.Text = sp.TenSP;
			txt_sl.Text = sp.SLCo.ToString();
			txt_thongso.Text = sp.ThongSo;
			txt_hangsx.Text = sp.HangSX;
			txt_giaban.Text = sp.GiaBan.ToString();
			txt_gianhap.Text = sp.GiaNhap.ToString();
			var loai = from a in db.LoaiSPs
					   select a;
			cb_loaisp.DataSource = loai;
			cb_loaisp.DisplayMember = "TenLoai";
			cb_loaisp.ValueMember = "MaLoai";
			cb_loaisp.SelectedItem = sp.MaLoai.ToString();
		}
	
		private void btn_back_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
