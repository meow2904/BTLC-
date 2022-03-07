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
	public partial class SuaLoaiSPGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public SuaLoaiSPGUI()
		{
			InitializeComponent();
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txt_maloai.Text.Equals(""))
				{
					MessageBox.Show("Mã loại không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{

					if (txt_tenloai.Text.Equals(""))
						MessageBox.Show("Mã loại không được để trống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
					{
						LoaiSP spsua = db.LoaiSPs.SingleOrDefault(sp => sp.MaLoai == txt_maloai.Text);
						spsua.MaLoai = txt_maloai.Text;
						spsua.TenLoai = txt_tenloai.Text;
						db.SubmitChanges();
						MessageBox.Show("Sửa thành công");
					}
					
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Có lỗi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
		}

		private void SuaLoaiSPGUI_Load(object sender, EventArgs e)
		{
			hienthi();
		}

		private void hienthi()
		{
			LoaiSP sp = (LoaiSP)this.Tag;
			txt_maloai.Text = sp.MaLoai;
			txt_tenloai.Text = sp.TenLoai;
		}
	}
}
