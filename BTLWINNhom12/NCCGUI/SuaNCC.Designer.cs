namespace BTLWINNhom12
{
	partial class SuaNCC
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_back = new System.Windows.Forms.Button();
			this.txt_mancc = new System.Windows.Forms.TextBox();
			this.txt_tenncc = new System.Windows.Forms.TextBox();
			this.txt_dc = new System.Windows.Forms.TextBox();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã NCC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên NCC";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(100, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(100, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "SĐT";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(100, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Email";
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(302, 296);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 1;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(510, 296);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(75, 23);
			this.btn_back.TabIndex = 1;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// txt_mancc
			// 
			this.txt_mancc.Enabled = false;
			this.txt_mancc.Location = new System.Drawing.Point(199, 73);
			this.txt_mancc.Name = "txt_mancc";
			this.txt_mancc.Size = new System.Drawing.Size(203, 22);
			this.txt_mancc.TabIndex = 2;
			// 
			// txt_tenncc
			// 
			this.txt_tenncc.Location = new System.Drawing.Point(199, 113);
			this.txt_tenncc.Name = "txt_tenncc";
			this.txt_tenncc.Size = new System.Drawing.Size(203, 22);
			this.txt_tenncc.TabIndex = 2;
			// 
			// txt_dc
			// 
			this.txt_dc.Location = new System.Drawing.Point(199, 148);
			this.txt_dc.Name = "txt_dc";
			this.txt_dc.Size = new System.Drawing.Size(203, 22);
			this.txt_dc.TabIndex = 2;
			// 
			// txt_sdt
			// 
			this.txt_sdt.Location = new System.Drawing.Point(199, 186);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(203, 22);
			this.txt_sdt.TabIndex = 2;
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(199, 230);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(203, 22);
			this.txt_email.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(222, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(425, 55);
			this.label6.TabIndex = 3;
			this.label6.Text = "Sửa thông tin NCC";
			// 
			// SuaNCC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 418);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.txt_sdt);
			this.Controls.Add(this.txt_dc);
			this.Controls.Add(this.txt_tenncc);
			this.Controls.Add(this.txt_mancc);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SuaNCC";
			this.Text = "SuaNCC";
			this.Load += new System.EventHandler(this.SuaNCC_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.TextBox txt_mancc;
		private System.Windows.Forms.TextBox txt_tenncc;
		private System.Windows.Forms.TextBox txt_dc;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label6;
	}
}