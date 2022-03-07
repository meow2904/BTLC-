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
    public partial class TaikhoanGUI : Form
    {
        DataBMTDataContext db = new DataBMTDataContext();
        public TaikhoanGUI()
        {
            InitializeComponent();
        }

        private void TaikhoanGUI_Load(object sender, EventArgs e)
        {
            cbQuyen.Text = "admin";
            LoadNhanvien();
            LoadTaiKhoan();
            
        }
        public void LoadTaiKhoan()
        {
            var taikhoanQuery = from tk in db.TaiKhoans
                                select new
                                {
                                    tk.MaTK,
                                    tk.TenTK,
                                    tk.MaKhau,
                                    tk.QuyenTruyCap,
                                    tk.NhanVien.MaNV
                                };

            dgrTaiKhoan.Rows.Clear();

            foreach (var item in taikhoanQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dgrTaiKhoan.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaTK;
                dongmoi.Cells[1].Value = item.TenTK;
                dongmoi.Cells[2].Value = item.MaKhau;
                dongmoi.Cells[3].Value = item.QuyenTruyCap;
                dongmoi.Cells[4].Value = item.MaNV;

                dongmoi.Cells[5].Value = "Sửa";
                dongmoi.Cells[6].Value = "Xóa";
                dgrTaiKhoan.Rows.Add(dongmoi);

            }
        }
        public void LoadNhanvien()
        {
            var nvq = from nv in db.NhanViens
                      select nv;

            cbManv.DataSource = nvq;
            cbManv.DisplayMember = "TenNV";
            cbManv.ValueMember = "MaNV";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            String Warnings = "";
            if (!Regex.IsMatch(txtMatk.Text, @"tk{1}[0-9]+$"))
            {
                Warnings += "- Mã tài khoản không để trống và có định dạng tk---.";
            }
            if (!Regex.IsMatch(txtTentk.Text, @"[\w]"))
            {
                Warnings += "\r- Tên nhân viên không được để trống.";
            }
            if (!Regex.IsMatch(txtMatk.Text, @"[\w]"))
            {
                Warnings += "\r- Địa chỉ nhân viên không được để trống.";
            }
            
            if(Warnings.Length != 0)
            {
                MessageBox.Show(Warnings, "NOTIFICATION", MessageBoxButtons.OK);
            }
            else
            {
                // truy vấn xem nhân viên này có tài khoản chưa
                var tknv = from tnv in db.TaiKhoans
                           where tnv.MaNV.Trim().Equals(cbManv.SelectedValue.ToString())
                           select tnv;
                            
                if(tknv.Count() != 0)
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản rồi", "NOTIFICATION", MessageBoxButtons.OK);

                }
                else
                {
                    var tkQ = from tk in db.TaiKhoans
                              where tk.MaTK.Trim().Equals(txtMatk.Text)
                              select tk;

                    if (tkQ.Count() != 0)
                    {
                        MessageBox.Show("Đã tồn tại mã tài khoản này", "NOTIFICATION", MessageBoxButtons.OK);
                    }
                    else
                    {
                        TaiKhoan tk = new TaiKhoan();
                        tk.MaTK = txtMatk.Text;
                        tk.TenTK = txtTentk.Text;
                        tk.MaKhau = txtMatkhau.Text;
                        tk.QuyenTruyCap = cbQuyen.SelectedItem.ToString();
                        tk.MaNV = cbManv.SelectedValue.ToString();

                        db.TaiKhoans.InsertOnSubmit(tk);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "NOTIFICATION", MessageBoxButtons.OK);
                        LoadTaiKhoan();
                    }
                }
                
                            
            }
        }

        private void dgrTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string matk = dgrTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();

                var tkChon = db.TaiKhoans.SingleOrDefault(tk => tk.MaTK == matk);

                //Xóa khách hàng
                if (e.ColumnIndex == 6)
                {
                    DialogResult rd = MessageBox.Show("Bạn có chắc muốn xóa?", "NOTIFICATION", MessageBoxButtons.YesNo);

                    if (rd == DialogResult.Yes)
                    {
                        db.TaiKhoans.DeleteOnSubmit(tkChon);
                        db.SubmitChanges();
                        LoadTaiKhoan();
                    }


                }

                if (e.ColumnIndex == 5)
                {
                    TaikhoanEditGUI f = new TaikhoanEditGUI();
                    f.Tag = tkChon;
                    f.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
        }

        private void TaikhoanGUI_Activated(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
