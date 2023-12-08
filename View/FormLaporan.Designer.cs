namespace FashionFusion.View
{
    partial class FormLaporan
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
            this.panelLp = new System.Windows.Forms.Panel();
            this.labelLpPembelian = new System.Windows.Forms.Label();
            this.labelLpPenjualan = new System.Windows.Forms.Label();
            this.PictureBoxLpPembelian = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxLpPenjualan = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLpPembelian = new Guna.UI2.WinForms.Guna2Button();
            this.btnLpPenjualan = new Guna.UI2.WinForms.Guna2Button();
            this.labelLaporan = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnJudul = new Guna.UI2.WinForms.Guna2Button();
            this.PictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelLp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLpPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLpPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLp
            // 
            this.panelLp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLp.BackColor = System.Drawing.Color.FloralWhite;
            this.panelLp.Controls.Add(this.labelLpPembelian);
            this.panelLp.Controls.Add(this.labelLpPenjualan);
            this.panelLp.Controls.Add(this.PictureBoxLpPembelian);
            this.panelLp.Controls.Add(this.pictureBoxLpPenjualan);
            this.panelLp.Controls.Add(this.btnLpPembelian);
            this.panelLp.Controls.Add(this.btnLpPenjualan);
            this.panelLp.Location = new System.Drawing.Point(132, 173);
            this.panelLp.Name = "panelLp";
            this.panelLp.Size = new System.Drawing.Size(994, 372);
            this.panelLp.TabIndex = 25;
            // 
            // labelLpPembelian
            // 
            this.labelLpPembelian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLpPembelian.AutoSize = true;
            this.labelLpPembelian.Location = new System.Drawing.Point(616, 281);
            this.labelLpPembelian.Name = "labelLpPembelian";
            this.labelLpPembelian.Size = new System.Drawing.Size(146, 20);
            this.labelLpPembelian.TabIndex = 23;
            this.labelLpPembelian.Text = "Laporan Pembelian";
            // 
            // labelLpPenjualan
            // 
            this.labelLpPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLpPenjualan.AutoSize = true;
            this.labelLpPenjualan.Location = new System.Drawing.Point(189, 281);
            this.labelLpPenjualan.Name = "labelLpPenjualan";
            this.labelLpPenjualan.Size = new System.Drawing.Size(142, 20);
            this.labelLpPenjualan.TabIndex = 25;
            this.labelLpPenjualan.Text = "Laporan Penjualan";
            // 
            // PictureBoxLpPembelian
            // 
            this.PictureBoxLpPembelian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxLpPembelian.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLpPembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxLpPembelian.Image = global::FashionFusion.Properties.Resources.icons8_purchase_100;
            this.PictureBoxLpPembelian.ImageRotate = 0F;
            this.PictureBoxLpPembelian.Location = new System.Drawing.Point(605, 83);
            this.PictureBoxLpPembelian.Name = "PictureBoxLpPembelian";
            this.PictureBoxLpPembelian.Size = new System.Drawing.Size(177, 159);
            this.PictureBoxLpPembelian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLpPembelian.TabIndex = 22;
            this.PictureBoxLpPembelian.TabStop = false;
            this.PictureBoxLpPembelian.UseTransparentBackground = true;
            this.PictureBoxLpPembelian.Click += new System.EventHandler(this.PictureBoxLpPembelian_Click_1);
            // 
            // pictureBoxLpPenjualan
            // 
            this.pictureBoxLpPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLpPenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLpPenjualan.Image = global::FashionFusion.Properties.Resources.icons8_sale_64;
            this.pictureBoxLpPenjualan.ImageRotate = 0F;
            this.pictureBoxLpPenjualan.Location = new System.Drawing.Point(177, 83);
            this.pictureBoxLpPenjualan.Name = "pictureBoxLpPenjualan";
            this.pictureBoxLpPenjualan.Size = new System.Drawing.Size(176, 159);
            this.pictureBoxLpPenjualan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLpPenjualan.TabIndex = 26;
            this.pictureBoxLpPenjualan.TabStop = false;
            this.pictureBoxLpPenjualan.Click += new System.EventHandler(this.pictureBoxLpPenjualan_Click_1);
            // 
            // btnLpPembelian
            // 
            this.btnLpPembelian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLpPembelian.BackColor = System.Drawing.Color.Transparent;
            this.btnLpPembelian.BorderRadius = 30;
            this.btnLpPembelian.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLpPembelian.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLpPembelian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLpPembelian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLpPembelian.FillColor = System.Drawing.Color.Silver;
            this.btnLpPembelian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLpPembelian.ForeColor = System.Drawing.Color.White;
            this.btnLpPembelian.Location = new System.Drawing.Point(574, 49);
            this.btnLpPembelian.Name = "btnLpPembelian";
            this.btnLpPembelian.Size = new System.Drawing.Size(235, 280);
            this.btnLpPembelian.TabIndex = 21;
            // 
            // btnLpPenjualan
            // 
            this.btnLpPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLpPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.btnLpPenjualan.BorderRadius = 30;
            this.btnLpPenjualan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLpPenjualan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLpPenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLpPenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLpPenjualan.FillColor = System.Drawing.Color.LightGray;
            this.btnLpPenjualan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLpPenjualan.ForeColor = System.Drawing.Color.White;
            this.btnLpPenjualan.Location = new System.Drawing.Point(149, 49);
            this.btnLpPenjualan.Name = "btnLpPenjualan";
            this.btnLpPenjualan.Size = new System.Drawing.Size(240, 280);
            this.btnLpPenjualan.TabIndex = 24;
            // 
            // labelLaporan
            // 
            this.labelLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLaporan.AutoSize = true;
            this.labelLaporan.BackColor = System.Drawing.Color.FloralWhite;
            this.labelLaporan.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporan.Location = new System.Drawing.Point(598, 54);
            this.labelLaporan.Name = "labelLaporan";
            this.labelLaporan.Size = new System.Drawing.Size(230, 61);
            this.labelLaporan.TabIndex = 23;
            this.labelLaporan.Text = "Laporan";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 5;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(946, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 60);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnJudul
            // 
            this.btnJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnJudul.BackColor = System.Drawing.Color.Transparent;
            this.btnJudul.BorderRadius = 20;
            this.btnJudul.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJudul.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJudul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJudul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJudul.FillColor = System.Drawing.Color.FloralWhite;
            this.btnJudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJudul.ForeColor = System.Drawing.Color.White;
            this.btnJudul.Location = new System.Drawing.Point(439, 35);
            this.btnJudul.Name = "btnJudul";
            this.btnJudul.Size = new System.Drawing.Size(559, 100);
            this.btnJudul.TabIndex = 21;
            // 
            // PictureLogo
            // 
            this.PictureLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureLogo.Image = global::FashionFusion.Properties.Resources.Black_and_White_Elegant_Initials_Monogram_Logo__1_;
            this.PictureLogo.ImageRotate = 0F;
            this.PictureLogo.Location = new System.Drawing.Point(257, 39);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(147, 96);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogo.TabIndex = 24;
            this.PictureLogo.TabStop = false;
            this.PictureLogo.UseTransparentBackground = true;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionFusion.Properties.Resources.bac__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panelLp);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.labelLaporan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJudul);
            this.Name = "FormLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.panelLp.ResumeLayout(false);
            this.panelLp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLpPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLpPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLp;
        private System.Windows.Forms.Label labelLpPembelian;
        private System.Windows.Forms.Label labelLpPenjualan;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxLpPembelian;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLpPenjualan;
        private Guna.UI2.WinForms.Guna2Button btnLpPembelian;
        private Guna.UI2.WinForms.Guna2Button btnLpPenjualan;
        private Guna.UI2.WinForms.Guna2PictureBox PictureLogo;
        private System.Windows.Forms.Label labelLaporan;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnJudul;
    }
}