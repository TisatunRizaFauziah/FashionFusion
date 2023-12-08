namespace FashionFusion.View
{
    partial class FormLaporanPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanPenjualan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewLaporanPj = new System.Windows.Forms.PrintPreviewDialog();
            this.labelLaporan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.dtLaporanPenjualan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dtTotal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.txtAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelLaporan = new System.Windows.Forms.Panel();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.printDocumentLaporan = new System.Drawing.Printing.PrintDocument();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtLaporanPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTotal)).BeginInit();
            this.panelLaporan.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewLaporanPj
            // 
            this.printPreviewLaporanPj.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewLaporanPj.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewLaporanPj.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewLaporanPj.Enabled = true;
            this.printPreviewLaporanPj.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewLaporanPj.Icon")));
            this.printPreviewLaporanPj.Name = "printPreviewDialog1";
            this.printPreviewLaporanPj.Visible = false;
            // 
            // labelLaporan
            // 
            this.labelLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLaporan.AutoSize = true;
            this.labelLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporan.Location = new System.Drawing.Point(430, 82);
            this.labelLaporan.Name = "labelLaporan";
            this.labelLaporan.Size = new System.Drawing.Size(194, 26);
            this.labelLaporan.TabIndex = 2;
            this.labelLaporan.Text = "Laporan Penjualan";
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(394, 26);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(308, 52);
            this.labelJudul.TabIndex = 4;
            this.labelJudul.Text = "FashionFusion";
            // 
            // dtLaporanPenjualan
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dtLaporanPenjualan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtLaporanPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLaporanPenjualan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLaporanPenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtLaporanPenjualan.ColumnHeadersHeight = 4;
            this.dtLaporanPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLaporanPenjualan.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtLaporanPenjualan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtLaporanPenjualan.Location = new System.Drawing.Point(81, 127);
            this.dtLaporanPenjualan.Name = "dtLaporanPenjualan";
            this.dtLaporanPenjualan.RowHeadersVisible = false;
            this.dtLaporanPenjualan.RowHeadersWidth = 62;
            this.dtLaporanPenjualan.RowTemplate.Height = 28;
            this.dtLaporanPenjualan.Size = new System.Drawing.Size(852, 242);
            this.dtLaporanPenjualan.TabIndex = 0;
            this.dtLaporanPenjualan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtLaporanPenjualan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtLaporanPenjualan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtLaporanPenjualan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtLaporanPenjualan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtLaporanPenjualan.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtLaporanPenjualan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtLaporanPenjualan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtLaporanPenjualan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtLaporanPenjualan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLaporanPenjualan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtLaporanPenjualan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtLaporanPenjualan.ThemeStyle.HeaderStyle.Height = 4;
            this.dtLaporanPenjualan.ThemeStyle.ReadOnly = false;
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.Height = 28;
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtLaporanPenjualan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = global::FashionFusion.Properties.Resources.Black_and_White_Elegant_Initials_Monogram_Logo;
            this.pictureLogo.ImageRotate = 0F;
            this.pictureLogo.Location = new System.Drawing.Point(289, 26);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(99, 95);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 83;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.UseTransparentBackground = true;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(606, 414);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(180, 26);
            this.labelTotal.TabIndex = 84;
            this.labelTotal.Text = "Total Penjualan : ";
            // 
            // dtTotal
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTotal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtTotal.ColumnHeadersHeight = 4;
            this.dtTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTotal.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtTotal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtTotal.Location = new System.Drawing.Point(792, 404);
            this.dtTotal.Name = "dtTotal";
            this.dtTotal.RowHeadersVisible = false;
            this.dtTotal.RowHeadersWidth = 62;
            this.dtTotal.RowTemplate.Height = 28;
            this.dtTotal.Size = new System.Drawing.Size(141, 56);
            this.dtTotal.TabIndex = 85;
            this.dtTotal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtTotal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtTotal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtTotal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtTotal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtTotal.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtTotal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtTotal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTotal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtTotal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTotal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtTotal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtTotal.ThemeStyle.HeaderStyle.Height = 4;
            this.dtTotal.ThemeStyle.ReadOnly = false;
            this.dtTotal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtTotal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtTotal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTotal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtTotal.ThemeStyle.RowsStyle.Height = 28;
            this.dtTotal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtTotal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(76, 418);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(99, 29);
            this.labelAdmin.TabIndex = 86;
            this.labelAdmin.Text = "Admin : ";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAdmin.BorderColor = System.Drawing.Color.Black;
            this.txtAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdmin.DefaultText = "";
            this.txtAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdmin.Location = new System.Drawing.Point(189, 414);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.PasswordChar = '\0';
            this.txtAdmin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAdmin.PlaceholderText = "Masukan Nama Admin";
            this.txtAdmin.SelectedText = "";
            this.txtAdmin.Size = new System.Drawing.Size(244, 33);
            this.txtAdmin.TabIndex = 87;
            // 
            // panelLaporan
            // 
            this.panelLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLaporan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLaporan.Controls.Add(this.txtAdmin);
            this.panelLaporan.Controls.Add(this.labelAdmin);
            this.panelLaporan.Controls.Add(this.dtTotal);
            this.panelLaporan.Controls.Add(this.labelTotal);
            this.panelLaporan.Controls.Add(this.pictureLogo);
            this.panelLaporan.Controls.Add(this.dtLaporanPenjualan);
            this.panelLaporan.Controls.Add(this.labelJudul);
            this.panelLaporan.Controls.Add(this.labelLaporan);
            this.panelLaporan.Location = new System.Drawing.Point(119, 56);
            this.panelLaporan.Name = "panelLaporan";
            this.panelLaporan.Size = new System.Drawing.Size(1020, 481);
            this.panelLaporan.TabIndex = 12;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(974, 565);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 59);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // printDocumentLaporan
            // 
            this.printDocumentLaporan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLaporan_PrintPage_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 5;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(119, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 59);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // FormLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionFusion.Properties.Resources.bac__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 664);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelLaporan);
            this.Name = "FormLaporanPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporanPenjualan";
            this.Load += new System.EventHandler(this.FormLaporanPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLaporanPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTotal)).EndInit();
            this.panelLaporan.ResumeLayout(false);
            this.panelLaporan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewLaporanPj;
        private System.Windows.Forms.Label labelLaporan;
        private System.Windows.Forms.Label labelJudul;
        private Guna.UI2.WinForms.Guna2DataGridView dtLaporanPenjualan;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;
        private System.Windows.Forms.Label labelTotal;
        private Guna.UI2.WinForms.Guna2DataGridView dtTotal;
        private System.Windows.Forms.Label labelAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtAdmin;
        private System.Windows.Forms.Panel panelLaporan;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocumentLaporan;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}