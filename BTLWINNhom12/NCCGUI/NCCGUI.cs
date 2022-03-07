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
	public partial class NCCGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public NCCGUI()
		{
			InitializeComponent();
		}

		private void NCCGUI_Load(object sender, EventArgs e)
		{
			hienthi();
		}
		//Duyệt ký tự số
		public bool IsNumber(string pText)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(pText);
		}
		//Hiển thị danh sách nhà cung cấp lên grid
		private void hienthi()
		{
			try
			{
				dataGridView1.Rows.Clear();
				var sp = from b in db.NhaCungCaps
						 select new
						 {
							 b.MaNCC,
							 b.TenNCC,
							 b.DiaChi,
							 b.SoDienThoai,
							 b.Email
						 };
				foreach (var item in sp)
				{
					DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
					dongmoi.Cells[0].Value = item.MaNCC;
					dongmoi.Cells[1].Value = item.TenNCC;
					dongmoi.Cells[2].Value = item.DiaChi;
					dongmoi.Cells[3].Value = item.SoDienThoai;
					dongmoi.Cells[4].Value = item.Email;
					dongmoi.Cells[5].Value = "Xóa";
					dongmoi.Cells[6].Value = "Sửa";
					dataGridView1.Rows.Add(dongmoi);
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Có lỗi hiển thị, vui lòng liên hệ hỗ trợ!", "Thông báo", MessageBoxButtons.OK);
			}
		}

		private void NCCGUI_Activated(object sender, EventArgs e)
		{
			hienthi();
		}
		//Sự kiện cho cell-click
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string mancc = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			NhaCungCap ncc = db.NhaCungCaps.SingleOrDefault(p => p.MaNCC == mancc);
			if (e.ColumnIndex == 5)
			{
				DialogResult a = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
				if (a == DialogResult.Yes)
				{
					db.NhaCungCaps.DeleteOnSubmit(ncc);
					db.SubmitChanges();
					hienthi();
				}
			}
			else if (e.ColumnIndex == 6)
			{
				SuaNCC myform = new SuaNCC();
				myform.Tag = ncc;                                                       
				myform.ShowDialog();
			}
		}
		//Sự kiện cho nút tìm kiếm
		private void btn_tim_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			if (txt_timtencc.Text.Trim().Equals("")) MessageBox.Show("Điền thông tin muốn tìm", "Thông báo");
			else
			{
				var ncc = from b in db.NhaCungCaps
						  where b.TenNCC.Contains(txt_timtencc.Text.Trim())
						  select new
						  {
							  b.MaNCC,
							  b.TenNCC,
							  b.DiaChi,
							  b.SoDienThoai,
							  b.Email
						  };
				if (ncc.Count() == 0)
					MessageBox.Show("Không tìm thấy nhà cung cấp " + txt_timtencc.Text);
				else
				{
					foreach (var item in ncc)
					{
						DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
						dongmoi.Cells[0].Value = item.MaNCC;
						dongmoi.Cells[1].Value = item.TenNCC;
						dongmoi.Cells[2].Value = item.DiaChi;
						dongmoi.Cells[3].Value = item.SoDienThoai;
						dongmoi.Cells[4].Value = item.Email;
						dongmoi.Cells[5].Value = "Xóa";
						dongmoi.Cells[6].Value = "Sửa";
						dataGridView1.Rows.Add(dongmoi);
					}
				}
			}
		}
		//Sự kiện cho nút thêm
		private void btn_them_Click(object sender, EventArgs e)
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
							if (txt_sdt.Text.Equals("") || (txt_sdt.Text.Length!=10) || (!IsNumber(txt_sdt.Text)))
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
									NhaCungCap nccmoi = new NhaCungCap();
									nccmoi.MaNCC = txt_mancc.Text;
									var sp = from b in db.NhaCungCaps
											 where b.MaNCC.Contains(txt_mancc.Text)
											 select new
											 {
												 b.MaNCC,
												 b.TenNCC,
												 b.DiaChi,
												 b.SoDienThoai,
												 b.Email
											 };
									if (sp.Count() != 0) MessageBox.Show("Đã trùng mã nhà cung cấp " + txt_mancc.Text);
									else
									{
										nccmoi.TenNCC = txt_tenncc.Text;
										nccmoi.DiaChi = txt_dc.Text;
										nccmoi.SoDienThoai = txt_sdt.Text;
										nccmoi.Email = txt_email.Text;
										db.NhaCungCaps.InsertOnSubmit(nccmoi);
										db.SubmitChanges();
										hienthi();
										MessageBox.Show("Thêm thành công");
									}
								}
							}
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Có lỗi, vui lòng kiểm tra lại hoặc liên hệ hỗ trợ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
