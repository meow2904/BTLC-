namespace BTLWINNhom12
{
	partial class ChiTietPNGUI
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
			this.grid_hd = new System.Windows.Forms.DataGridView();
			this.grid_ct = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grid_hd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_ct)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(282, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chi tiết hóa đơn";
			// 
			// grid_hd
			// 
			this.grid_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_hd.Location = new System.Drawing.Point(123, 121);
			this.grid_hd.Name = "grid_hd";
			this.grid_hd.RowTemplate.Height = 24;
			this.grid_hd.Size = new System.Drawing.Size(748, 168);
			this.grid_hd.TabIndex = 1;
			// 
			// grid_ct
			// 
			this.grid_ct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_ct.Location = new System.Drawing.Point(142, 313);
			this.grid_ct.Name = "grid_ct";
			this.grid_ct.RowTemplate.Height = 24;
			this.grid_ct.Size = new System.Drawing.Size(704, 161);
			this.grid_ct.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(408, 493);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 36);
			this.button1.TabIndex = 3;
			this.button1.Text = "Đóng";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ChiTietPNGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 565);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.grid_ct);
			this.Controls.Add(this.grid_hd);
			this.Controls.Add(this.label1);
			this.Name = "ChiTietPNGUI";
			this.Text = "ChiTietPN";
			this.Load += new System.EventHandler(this.ChiTietPNGUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid_hd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_ct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView grid_hd;
		private System.Windows.Forms.DataGridView grid_ct;
		private System.Windows.Forms.Button button1;
	}
}