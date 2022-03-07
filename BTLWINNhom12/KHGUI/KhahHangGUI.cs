using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTLWINNhom12
{
    public partial class KhahHangGUI : Form
    {
        public KhahHangGUI()
        {
            InitializeComponent();
            
            
        }

        DataBMTDataContext db = new DataBMTDataContext();

        private void KhahHangGUI_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        private void HienThiKhachHang()
        {
            var khachHangQuery = from kh in db.KhachHangs
                                 select kh;
                               
            datagrKhachHang.Rows.Clear();

            foreach (var item in khachHangQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                datagrKhachHang.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaKH;
                dongmoi.Cells[1].Value = item.TenKH;
                dongmoi.Cells[2].Value = item.NgaySinh.Value.ToString("dd-MM-yyyy");
                dongmoi.Cells[3].Value = item.GioiTinh;
                dongmoi.Cells[4].Value = item.DiaChi;
                dongmoi.Cells[5].Value = item.SoDienThoai;
                dongmoi.Cells[6].Value = "Sửa";
                dongmoi.Cells[7].Value = "Xóa";
                datagrKhachHang.Rows.Add(dongmoi);
            }
        }


        private void btNhapLai_Click(object sender, EventArgs e)
        {
            txtMakh.Focus();
            txtMakh.Clear();
            txtTenkh.Clear();
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtTimkiem.Clear();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            String Warnings = "";
            if (!Regex.IsMatch(txtMakh.Text, @"kh{1}[0-9]+$"))
            {
                Warnings += "- Mã khách hàng không được để trống và có định dạng kh---.";
            }
            if (!Regex.IsMatch(txtTenkh.Text, @"[\w]"))
            {
                Warnings += "\r- Tên khách hàng không được để trống.";
            }
            if (!Regex.IsMatch(txtDiachi.Text, @"[\w]"))
            {
                Warnings += "\r- Địa chỉ khách hàng không được để trống.";
            }
            if (!Regex.IsMatch(txtSodienthoai.Text, @"[\d]"))
            {
                Warnings += "\r- Số điện thoại vừa nhập không đúng định dạng.";
            }

            //kiểm tra mã kh tồn tại chưa
            if (Warnings.Length == 0)
            {
                var khachhangQuery = from kh in db.KhachHangs
                                     where kh.MaKH == txtMakh.Text
                                     select kh;
                if (khachhangQuery.Count() != 0)
                {
                    MessageBox.Show("Đã tồn tại mã khách hàng này, xin kiểm tra lại", "Notification !", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        KhachHang khMoi = new KhachHang();
                        khMoi.MaKH = txtMakh.Text;
                        khMoi.TenKH = txtTenkh.Text;
                        khMoi.NgaySinh = dateNgaysinh.Value;
                        if (rdNam.Checked)
                        {
                            khMoi.GioiTinh = "Nam";
                        }
                        if (rdNu.Checked)
                        {
                            khMoi.GioiTinh = "Nữ";
                        }
                        khMoi.DiaChi = txtDiachi.Text;
                        khMoi.SoDienThoai = txtSodienthoai.Text;

                        db.KhachHangs.InsertOnSubmit(khMoi);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Notification!", MessageBoxButtons.OK);
                        HienThiKhachHang();

                        btNhapLai_Click(sender, e);
                    }
                    catch
                    {

                    }

                }
            }
            else
            {
                MessageBox.Show(Warnings, "NOTIFOCATION!", MessageBoxButtons.OK);
            }
        }


        private void KhahHangGUI_Activated(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        private void dateNgaysinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateNgaysinh.Value;
            DateTime dtNow = DateTime.Now;

            if (dt.Year > dtNow.Year)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "NOTIFICATION", MessageBoxButtons.OK);
                dateNgaysinh.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }
            else if (dt.Month > dtNow.Month && dt.Year == dtNow.Year)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "NOTIFICATION", MessageBoxButtons.OK);
                dateNgaysinh.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }
            else if (dt.Day >= dtNow.Day && dt.Month == dtNow.Month && dt.Year == dtNow.Year)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "NOTIFICATION", MessageBoxButtons.OK);
                dateNgaysinh.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }


        }

        private void datagrKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            datagrKhachHang.Rows.Clear();
            var khTim = from kh in db.KhachHangs
                        where kh.MaKH.Contains(txtTimkiem.Text)
                        select kh;
            foreach (var item in khTim)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                datagrKhachHang.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaKH;
                dongmoi.Cells[1].Value = item.TenKH;
                dongmoi.Cells[2].Value = item.NgaySinh;
                dongmoi.Cells[3].Value = item.GioiTinh;
                dongmoi.Cells[4].Value = item.DiaChi;
                dongmoi.Cells[5].Value = item.SoDienThoai;
                dongmoi.Cells[6].Value = "Sửa";
                dongmoi.Cells[7].Value = "Xóa";
                datagrKhachHang.Rows.Add(dongmoi);

            }
        }

        private void datagrKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maKh = datagrKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                // tìm thông tin khách hàng
                var khQ = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == maKh);

                //Xóa khách hàng
                if (e.ColumnIndex == 7)
                {
                    DialogResult rd = MessageBox.Show("Bạn có chắc muốn xóa?", "NOTIFICATION", MessageBoxButtons.YesNo);
                    var khcheck = from kh in db.HoaDonBans
                                  where kh.MaKH==maKh
                                  select kh;
                    if(khcheck.Count()!=0)
                    {
                        MessageBox.Show("Khách hàng có trong Hóa đơn, ko xóa được", "NOTIFICATION", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (rd == DialogResult.Yes)
                        {

                            db.KhachHangs.DeleteOnSubmit(khQ);
                            db.SubmitChanges();
                            KhahHangGUI_Load(sender, e);// gọi lại form load
                        }
                    }
                   
                }

                //Sửa khách hàng

                if (e.ColumnIndex == 6)
                {
                    KhachHangEditGUI khSua = new KhachHangEditGUI();
                    khSua.Tag = khQ;
                    khSua.ShowDialog();

                }
            }
            catch
            {

            }
        }
    }
}
