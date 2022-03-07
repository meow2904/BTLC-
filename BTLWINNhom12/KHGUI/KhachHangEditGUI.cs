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
    public partial class KhachHangEditGUI : Form
    {
        public KhachHangEditGUI()
        {
            InitializeComponent();
        }
        DataBMTDataContext db = new DataBMTDataContext();

        private void KhachHangEditGUI_Load(object sender, EventArgs e)
        {
            KhachHang kSua = (KhachHang)this.Tag;
            txtMakh.Text = kSua.MaKH;
            txtTenkh.Text = kSua.TenKH;
            dateNgaysinh.Value = Convert.ToDateTime(kSua.NgaySinh);

            if(kSua.GioiTinh.Trim().Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            if(kSua.GioiTinh.Trim().Equals("Nữ"))
            {
                rdNu.Checked = false;
            }

            txtDiachi.Text = kSua.DiaChi;
            txtSodienthoai.Text = kSua.SoDienThoai;
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            String Warnings = "";
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

            if(Warnings.Length==0)
            {
                KhachHang khSua = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == txtMakh.Text);
                khSua.TenKH = txtTenkh.Text;
                khSua.NgaySinh = dateNgaysinh.Value;
                if (rdNam.Checked)
                {
                    khSua.GioiTinh = "Nam";
                }
                if (rdNu.Checked)
                {
                    khSua.GioiTinh = "Nữ";
                }
                khSua.DiaChi = txtDiachi.Text;
                khSua.SoDienThoai = txtSodienthoai.Text;
                db.SubmitChanges();

                MessageBox.Show("Sửa thành công", "NOTIFICATION", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Warnings, "NOTIFICATION", MessageBoxButtons.OK);
            }

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateNgaysinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateNgaysinh.Value;
            DateTime dtNow = DateTime.Now;

            if (dt.Year > dtNow.Year)
            {
                MessageBox.Show("Ngáy sinh phải nhỏ hơn ngày hiện tại", "NOTIFICATION", MessageBoxButtons.OK);
                dateNgaysinh.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }
            else if (dt.Month > dtNow.Month && dt.Year == dtNow.Year)
            {
                MessageBox.Show("Ngáy sinh phải nhỏ hơn ngày hiện tại", "NOTIFICATION", MessageBoxButtons.OK);
                dateNgaysinh.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }
            else if (dt.Day >= dtNow.Day && dt.Month == dtNow.Month && dt.Year == dtNow.Year)
            {
                MessageBox.Show("Ngáy sinh phải nhỏ hơn ngày hiện tại", "NOTIFICATION", MessageBoxButtons.OK);
                dateNgaysinh.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }
        }
    }
}
