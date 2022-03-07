namespace BTLWINNhom12
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTentk
            // 
            this.txtTentk.Location = new System.Drawing.Point(176, 98);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(178, 20);
            this.txtTentk.TabIndex = 0;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(176, 139);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(178, 20);
            this.txtMatkhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // btDangnhap
            // 
            this.btDangnhap.Location = new System.Drawing.Point(176, 206);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(81, 23);
            this.btDangnhap.TabIndex = 4;
            this.btDangnhap.Text = "Đăng nhập";
            this.btDangnhap.UseVisualStyleBackColor = true;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng Nhập";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(279, 206);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "IC COMPUTER";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(526, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTentk);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label4;
    }
}