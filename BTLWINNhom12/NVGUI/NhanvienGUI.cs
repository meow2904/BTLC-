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
    public partial class NhanvienGUI : Form
    {
        public NhanvienGUI()
        {
            InitializeComponent();
        }
        DataBMTDataContext db = new DataBMTDataContext();
        private void NhanvienGUI_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
            LoadTrinhDo();
            //LoadQuyen();

        }
        private void HienThiNhanVien()
        {
            var nhanvienQuery = from nv in db.NhanViens
                                select new
                                {
                                    nv.MaNV,
                                    nv.TenNV,
                                    nv.NgaySinh,
                                    nv.GioiTinh,
                                    nv.DiaChi,
                                    nv.SoDienThoai,
                                    nv.TrinhDo.TenTrinhDo,
                                    
                                };

            dgrNhanvien.Rows.Clear();

            foreach (var item in nhanvienQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dgrNhanvien.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaNV;
                dongmoi.Cells[1].Value = item.TenNV;
                dongmoi.Cells[2].Value = item.NgaySinh;
                dongmoi.Cells[3].Value = item.GioiTinh;
                dongmoi.Cells[4].Value = item.DiaChi;
                dongmoi.Cells[5].Value = item.SoDienThoai;
                dongmoi.Cells[6].Value = item.TenTrinhDo;
            
                dongmoi.Cells[7].Value = "Sửa";
                dongmoi.Cells[8].Value = "Xóa";
                dgrNhanvien.Rows.Add(dongmoi);

            }

        }
        private void LoadTrinhDo()
        {
            var trinhdoQuery = from ltd in db.TrinhDos
                               select ltd;
            cbTrinhdo.DataSource = trinhdoQuery;
            cbTrinhdo.DisplayMember = "TenTrinhDo";
            cbTrinhdo.ValueMember = "MaTrinhDo";

        }

        private void btNhaplai_Click(object sender, EventArgs e)
        {
            txtManv.Focus();
            txtManv.Clear();
            txtTennv.Clear();
            txtDiachi.Clear();
            txtSodienthoai.Clear();
            txtTim.Clear();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            String Warnings = "";
            if (!Regex.IsMatch(txtManv.Text, @"nv{1}[0-9]+$"))
            {
                Warnings += "- Mã nhân viên không được để trống và có định dạng nv---.";
            }
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

            //kiểm tra mã kh tồn tại chưa
            if (Warnings.Length == 0)
            {
                var nhanvienQuery = from nv in db.NhanViens
                                    where nv.MaNV == txtManv.Text
                                    select nv;
                if (nhanvienQuery.Count() != 0)
                {
                    MessageBox.Show("Đã tồn tại mã mã nhân viên này, xin kiểm tra lại", "Notification !", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        NhanVien nvmoi = new NhanVien();
                        nvmoi.MaNV = txtManv.Text;
                        nvmoi.TenNV = txtTennv.Text;
                        nvmoi.NgaySinh = dateNgaysinh.Value;
                        if (rdNam.Checked)
                        {
                            nvmoi.GioiTinh = "Nam";
                        }
                        if (rdNu.Checked)
                        {
                            nvmoi.GioiTinh = "Nữ";
                        }
                        nvmoi.DiaChi = txtDiachi.Text;
                        nvmoi.SoDienThoai = txtSodienthoai.Text;
                        nvmoi.MaTrinhDo = cbTrinhdo.SelectedValue.ToString();

                        db.NhanViens.InsertOnSubmit(nvmoi);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Notification!", MessageBoxButtons.OK);


                        HienThiNhanVien();

                    }
                    catch
                    {

                        MessageBox.Show("Có lỗi khi thêm", "Notification!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show(Warnings, "NOTIFOCATION!", MessageBoxButtons.OK);
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            dgrNhanvien.Rows.Clear();
            var nhanvienTim = from nv in db.NhanViens
                              where nv.MaNV.Trim().Equals(txtTim.Text)
                              select new
                              {
                                  nv.MaNV,
                                  nv.TenNV,
                                  nv.NgaySinh,
                                  nv.GioiTinh,
                                  nv.DiaChi,
                                  nv.SoDienThoai,
                                  nv.TrinhDo.TenTrinhDo,
                                 // nv.TaiKhoan.TenTK
                              };

            if (nhanvienTim.Count() == 0)
            {
                MessageBox.Show("Không tồn tại nhân viên này", "NOTIFICATION", MessageBoxButtons.OK);
            }
            else
            {
                foreach (var item in nhanvienTim)
                {
                    DataGridViewRow dongmoi = (DataGridViewRow)
                    dgrNhanvien.Rows[0].Clone();

                    dongmoi.Cells[0].Value = item.MaNV;
                    dongmoi.Cells[1].Value = item.TenNV;
                    dongmoi.Cells[2].Value = item.NgaySinh;
                    dongmoi.Cells[3].Value = item.GioiTinh;
                    dongmoi.Cells[4].Value = item.DiaChi;
                    dongmoi.Cells[5].Value = item.SoDienThoai;
                    dongmoi.Cells[6].Value = item.TenTrinhDo;
                   // dongmoi.Cells[7].Value = item.TenTK;
                    dongmoi.Cells[8].Value = "Sửa";
                    dongmoi.Cells[9].Value = "Xóa";
                    dgrNhanvien.Rows.Add(dongmoi);

                }
            }
        }

        private void dgrNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maNV = dgrNhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();

                var nvChon = db.NhanViens.SingleOrDefault(nv => nv.MaNV == maNV);

                //Xóa khách hàng
                if (e.ColumnIndex == 8)
                {
                    DialogResult rd = MessageBox.Show("Bạn có chắc muốn xóa?", "NOTIFICATION", MessageBoxButtons.YesNo);
                    //kiem tra nhan vien co tai khoan chua, co thi ko dc xoa
                    var tkcheck = db.TaiKhoans.SingleOrDefault(tk => tk.MaNV == maNV);
                    if (tkcheck != null)
                    {
                        MessageBox.Show("Nhan vien này có tài khoản, xóa tk trước", "WARNING", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (rd == DialogResult.Yes)
                        {
                            db.NhanViens.DeleteOnSubmit(nvChon);
                            db.SubmitChanges();
                            HienThiNhanVien();
                        }
                    }


                }

                if (e.ColumnIndex == 7)
                {
                    NhanvienEditGUI f = new NhanvienEditGUI();
                    f.Tag = nvChon;
                    f.ShowDialog();
                }
            }
            catch 
            {

            }
        }

        private void NhanvienGUI_Activated(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }
    }
}
