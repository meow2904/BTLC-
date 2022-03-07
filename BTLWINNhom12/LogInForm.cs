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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.AcceptButton = this.btDangnhap;
            txtMatkhau.PasswordChar = '*';
        }
        DataBMTDataContext db = new DataBMTDataContext();
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if(txtTentk.Text.Equals("") || txtMatkhau.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản, mật khẩu không được để trông!","NOTIFICATION",MessageBoxButtons.OK);
            }
            else
            {
                var tkQuery = db.TaiKhoans.SingleOrDefault(tk => tk.TenTK == txtTentk.Text && tk.MaKhau == txtMatkhau.Text);

                //var tkQ = from tk in db.TaiKhoans
                //          where tk.TenTK.Trim().Equals(txtTentk.Text) && tk.MaKhau.Trim().Equals(txtMatkhau.Text)
                //          select tk;
                if (tkQuery == null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu ko đúng!", "NOTIFICATION", MessageBoxButtons.OK);
                    txtMatkhau.Clear();
                }
                else
                {
                    this.Hide();
                    HomeGUI hf = new HomeGUI(tkQuery.TenTK, tkQuery.QuyenTruyCap, tkQuery.MaNV);
                    hf.ShowDialog();
                    this.Close();
                }
            }
        }

       

    }
}
