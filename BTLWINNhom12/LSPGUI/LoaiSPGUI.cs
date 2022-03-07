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
	public partial class LoaiSPGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public LoaiSPGUI()
		{
			InitializeComponent();
		}

		private void LoaiSPGUI_Load(object sender, EventArgs e)
		{
			hienthi();
		}
		//Hiển thị danh sách loại sản phẩm
		private void hienthi()
		{
			dataGridView1.Rows.Clear();
			var sp = from b in db.LoaiSPs
					 select new
					 {
						 b.TenLoai,
						 b.MaLoai

                     };
			foreach (var item in sp )
			{
				DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
				dongmoi.Cells[0].Value = item.MaLoai;
				dongmoi.Cells[1].Value = item.TenLoai;
				dongmoi.Cells[2].Value = "Xóa";
				dongmoi.Cells[3].Value = "Sửa";
				
				dataGridView1.Rows.Add(dongmoi);
			}
		}
		private void LoaiSPGUI_Activated(object sender, EventArgs e)
		{
			hienthi();
		}
		//Hàm click vào nội dung grid
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string loai = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			LoaiSP ncc = db.LoaiSPs.SingleOrDefault(p => p.MaLoai == loai);
			if (e.ColumnIndex == 2)
			{
				DialogResult a = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
				if (a == DialogResult.Yes)
				{
					db.LoaiSPs.DeleteOnSubmit(ncc);
					db.SubmitChanges();
					hienthi();
				}
			}
			else if (e.ColumnIndex == 3)
			{
				SuaLoaiSPGUI myform = new SuaLoaiSPGUI();
				myform.Tag = ncc;
				myform.ShowDialog();
			}
		}
		//Thêm loại sản phẩm
		private void btn_them_Click(object sender, EventArgs e)
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
						LoaiSP nccmoi = new LoaiSP();
						nccmoi.MaLoai = txt_maloai.Text;
						var sp = from b in db.LoaiSPs
								 where b.MaLoai.Contains(txt_maloai.Text)
								 select new
								 {
									 b.MaLoai,
									 b.TenLoai
								 };
						if (sp.Count() != 0) MessageBox.Show("Đã trùng mã sản phẩm" + txt_maloai.Text);
						else
						{
							nccmoi.MaLoai = txt_maloai.Text;
							nccmoi.TenLoai = txt_tenloai.Text;
							db.LoaiSPs.InsertOnSubmit(nccmoi);
							db.SubmitChanges();
							hienthi();
						}
					}
				}
			}
			catch (Exception)
			{

				MessageBox.Show("Có lỗi", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
			
		}
		//Tìm kiêm loại sản phẩm
		private void btn_tim_Click(object sender, EventArgs e)
		{
			if(txt_tim.Text.Trim().Equals("")) MessageBox.Show("Không được để trống mục tìm", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			{
				dataGridView1.Rows.Clear();
				var sp = from b in db.LoaiSPs
						 where b.TenLoai.Contains(txt_tim.Text)
						 select new
						 {
							 b.MaLoai,
							 b.TenLoai

						 };
				if (sp.Count() == 0) MessageBox.Show("Không thấy loại sản phẩm " + txt_tim.Text);
				else
				{
					foreach (var item in sp)
					{
						DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
						dongmoi.Cells[0].Value = item.MaLoai;
						dongmoi.Cells[1].Value = item.TenLoai;
						dongmoi.Cells[2].Value = "Xóa";
						dongmoi.Cells[3].Value = "Sửa";
						dataGridView1.Rows.Add(dongmoi);
					}
				}
			}
		}

		private void btn_hienthi_Click(object sender, EventArgs e)
		{
			hienthi();
		}
	}
}
