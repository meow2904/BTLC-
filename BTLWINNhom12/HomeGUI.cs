using BTLWINNhom12.tkGUI;
using BTLWINNhom12.xuatGUI;
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
    public partial class HomeGUI : Form
    {
        String tenTK, quyenTK, maNV;

        private void btDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm lf = new LogInForm();
            lf.ShowDialog();
            this.Close();

        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {
            if(this.panelMain.Controls.Count>0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }
            NhanvienGUI f = new NhanvienGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        public void btKhachhang_Click(object sender, EventArgs e)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }
            KhahHangGUI f = new KhahHangGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            //tắt form đang hiển thị nếu có
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }


            FormXuat f = new FormXuat(maNV);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }


            NCCGUI f = new NCCGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btSanpham_Click(object sender, EventArgs e)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }


            SanPhamGUI f = new SanPhamGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }


            PhieuNhapGUI f = new PhieuNhapGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btQLphieunhap_Click(object sender, EventArgs e)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }


            QLPhieuNhapGUI f = new QLPhieuNhapGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btTaikhoan_Click(object sender, EventArgs e)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }
            TaikhoanGUI f = new TaikhoanGUI();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        public HomeGUI(string tenTK, string quyenTk ,string maNV)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            this.quyenTK = quyenTk;
            this.maNV = maNV;

            // Hiện thông tin lên panel tài khoản
            txtTaikhoan.Text = tenTK;
            if (quyenTK.Trim().Equals("admin"))
            {
                txtQuyen.Text = "Admin";
            }
            if (quyenTK.Trim().Equals("nvban"))
            {
                txtQuyen.Text = "nhanvienban";
                grAdmin.Visible = false;
                grNvnhap.Visible = false;
            }
            if (quyenTK.Trim().Equals("nvnhap"))
            {
                txtQuyen.Text = "nhanviennhap";
                grNvban.Visible = false;
                grAdmin.Visible = false;
            }



        }
    }
}
