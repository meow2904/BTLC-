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

namespace BTLWINNhom12.tkGUI
{
    public partial class TaikhoanEditGUI : Form
    {
        public TaikhoanEditGUI()
        {
            InitializeComponent();
        }

        DataBMTDataContext db = new DataBMTDataContext();
        private void btCapNhat_Click(object sender, EventArgs e)
        {

            String Warnings = "";

            if (!Regex.IsMatch(txtTentk.Text, @"[\w]"))
            {
                Warnings += "\r- Tên tài khoản không được để trống.";
            }
            if (!Regex.IsMatch(txtMatkhau.Text, @"[\w]"))
            {
                Warnings += "\r-Mật khẩu không được để trống.";
            }

            if (Warnings.Length == 0)
            {
                var tk = db.TaiKhoans.SingleOrDefault(t => t.MaTK == txtMatk.Text);
               
                tk.TenTK = txtTentk.Text;
                tk.MaKhau = txtMatkhau.Text;
                tk.QuyenTruyCap = cbQuyen.Text.Trim();
                tk.MaNV = txtManv.Text;

                db.SubmitChanges();
               
                MessageBox.Show("Cập nhật thành công", "NOTIFICATION", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Warnings, "NOTIFICATION", MessageBoxButtons.OK);
            }
           
        }

        private void TaikhoanEditGUI_Load(object sender, EventArgs e)
        {
            TaiKhoan tk = (TaiKhoan)this.Tag;

            txtMatk.Text = tk.MaTK;
            txtTentk.Text = tk.TenTK;
            txtMatkhau.Text = tk.MaKhau;
            cbQuyen.Text = tk.QuyenTruyCap;
            txtManv.Text = tk.MaNV;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
