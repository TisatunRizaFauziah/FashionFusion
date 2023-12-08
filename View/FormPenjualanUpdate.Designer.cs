namespace FashionFusion.View
{
    partial class FormPenjualanUpdate
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
            this.dtTimeTglPenjualan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPenjualan = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelIdPakaian = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.txtIdPakaian = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdPelanggan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.labelAddPenjualan = new System.Windows.Forms.Label();
            this.dtPenjualan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTimeTglPenjualan
            // 
            this.dtTimeTglPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtTimeTglPenjualan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtTimeTglPenjualan.Checked = true;
            this.dtTimeTglPenjualan.CustomFormat = " ";
            this.dtTimeTglPenjualan.FillColor = System.Drawing.Color.White;
            this.dtTimeTglPenjualan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTimeTglPenjualan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeTglPenjualan.Location = new System.Drawing.Point(359, 460);
            this.dtTimeTglPenjualan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTimeTglPenjualan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTimeTglPenjualan.Name = "dtTimeTglPenjualan";
            this.dtTimeTglPenjualan.Size = new System.Drawing.Size(268, 43);
            this.dtTimeTglPenjualan.TabIndex = 111;
            this.dtTimeTglPenjualan.Value = new System.DateTime(2023, 12, 2, 17, 4, 42, 799);
            this.dtTimeTglPenjualan.ValueChanged += new System.EventHandler(this.dtTimeTglPenjualan_ValueChanged_1);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 5;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(866, 593);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 45);
            this.btnClear.TabIndex = 110;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtIdPenjualan
            // 
            this.txtIdPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdPenjualan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPenjualan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPenjualan.DefaultText = "";
            this.txtIdPenjualan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPenjualan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPenjualan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPenjualan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPenjualan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPenjualan.Location = new System.Drawing.Point(359, 395);
            this.txtIdPenjualan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPenjualan.Name = "txtIdPenjualan";
            this.txtIdPenjualan.PasswordChar = '\0';
            this.txtIdPenjualan.PlaceholderText = "";
            this.txtIdPenjualan.SelectedText = "";
            this.txtIdPenjualan.Size = new System.Drawing.Size(268, 43);
            this.txtIdPenjualan.TabIndex = 109;
            // 
            // labelIdPakaian
            // 
            this.labelIdPakaian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdPakaian.AutoSize = true;
            this.labelIdPakaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdPakaian.Location = new System.Drawing.Point(694, 395);
            this.labelIdPakaian.Name = "labelIdPakaian";
            this.labelIdPakaian.Size = new System.Drawing.Size(125, 25);
            this.labelIdPakaian.TabIndex = 108;
            this.labelIdPakaian.Text = "Id Pakaian   :";
            // 
            // labelJumlah
            // 
            this.labelJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(694, 460);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(122, 25);
            this.labelJumlah.TabIndex = 107;
            this.labelJumlah.Text = "Jumlah        :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "id Pelanggan             :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(107, 460);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(202, 25);
            this.labelTanggal.TabIndex = 105;
            this.labelTanggal.Text = "Tanggal Penjualan    :";
            // 
            // txtIdPakaian
            // 
            this.txtIdPakaian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdPakaian.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPakaian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPakaian.DefaultText = "";
            this.txtIdPakaian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPakaian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPakaian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPakaian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPakaian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPakaian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPakaian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPakaian.Location = new System.Drawing.Point(888, 395);
            this.txtIdPakaian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPakaian.Name = "txtIdPakaian";
            this.txtIdPakaian.PasswordChar = '\0';
            this.txtIdPakaian.PlaceholderText = "";
            this.txtIdPakaian.SelectedText = "";
            this.txtIdPakaian.Size = new System.Drawing.Size(264, 43);
            this.txtIdPakaian.TabIndex = 104;
            // 
            // txtIdPelanggan
            // 
            this.txtIdPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdPelanggan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPelanggan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPelanggan.DefaultText = "";
            this.txtIdPelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPelanggan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPelanggan.Location = new System.Drawing.Point(359, 525);
            this.txtIdPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPelanggan.Name = "txtIdPelanggan";
            this.txtIdPelanggan.PasswordChar = '\0';
            this.txtIdPelanggan.PlaceholderText = "";
            this.txtIdPelanggan.SelectedText = "";
            this.txtIdPelanggan.Size = new System.Drawing.Size(268, 43);
            this.txtIdPelanggan.TabIndex = 103;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.DefaultText = "";
            this.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.Location = new System.Drawing.Point(888, 460);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.Size = new System.Drawing.Size(264, 43);
            this.txtJumlah.TabIndex = 102;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(108, 395);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(196, 25);
            this.labelId.TabIndex = 101;
            this.labelId.Text = "Id Penjualan              :";
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
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(113, 593);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 45);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1035, 593);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 45);
            this.btnUpdate.TabIndex = 99;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // labelAddPenjualan
            // 
            this.labelAddPenjualan.AutoSize = true;
            this.labelAddPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.labelAddPenjualan.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPenjualan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAddPenjualan.Location = new System.Drawing.Point(218, 26);
            this.labelAddPenjualan.Name = "labelAddPenjualan";
            this.labelAddPenjualan.Size = new System.Drawing.Size(665, 95);
            this.labelAddPenjualan.TabIndex = 97;
            this.labelAddPenjualan.Text = " Update Penjualan";
            // 
            // dtPenjualan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtPenjualan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtPenjualan.ColumnHeadersHeight = 4;
            this.dtPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPenjualan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtPenjualan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtPenjualan.Location = new System.Drawing.Point(112, 127);
            this.dtPenjualan.Name = "dtPenjualan";
            this.dtPenjualan.RowHeadersVisible = false;
            this.dtPenjualan.RowHeadersWidth = 62;
            this.dtPenjualan.RowTemplate.Height = 28;
            this.dtPenjualan.Size = new System.Drawing.Size(1040, 234);
            this.dtPenjualan.TabIndex = 96;
            this.dtPenjualan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtPenjualan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtPenjualan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtPenjualan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtPenjualan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtPenjualan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtPenjualan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtPenjualan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPenjualan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtPenjualan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPenjualan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtPenjualan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtPenjualan.ThemeStyle.HeaderStyle.Height = 4;
            this.dtPenjualan.ThemeStyle.ReadOnly = false;
            this.dtPenjualan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtPenjualan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtPenjualan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPenjualan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtPenjualan.ThemeStyle.RowsStyle.Height = 28;
            this.dtPenjualan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtPenjualan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPenjualan_CellContentClick_1);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = global::FashionFusion.Properties.Resources.Black_and_White_Elegant_Initials_Monogram_Logo__1_;
            this.pictureLogo.ImageRotate = 0F;
            this.pictureLogo.Location = new System.Drawing.Point(107, 26);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(105, 98);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 112;
            this.pictureLogo.TabStop = false;
            // 
            // FormPenjualanUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionFusion.Properties.Resources.bac__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.dtTimeTglPenjualan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtIdPenjualan);
            this.Controls.Add(this.labelIdPakaian);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.txtIdPakaian);
            this.Controls.Add(this.txtIdPelanggan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelAddPenjualan);
            this.Controls.Add(this.dtPenjualan);
            this.Name = "FormPenjualanUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPenjualanUpdate";
            this.Load += new System.EventHandler(this.FormPenjualanUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtTimeTglPenjualan;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPenjualan;
        private System.Windows.Forms.Label labelIdPakaian;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTanggal;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPakaian;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPelanggan;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private System.Windows.Forms.Label labelId;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label labelAddPenjualan;
        private Guna.UI2.WinForms.Guna2DataGridView dtPenjualan;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;
    }
}