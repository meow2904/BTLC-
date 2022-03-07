using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWINNhom12.xuatGUI
{
    public partial class ChitietXuatGUI : Form
    {
        DataBMTDataContext db = new DataBMTDataContext();

        public ChitietXuatGUI()
        {
            InitializeComponent();
        }

        private void ChitietXuatGUI_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            
        }
        private void LoadHoaDon()
        {
            var hdQ = from hd in db.HoaDonBans
                      select hd;
            dgrDsHoaDon.Rows.Clear();

            foreach(var item in hdQ)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dgrDsHoaDon.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaHDB;
                dongmoi.Cells[1].Value = item.NgayBan.Value.ToString("dd-MM-yyyy");
                dongmoi.Cells[2].Value = item.MaNV;
                dongmoi.Cells[3].Value = item.MaKH;

                dgrDsHoaDon.Rows.Add(dongmoi);
            }

        }
        private int TinhTongTien()
        {
            int tongTien = 0;
            if (dgrChitietban.RowCount < 2)
            {
                tongTien = 0;
            }
            else
            {
                for (int i = 0; i < dgrChitietban.RowCount - 1; i++)
                {
                    tongTien += int.Parse(dgrChitietban.Rows[i].Cells[5].Value.ToString());
                }
            }

            return tongTien;

        }


        private void dgrDsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;

            try
            {
                txtMaHD.Text= dgrDsHoaDon.Rows[r].Cells[0].Value.ToString();
                txtNgayxuat.Text = dgrDsHoaDon.Rows[r].Cells[1].Value.ToString();

                //Lấy thông tin nhân viên
                string manv = dgrDsHoaDon.Rows[r].Cells[2].Value.ToString();
                var nvQ = db.NhanViens.SingleOrDefault(nv => nv.MaNV == manv);
                txtTenNV.Text = nvQ.TenNV;

                //Lấy thông tin khách hàng
                string makh = dgrDsHoaDon.Rows[r].Cells[3].Value.ToString();
                var khQ = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == makh);
                txtTenkh.Text = khQ.TenKH;
                txtDiachi.Text = khQ.DiaChi;
                txtSodienthoai.Text = khQ.SoDienThoai;

                //lấy danh sách sản phẩm trong hóa đơn
                string mahd = dgrDsHoaDon.Rows[r].Cells[0].Value.ToString();
                var ctbQ = from ctb in db.ChiTietBans
                           join sp in db.SanPhams on ctb.MaSP equals sp.MaSP
                           where ctb.MaHDB == mahd
                           select new
                           {
                               sp.MaSP,
                               sp.TenSP,
                               sp.GiaBan,
                               ctb.SLBan,
                           };
                dgrChitietban.Rows.Clear();
                foreach (var item in ctbQ)
                {
                    DataGridViewRow dongmoi = (DataGridViewRow)
                    dgrChitietban.Rows[0].Clone();

                    dongmoi.Cells[0].Value = item.MaSP;
                    dongmoi.Cells[1].Value = item.TenSP;
                    dongmoi.Cells[2].Value = item.GiaBan;
                    dongmoi.Cells[3].Value = item.SLBan;
                    
                    //Tính chiết khấu
                    float chietKhau = 0;
                    if (item.SLBan < 3)
                    {
                        chietKhau = 0;
                    }
                    else if (item.SLBan < 10)
                    {
                        chietKhau = 0.05f;
                    }
                    else
                    {
                        chietKhau = 0.15f;
                    }
                    dongmoi.Cells[4].Value = chietKhau.ToString(); 
                    int thanhTien = Convert.ToInt32( item.GiaBan * item.SLBan -item.GiaBan * item.SLBan * chietKhau   );
                    dongmoi.Cells[5].Value = thanhTien.ToString();

                    dgrChitietban.Rows.Add(dongmoi);
                }
                txtTongtien.Text = TinhTongTien().ToString();
            }
            catch (Exception)
            {

            }             

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            dgrDsHoaDon.Rows.Clear();
            var hdQ = from hd in db.HoaDonBans
                      where hd.MaHDB.Contains(txtTim.Text)
                      select hd;
           

            foreach (var item in hdQ)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dgrDsHoaDon.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaHDB;
                dongmoi.Cells[1].Value = item.NgayBan;
                dongmoi.Cells[2].Value = item.MaNV;
                dongmoi.Cells[3].Value = item.MaKH;

                dgrDsHoaDon.Rows.Add(dongmoi);
            }

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
