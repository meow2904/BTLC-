namespace BTLWINNhom12
{
	partial class SuaLoaiSPGUI
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
			this.txt_maloai = new System.Windows.Forms.TextBox();
			this.txt_tenloai = new System.Windows.Forms.TextBox();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(113, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã loại";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên loại";
			// 
			// txt_maloai
			// 
			this.txt_maloai.Enabled = false;
			this.txt_maloai.Location = new System.Drawing.Point(206, 60);
			this.txt_maloai.Name = "txt_maloai";
			this.txt_maloai.Size = new System.Drawing.Size(192, 22);
			this.txt_maloai.TabIndex = 1;
			// 
			// txt_tenloai
			// 
			this.txt_tenloai.Location = new System.Drawing.Point(206, 115);
			this.txt_tenloai.Name = "txt_tenloai";
			this.txt_tenloai.Size = new System.Drawing.Size(192, 22);
			this.txt_tenloai.TabIndex = 1;
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(116, 196);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 2;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(323, 196);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(75, 23);
			this.btn_back.TabIndex = 2;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// SuaLoaiSPGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 299);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.txt_tenloai);
			this.Controls.Add(this.txt_maloai);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SuaLoaiSPGUI";
			this.Text = "SuaLoaiSPGUI";
			this.Load += new System.EventHandler(this.SuaLoaiSPGUI_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_maloai;
		private System.Windows.Forms.TextBox txt_tenloai;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_back;
	}
}