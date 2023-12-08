namespace FashionFusion.View
{
    partial class FormLaporanPembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporanPembelian));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.printDocumentLaporan = new System.Drawing.Printing.PrintDocument();
            this.txtAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTotal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelLaporan = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.dtLaporanPembelian = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelLaporan = new System.Windows.Forms.Panel();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.printPreviewLaporanPb = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLaporanPembelian)).BeginInit();
            this.panelLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.Size = new System.Drawing.Size(165, 61);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // printDocumentLaporan
            // 
            this.printDocumentLaporan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLaporan_PrintPage_1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 16;
            // 
            // dtTotal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTotal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtTotal.ColumnHeadersHeight = 4;
            this.dtTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTotal.DefaultCellStyle = dataGridViewCellStyle3;
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
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(599, 418);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(187, 26);
            this.labelTotal.TabIndex = 84;
            this.labelTotal.Text = "Total Pembelian : ";
            // 
            // labelLaporan
            // 
            this.labelLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLaporan.AutoSize = true;
            this.labelLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporan.Location = new System.Drawing.Point(430, 82);
            this.labelLaporan.Name = "labelLaporan";
            this.labelLaporan.Size = new System.Drawing.Size(201, 26);
            this.labelLaporan.TabIndex = 2;
            this.labelLaporan.Text = "Laporan Pembelian";
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
            this.btnPrint.Size = new System.Drawing.Size(165, 61);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // dtLaporanPembelian
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtLaporanPembelian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtLaporanPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLaporanPembelian.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtLaporanPembelian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtLaporanPembelian.ColumnHeadersHeight = 4;
            this.dtLaporanPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtLaporanPembelian.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtLaporanPembelian.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtLaporanPembelian.Location = new System.Drawing.Point(81, 127);
            this.dtLaporanPembelian.Name = "dtLaporanPembelian";
            this.dtLaporanPembelian.RowHeadersVisible = false;
            this.dtLaporanPembelian.RowHeadersWidth = 62;
            this.dtLaporanPembelian.RowTemplate.Height = 28;
            this.dtLaporanPembelian.Size = new System.Drawing.Size(852, 242);
            this.dtLaporanPembelian.TabIndex = 0;
            this.dtLaporanPembelian.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtLaporanPembelian.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtLaporanPembelian.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtLaporanPembelian.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtLaporanPembelian.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtLaporanPembelian.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtLaporanPembelian.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtLaporanPembelian.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtLaporanPembelian.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtLaporanPembelian.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLaporanPembelian.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtLaporanPembelian.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtLaporanPembelian.ThemeStyle.HeaderStyle.Height = 4;
            this.dtLaporanPembelian.ThemeStyle.ReadOnly = false;
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.Height = 28;
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtLaporanPembelian.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelLaporan
            // 
            this.panelLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLaporan.BackColor = System.Drawing.Color.White;
            this.panelLaporan.Controls.Add(this.txtAdmin);
            this.panelLaporan.Controls.Add(this.labelAdmin);
            this.panelLaporan.Controls.Add(this.dtTotal);
            this.panelLaporan.Controls.Add(this.labelTotal);
            this.panelLaporan.Controls.Add(this.pictureLogo);
            this.panelLaporan.Controls.Add(this.dtLaporanPembelian);
            this.panelLaporan.Controls.Add(this.labelJudul);
            this.panelLaporan.Controls.Add(this.labelLaporan);
            this.panelLaporan.Location = new System.Drawing.Point(119, 56);
            this.panelLaporan.Name = "panelLaporan";
            this.panelLaporan.Size = new System.Drawing.Size(1020, 481);
            this.panelLaporan.TabIndex = 17;
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
            // printPreviewLaporanPb
            // 
            this.printPreviewLaporanPb.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewLaporanPb.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewLaporanPb.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewLaporanPb.Enabled = true;
            this.printPreviewLaporanPb.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewLaporanPb.Icon")));
            this.printPreviewLaporanPb.Name = "printPreviewDialog1";
            this.printPreviewLaporanPb.Visible = false;
            // 
            // FormLaporanPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionFusion.Properties.Resources.bac__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelLaporan);
            this.Name = "FormLaporanPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaporanPembelian";
            this.Load += new System.EventHandler(this.FormLaporanPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLaporanPembelian)).EndInit();
            this.panelLaporan.ResumeLayout(false);
            this.panelLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Drawing.Printing.PrintDocument printDocumentLaporan;
        private Guna.UI2.WinForms.Guna2TextBox txtAdmin;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelLaporan;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2DataGridView dtLaporanPembelian;
        private System.Windows.Forms.Panel panelLaporan;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;
        private System.Windows.Forms.PrintPreviewDialog printPreviewLaporanPb;
    }
}