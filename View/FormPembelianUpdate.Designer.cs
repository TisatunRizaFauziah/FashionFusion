namespace FashionFusion.View
{
    partial class FormPembelianUpdate
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
            this.dtTimeTglPembelian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPembelian = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelIdPakaian = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.txtIdPakaian = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdDistributor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.labelUpPembelian = new System.Windows.Forms.Label();
            this.dtPembelian = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTimeTglPembelian
            // 
            this.dtTimeTglPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtTimeTglPembelian.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtTimeTglPembelian.Checked = true;
            this.dtTimeTglPembelian.CustomFormat = " ";
            this.dtTimeTglPembelian.FillColor = System.Drawing.Color.White;
            this.dtTimeTglPembelian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTimeTglPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTimeTglPembelian.Location = new System.Drawing.Point(371, 460);
            this.dtTimeTglPembelian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTimeTglPembelian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTimeTglPembelian.Name = "dtTimeTglPembelian";
            this.dtTimeTglPembelian.Size = new System.Drawing.Size(256, 43);
            this.dtTimeTglPembelian.TabIndex = 79;
            this.dtTimeTglPembelian.Value = new System.DateTime(2023, 12, 2, 17, 4, 42, 799);
            this.dtTimeTglPembelian.ValueChanged += new System.EventHandler(this.dtTimeTglPembelian_ValueChanged);
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
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtIdPembelian
            // 
            this.txtIdPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdPembelian.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdPembelian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPembelian.DefaultText = "";
            this.txtIdPembelian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPembelian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPembelian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPembelian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPembelian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPembelian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPembelian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPembelian.Location = new System.Drawing.Point(371, 395);
            this.txtIdPembelian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPembelian.Name = "txtIdPembelian";
            this.txtIdPembelian.PasswordChar = '\0';
            this.txtIdPembelian.PlaceholderText = "";
            this.txtIdPembelian.SelectedText = "";
            this.txtIdPembelian.Size = new System.Drawing.Size(256, 43);
            this.txtIdPembelian.TabIndex = 77;
            // 
            // labelIdPakaian
            // 
            this.labelIdPakaian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdPakaian.AutoSize = true;
            this.labelIdPakaian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdPakaian.Location = new System.Drawing.Point(694, 395);
            this.labelIdPakaian.Name = "labelIdPakaian";
            this.labelIdPakaian.Size = new System.Drawing.Size(125, 25);
            this.labelIdPakaian.TabIndex = 76;
            this.labelIdPakaian.Text = "Id Pakaian   :";
            // 
            // labelJumlah
            // 
            this.labelJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(694, 460);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(127, 25);
            this.labelJumlah.TabIndex = 75;
            this.labelJumlah.Text = "Jumlah         :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "id Distributor               :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(107, 460);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(207, 25);
            this.labelTanggal.TabIndex = 73;
            this.labelTanggal.Text = "Tanggal Pembelian    :";
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
            this.txtIdPakaian.Location = new System.Drawing.Point(908, 395);
            this.txtIdPakaian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPakaian.Name = "txtIdPakaian";
            this.txtIdPakaian.PasswordChar = '\0';
            this.txtIdPakaian.PlaceholderText = "";
            this.txtIdPakaian.SelectedText = "";
            this.txtIdPakaian.Size = new System.Drawing.Size(244, 43);
            this.txtIdPakaian.TabIndex = 72;
            // 
            // txtIdDistributor
            // 
            this.txtIdDistributor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdDistributor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdDistributor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdDistributor.DefaultText = "";
            this.txtIdDistributor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdDistributor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdDistributor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdDistributor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdDistributor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdDistributor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdDistributor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdDistributor.Location = new System.Drawing.Point(371, 525);
            this.txtIdDistributor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDistributor.Name = "txtIdDistributor";
            this.txtIdDistributor.PasswordChar = '\0';
            this.txtIdDistributor.PlaceholderText = "";
            this.txtIdDistributor.SelectedText = "";
            this.txtIdDistributor.Size = new System.Drawing.Size(256, 43);
            this.txtIdDistributor.TabIndex = 71;
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
            this.txtJumlah.Location = new System.Drawing.Point(908, 460);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.Size = new System.Drawing.Size(244, 43);
            this.txtJumlah.TabIndex = 70;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(108, 395);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(206, 25);
            this.labelId.TabIndex = 69;
            this.labelId.Text = "Id Pembelian               :";
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
            this.btnExit.TabIndex = 68;
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
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // labelUpPembelian
            // 
            this.labelUpPembelian.AutoSize = true;
            this.labelUpPembelian.BackColor = System.Drawing.Color.Transparent;
            this.labelUpPembelian.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpPembelian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUpPembelian.Location = new System.Drawing.Point(218, 26);
            this.labelUpPembelian.Name = "labelUpPembelian";
            this.labelUpPembelian.Size = new System.Drawing.Size(651, 95);
            this.labelUpPembelian.TabIndex = 65;
            this.labelUpPembelian.Text = "Update Pembelian";
            // 
            // dtPembelian
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtPembelian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPembelian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtPembelian.ColumnHeadersHeight = 4;
            this.dtPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPembelian.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtPembelian.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtPembelian.Location = new System.Drawing.Point(112, 127);
            this.dtPembelian.Name = "dtPembelian";
            this.dtPembelian.RowHeadersVisible = false;
            this.dtPembelian.RowHeadersWidth = 62;
            this.dtPembelian.RowTemplate.Height = 28;
            this.dtPembelian.Size = new System.Drawing.Size(1040, 234);
            this.dtPembelian.TabIndex = 64;
            this.dtPembelian.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtPembelian.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtPembelian.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtPembelian.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtPembelian.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtPembelian.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtPembelian.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtPembelian.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPembelian.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtPembelian.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPembelian.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtPembelian.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtPembelian.ThemeStyle.HeaderStyle.Height = 4;
            this.dtPembelian.ThemeStyle.ReadOnly = false;
            this.dtPembelian.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtPembelian.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtPembelian.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPembelian.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtPembelian.ThemeStyle.RowsStyle.Height = 28;
            this.dtPembelian.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtPembelian.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtPembelian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPembelian_CellContentClick_1);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = global::FashionFusion.Properties.Resources.Black_and_White_Elegant_Initials_Monogram_Logo__1_;
            this.pictureLogo.ImageRotate = 0F;
            this.pictureLogo.Location = new System.Drawing.Point(113, 26);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(99, 95);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 66;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.UseTransparentBackground = true;
            // 
            // FormPembelianUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FashionFusion.Properties.Resources.bac__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.dtTimeTglPembelian);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtIdPembelian);
            this.Controls.Add(this.labelIdPakaian);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.txtIdPakaian);
            this.Controls.Add(this.txtIdDistributor);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.labelUpPembelian);
            this.Controls.Add(this.dtPembelian);
            this.Name = "FormPembelianUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPembelianUpdate";
            this.Load += new System.EventHandler(this.FormPembelianUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtTimeTglPembelian;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPembelian;
        private System.Windows.Forms.Label labelIdPakaian;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTanggal;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPakaian;
        private Guna.UI2.WinForms.Guna2TextBox txtIdDistributor;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private System.Windows.Forms.Label labelId;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;
        private System.Windows.Forms.Label labelUpPembelian;
        private Guna.UI2.WinForms.Guna2DataGridView dtPembelian;
    }
}