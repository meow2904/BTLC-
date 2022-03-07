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
    public partial class NhanvienEditGUI : Form
    {
        public NhanvienEditGUI()
        {
            InitializeComponent();
        }
        DataBMTDataContext db = new DataBMTDataContext();

        private void NhanvienEditGUI_Load(object sender, EventArgs e)
        {
            LoadTrinhDo();
            LoadQuyen();

            NhanVien nv = (NhanVien)this.Tag;
            txtManv.Text = nv.MaNV;
            txtTennv.Text = nv.TenNV;
            dateNgaysinh.Value = Convert.ToDateTime(nv.NgaySinh);
            if(nv.GioiTinh.Equals("Nam"))
            {
                rdNam.Checked = true;
            }

            if(nv.GioiTinh.Equals("Nữ"))
            {
                rdNu.Checked = true;
            }
            txtDiachi.Text = nv.DiaChi;
            txtSodienthoai.Text = nv.SoDienThoai;
            cbTrinhdo.SelectedValue = nv.MaTrinhDo;
            //cbQuyen.SelectedValue = nv.MaTK;

            
        }
        private void LoadTrinhDo()
        {
            var trinhdoQuery = from ltd in db.TrinhDos
                               select ltd;
            cbTrinhdo.DataSource = trinhdoQuery;
            cbTrinhdo.DisplayMember = "TenTrinhDo";
            cbTrinhdo.ValueMember = "MaTrinhDo";

        }
        private void LoadQuyen()
        {
            var taiKhoanQuery = from qtk in db.TaiKhoans
                                select qtk;
            cbQuyen.DataSource = taiKhoanQuery;
            cbQuyen.DisplayMember = "TenTK";
            cbQuyen.ValueMember = "MaTK";
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            String Warnings = "";
     
            if (!Regex.IsMatch(txtTennv.Text, @"[\w]"))
            {
                Warnings += "\r- Tên nhân viên không được để trống.";
            }
            if (!Regex.IsMatch(txtDiachi.Text, @"[\w]"))
            {
                Warnings += "\r- Địa chỉ nhân viên không được để trống.";
            }
            if (!Regex.IsMatch(txtSodienthoai.Text, @"[\d]"))
            {
                Warnings += "\r- Số điện thoại vừa nhập không đúng định dạng.";
            }

            if(Warnings.Length==0)
            {
                var nv = db.NhanViens.SingleOrDefault(n => n.MaNV == txtManv.Text);
                nv.TenNV = txtTennv.Text;
                nv.NgaySinh = dateNgaysinh.Value;
                if (rdNam.Checked)
                {
                    nv.GioiTinh = "Nam";
                }
                if (rdNu.Checked)
                {
                    nv.GioiTinh = "Nữ";
                }
                nv.DiaChi = txtDiachi.Text;
                nv.SoDienThoai = txtSodienthoai.Text;
                nv.MaTrinhDo = cbTrinhdo.SelectedValue.ToString();
               // nv.MaTK = cbQuyen.SelectedValue.ToString();

                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công","NOTIFICATION",MessageBoxButtons.OK);
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
    }
}
