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
	public partial class SanPhamGUI : Form
	{
		DataBMTDataContext db = new DataBMTDataContext();
		public SanPhamGUI()
		{
			InitializeComponent();
		}
		//Duyệt ký tự số
		public bool IsNumber(string pText)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(pText);
		}
		private void SanPhamGUI_Load(object sender, EventArgs e)
		{
			hienthi();
			loadcbox();
		}

		private void loadcbox()
		{
			var loai = from a in db.LoaiSPs
					   select a;
			cb_loaisp.DataSource = loai;
			cb_loaisp.DisplayMember = "TenLoai";
			cb_loaisp.ValueMember = "MaLoai";
		}

		private void hienthi()
		{
			dataGridView1.Rows.Clear();
			var sp = from b in db.SanPhams
					 select new
					 {
						 b.MaSP,
						 b.TenSP,
						 b.HangSX,
						 b.ThongSo,
						 b.GiaBan,
						 b.GiaNhap,
						 b.SLCo,
						 b.LoaiSP.TenLoai
					 };
			foreach (var item in sp)
			{
				DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
				dongmoi.Cells[0].Value = item.MaSP;
				dongmoi.Cells[1].Value = item.TenSP;
				dongmoi.Cells[2].Value = item.HangSX;
				dongmoi.Cells[3].Value = item.ThongSo;
				dongmoi.Cells[4].Value = item.GiaBan;
				dongmoi.Cells[5].Value = item.GiaNhap;
				dongmoi.Cells[6].Value = item.SLCo;
				dongmoi.Cells[7].Value = item.TenLoai;
				dongmoi.Cells[8].Value = "Sửa";
				dongmoi.Cells[9].Value = "Xóa";
				dataGridView1.Rows.Add(dongmoi);
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
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
											SanPham spmoi = new SanPham();
											spmoi.MaSP = txt_masp.Text;
											var sp = from b in db.SanPhams
													 where b.MaSP.Contains(txt_masp.Text)
													 select new
													 {
														 b.MaSP,
														 b.TenSP,
														 b.HangSX,
														 b.ThongSo,
														 b.GiaBan,
														 b.GiaNhap,
														 b.SLCo,
														 b.LoaiSP.TenLoai
													 };
											if (sp.Count() != 0)
											{
												MessageBox.Show("Sản phẩm đã có");
												SanPham spsua = db.SanPhams.SingleOrDefault(a => a.MaSP == txt_masp.Text);
												spsua.SLCo = spsua.SLCo + int.Parse(txt_sl.Text);
												db.SubmitChanges();
												MessageBox.Show("Thêm thành công");

											}
											else
											{
												spmoi.MaSP = txt_masp.Text;
												spmoi.TenSP = txt_tensp.Text;
												spmoi.HangSX = txt_hangsx.Text;
												spmoi.ThongSo = txt_thongso.Text;
												spmoi.SLCo = int.Parse(txt_sl.Text);
												spmoi.GiaBan = int.Parse(txt_giaban.Text);
												spmoi.GiaNhap = int.Parse(txt_gianhap.Text);
												spmoi.MaLoai = cb_loaisp.SelectedValue.ToString();
												db.SanPhams.InsertOnSubmit(spmoi);
												db.SubmitChanges();
												MessageBox.Show("Nhập mới thành công");
												hienthi();
											}
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

		private void SanPhamGUI_Activated(object sender, EventArgs e)
		{
			hienthi();
		}

		//private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	try
		//	{
		//		int row = e.RowIndex;
		//		txt_masp.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
		//		txt_tensp.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
		//		txt_hangsx.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
		//		txt_thongso.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
		//		txt_soluong.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
		//		txt_giaban.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
		//		txt_gianhap.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
		//		cb_maloai.SelectedItem = dataGridView1.Rows[row].Cells[7].Value.ToString();
		//		btn_them.Text = "Nhập thêm";
		//	}
		//	catch (Exception)
		//	{

		//		MessageBox.Show("Chọn vào đúng vị trí");
		//	}

		//}
	//private void btn_nhaplai_Click(object sender, EventArgs e)
		//{
		//	txt_masp.Text = "";
		//	txt_tensp.Text = "";
		//	txt_hangsx.Text = "";
		//	txt_thongso.Text = "";
		//	txt_soluong.Text = "";
		//	txt_giaban.Text = "";
		//	txt_gianhap.Text = "";
		//	txt_masp.Focus();
		//}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			var sp = from b in db.SanPhams
					  where b.TenSP.Contains(txt_tim.Text.Trim())
					  select new
					  {
						  b.MaSP,
						  b.TenSP,
						  b.HangSX,
						  b.ThongSo,
						  b.GiaBan,
						  b.GiaNhap,
						  b.SLCo,
						  b.LoaiSP.TenLoai
					  };
			if (sp.Count() == 0) MessageBox.Show("Không thấy sản phẩm " + txt_tim.Text);
			else
			{
				foreach (var item in sp)
				{
					DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
					dongmoi.Cells[0].Value = item.MaSP;
					dongmoi.Cells[1].Value = item.TenSP;
					dongmoi.Cells[2].Value = item.HangSX;
					dongmoi.Cells[3].Value = item.ThongSo;
					dongmoi.Cells[4].Value = item.GiaBan;
					dongmoi.Cells[5].Value = item.GiaNhap;
					dongmoi.Cells[6].Value = item.SLCo;
					dongmoi.Cells[7].Value = item.TenLoai;
					dongmoi.Cells[8].Value = "Sửa";
					dongmoi.Cells[8].Value = "Xóa";
					dataGridView1.Rows.Add(dongmoi);
				}
			}
		}

		private void btn_load_Click(object sender, EventArgs e)
		{
			hienthi();
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
					
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			string sp = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			SanPham spsua = db.SanPhams.SingleOrDefault(p => p.MaSP == sp);
			if (e.ColumnIndex == 9)
			{
				DialogResult a = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
				if (a == DialogResult.Yes)
				{
                    try
                    {
                        db.SanPhams.DeleteOnSubmit(spsua);
                        db.SubmitChanges();
                        hienthi();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Sản phẩm này đã có trong HD nên ko được xóa","Thông báo",MessageBoxButtons.OK);
                    }
				}
			}
			else if (e.ColumnIndex == 8)
			{
				SuaSP myform = new SuaSP();
				myform.Tag = spsua;
				myform.ShowDialog();
			}
		}
	}
}
