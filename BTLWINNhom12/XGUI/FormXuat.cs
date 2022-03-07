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
    public partial class FormXuat : Form
    {
        DataBMTDataContext db = new DataBMTDataContext();
        String maNV, maHD, maKH;
        public FormXuat(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        
        private void capNhatTongTien()
        {
            int tongTien = 0;
            for(int i=0; i< dgrGiohang.RowCount-1; i++)
            {
                tongTien += int.Parse(dgrGiohang.Rows[i].Cells[5].Value.ToString());
            }
            txtTongtien.Text = tongTien.ToString();
            
        }
        
        private void LoadNVvaKH()
        {
            var nhanvienQ = db.NhanViens.SingleOrDefault( nv=> nv.MaNV==maNV);
            //Hiển thị thông tin nhân viên lên textbox
            txtManv.Text = maNV;
            txtTennv.Text = nhanvienQ.TenNV;

            //hiển thị mã khách hàng, tên khách hàng khi load lên combobox
            var khQ = from kh in db.KhachHangs
                      select kh;
            cbMakh.DataSource = khQ;
            cbMakh.DisplayMember = "MaKH";
            cbMakh.ValueMember = "MaKH";
            //tên
            var khQr = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == cbMakh.SelectedValue.ToString());
            txtTenkh.Text = khQr.TenKH;
        }



        private void LoadSanPham()
        {
            var spQuery = from sp in db.SanPhams
                          select new
                          {
                              sp.MaSP,
                              sp.TenSP,
                              sp.SLCo,
                              sp.GiaBan,
                              sp.HangSX
                          };
            dgrDssanpham.Rows.Clear();

            foreach (var item in spQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dgrDssanpham.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaSP;
                dongmoi.Cells[1].Value = item.TenSP;
                dongmoi.Cells[2].Value = item.GiaBan;
                dongmoi.Cells[3].Value = item.SLCo;
                dongmoi.Cells[4].Value = item.HangSX;

                dgrDssanpham.Rows.Add(dongmoi);
            }

        }

        private void FormXuat_Load(object sender, EventArgs e)
        {
            LoadNVvaKH();
            LoadSanPham();
            capNhatTongTien();
            dateExport.Value = DateTime.Now; // lấy ngày hiện tại
            
        }
        private void dgrGiohang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex; // lấy chỉ số của dong click
            
            
            if (e.RowIndex != -1)
            {
                int giaBan = Int32.Parse(dgrGiohang.Rows[r].Cells[2].Value.ToString());
                int slco = int.Parse(dgrGiohang.Rows[r].Cells[6].Value.ToString());// lấy số lượng có của sản phầm
                int slMua = Int32.Parse(dgrGiohang.Rows[r].Cells[3].Value.ToString());

                if(slMua<=0)
                {
                    MessageBox.Show("Số lượng mua tối thiểu 1", "NOTIFICATION", MessageBoxButtons.OK);
                    dgrGiohang.Rows[r].Cells[3].Value = "1";
                }
                else if(slMua > slco)
                {
                    MessageBox.Show("Không vượt quá số lượng có", "NOTIFICATION", MessageBoxButtons.OK);
                    dgrGiohang.Rows[r].Cells[3].Value=1;
                }

                float chietKhau = 0;
                if(slMua < 3)
                {
                    chietKhau = 0;
                }
                else if(slMua<10)
                {
                    chietKhau = 0.05f;
                }
                else
                {
                    chietKhau = 0.15f;
                }

                dgrGiohang.Rows[r].Cells["chietkhau"].Value = chietKhau;
                int thanhTien =Convert.ToInt32(giaBan * slMua - (giaBan * slMua) * chietKhau);//giá sau khi chiết khâu
                dgrGiohang.Rows[r].Cells[5].Value = thanhTien;


                //Cập nhật giá tiền
                capNhatTongTien();
            }
        }


        private void dgrDssanpham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maSp = dgrDssanpham.CurrentRow.Cells[0].Value.ToString();
                string tenSp = dgrDssanpham.CurrentRow.Cells[1].Value.ToString();
                string giaBan = dgrDssanpham.CurrentRow.Cells[2].Value.ToString();
                string slCo = dgrDssanpham.CurrentRow.Cells[3].Value.ToString();

                bool ktTonTai = false;
                if (dgrGiohang.RowCount < 2)
                {
                    dgrGiohang.Rows.Add(maSp, tenSp, giaBan, 1, 0,giaBan, slCo ,"X");
                }
                else
                {
                    for (int i = 0; i < dgrGiohang.RowCount - 1; i++)
                    {
                        if (dgrGiohang.Rows[i].Cells[0].Value.Equals(maSp))
                        {
                            ktTonTai = true;
                        }
                    }

                    if (ktTonTai)
                    {
                        MessageBox.Show("Sản phẩm đã có trong giỏ hàng", "NOTIFICATION", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dgrGiohang.Rows.Add(maSp, tenSp, giaBan, 1, 0, giaBan, slCo, "X");
                    }
                    
                }
                capNhatTongTien();
            }
            catch (Exception)
            {

            }
        }

        private void cbMakh_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Hiển thị tên khách hàng lên textbox
            try
            {
                var khQr = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == cbMakh.SelectedValue.ToString());
                txtTenkh.Text = khQr.TenKH;
            }
            catch (Exception)
            {

               
            }
        }

        private void dgrGiohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 7)
                {
                    int dongxoa = e.RowIndex;
                    dgrGiohang.Rows.RemoveAt(dongxoa);
                    capNhatTongTien();
                }
            }
            catch (Exception)
            {

            } 

        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            if (dgrGiohang.RowCount < 2)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ", "NOTIFICATION", MessageBoxButtons.OK);

            }
            else
            {
                DateTime dt = DateTime.Now;

                HoaDonBan hdb = new HoaDonBan();
                hdb.MaHDB = "HD" + dt.Year+ dt.Month+dt.Day+dt.Minute+dt.Second;
                hdb.NgayBan = DateTime.Parse(dateExport.Value.ToString("yyyy-MM-dd"));
                hdb.MaNV = txtManv.Text;
                hdb.MaKH = cbMakh.SelectedValue.ToString();

                db.HoaDonBans.InsertOnSubmit(hdb);

                //thêm chi tiết đơn trong gridview
                for (int i = 0; i < dgrGiohang.RowCount - 1; i++)
                {
                    ChiTietBan ctb = new ChiTietBan();
                    ctb.MaHDB = hdb.MaHDB;
                    ctb.MaSP = dgrGiohang.Rows[i].Cells[0].Value.ToString();
                    ctb.SLBan = int.Parse(dgrGiohang.Rows[i].Cells[3].Value.ToString());
                    //cập nhật sô lượng còn của sản phầm
                    int slCoCapNhat = int.Parse(dgrGiohang.Rows[i].Cells[6].Value.ToString()) - int.Parse(dgrGiohang.Rows[i].Cells[3].Value.ToString());
                    var spQ = db.SanPhams.SingleOrDefault(sp => sp.MaSP == ctb.MaSP);
                    spQ.SLCo = slCoCapNhat;
                    db.SubmitChanges();


                    hdb.ChiTietBans.Add(ctb);
                }
                db.SubmitChanges();
                MessageBox.Show("Xuất hóa đơn thành công", "NOTIFICATION", MessageBoxButtons.OK);

                maHD = hdb.MaHDB;// gán giá trị cho mã hóa đơn
                maKH = hdb.MaKH;//gán giá trị cho biến mã kh

                dgrGiohang.Rows.Clear();
                txtTongtien.Clear();
                LoadSanPham();
            }         
        }

        private void btXemHD_Click(object sender, EventArgs e)
        {
            ChitietXuatGUI f = new ChitietXuatGUI();
            f.ShowDialog();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var spQuery = from sp in db.SanPhams
                          where sp.TenSP.Contains(txtTim.Text)
                          select new
                          {
                              sp.MaSP,
                              sp.TenSP,
                              sp.SLCo,
                              sp.GiaBan,
                              sp.HangSX
                          };
            dgrDssanpham.Rows.Clear();

            foreach (var item in spQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dgrDssanpham.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaSP;
                dongmoi.Cells[1].Value = item.TenSP;
                dongmoi.Cells[2].Value = item.GiaBan;
                dongmoi.Cells[3].Value = item.SLCo;
                dongmoi.Cells[4].Value = item.HangSX;

                dgrDssanpham.Rows.Add(dongmoi);
            }
        }
    }
}
