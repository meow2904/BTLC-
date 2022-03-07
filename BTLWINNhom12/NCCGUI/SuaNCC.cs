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
	public partial class SuaNCC : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public SuaNCC()
		{
			InitializeComponent();
		}
		//Duyệt ký tự số
		public bool IsNumber(string pText)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(pText);
		}
		private void SuaNCC_Load(object sender, EventArgs e)
		{
			hienthi();
		}

		private void hienthi()
		{
			NhaCungCap sp = (NhaCungCap)this.Tag;
			txt_mancc.Text = sp.MaNCC;
			txt_tenncc.Text = sp.TenNCC;
			txt_dc.Text = sp.DiaChi;
			txt_sdt.Text = sp.SoDienThoai;
			txt_email.Text = sp.Email;
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_mancc.Text.Equals(""))
				{
					MessageBox.Show("Mã NCC không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (txt_tenncc.Text.Equals(""))
					{
						MessageBox.Show("Tên NCC không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if (txt_dc.Text.Equals(""))
						{
							MessageBox.Show("Địa chỉ không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							if (txt_sdt.Text.Equals("") || (txt_sdt.Text.Length != 10) || (!IsNumber(txt_sdt.Text)))
							{
								MessageBox.Show("Số điện thoại không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								if (txt_email.Text.Equals(""))
								{
									MessageBox.Show("Email không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
								else
								{
									NhaCungCap spsua = db.NhaCungCaps.SingleOrDefault(sp => sp.MaNCC == txt_mancc.Text);
									spsua.TenNCC = txt_tenncc.Text;
									spsua.SoDienThoai = txt_sdt.Text;
									spsua.Email = txt_email.Text;
									spsua.DiaChi = txt_dc.Text;
									db.SubmitChanges();
									MessageBox.Show("Sửa thành công");
								}
							}
						}
					}
				}
			
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi, vui lòng kiểm tra lại hoặc liên hệ hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SuaNCC_Activated(object sender, EventArgs e)
		{
			hienthi();
		}
	}
}
