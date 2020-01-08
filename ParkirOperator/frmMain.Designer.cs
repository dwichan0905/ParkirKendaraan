namespace ParkirCustomer {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("[F1] TENTANG");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("[F3] GANTI SHIFT");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("[F6] UBAH KUOTA PARKIR");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("[F9] KELUAR");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("[F11] LIHAT TRANSAKSI");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("[F12] PENG. AKUN");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("[INS] INPUT NO. PARKIR");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("[F2] BAYAR & CETAK");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("[DEL] Batal");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penggunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koneksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gantiShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masukkanNomorParkirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayarCetakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batalBayarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuotaParkirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grStatus = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grUtama = new System.Windows.Forms.GroupBox();
            this.lbTot = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.grJam = new System.Windows.Forms.GroupBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.grParkir = new System.Windows.Forms.GroupBox();
            this.txtError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtParkir = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grResult = new System.Windows.Forms.GroupBox();
            this.hdTanggal = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.lbHarga = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDur = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbJamParkir = new System.Windows.Forms.Label();
            this.lbTgl = new System.Windows.Forms.Label();
            this.lbJenis = new System.Windows.Forms.Label();
            this.lbParkir = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrHide = new System.Windows.Forms.Timer(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.grStatus.SuspendLayout();
            this.grUtama.SuspendLayout();
            this.grJam.SuspendLayout();
            this.grParkir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtParkir)).BeginInit();
            this.grResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berkasToolStripMenuItem,
            this.aksiToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.bantuanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // berkasToolStripMenuItem
            // 
            this.berkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengaturanToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gantiShiftToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.berkasToolStripMenuItem.Name = "berkasToolStripMenuItem";
            this.berkasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.berkasToolStripMenuItem.Text = "&Berkas";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penggunaToolStripMenuItem,
            this.koneksiToolStripMenuItem});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // penggunaToolStripMenuItem
            // 
            this.penggunaToolStripMenuItem.Name = "penggunaToolStripMenuItem";
            this.penggunaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.penggunaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.penggunaToolStripMenuItem.Text = "Pengguna...";
            this.penggunaToolStripMenuItem.Click += new System.EventHandler(this.penggunaToolStripMenuItem_Click);
            // 
            // koneksiToolStripMenuItem
            // 
            this.koneksiToolStripMenuItem.Name = "koneksiToolStripMenuItem";
            this.koneksiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.koneksiToolStripMenuItem.Text = "Aplikasi";
            this.koneksiToolStripMenuItem.Click += new System.EventHandler(this.koneksiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // gantiShiftToolStripMenuItem
            // 
            this.gantiShiftToolStripMenuItem.Name = "gantiShiftToolStripMenuItem";
            this.gantiShiftToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.gantiShiftToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gantiShiftToolStripMenuItem.Text = "Ganti Shift...";
            this.gantiShiftToolStripMenuItem.Click += new System.EventHandler(this.gantiShiftToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // aksiToolStripMenuItem
            // 
            this.aksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masukkanNomorParkirToolStripMenuItem,
            this.bayarCetakToolStripMenuItem,
            this.batalBayarToolStripMenuItem});
            this.aksiToolStripMenuItem.Name = "aksiToolStripMenuItem";
            this.aksiToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.aksiToolStripMenuItem.Text = "Aksi";
            this.aksiToolStripMenuItem.Visible = false;
            // 
            // masukkanNomorParkirToolStripMenuItem
            // 
            this.masukkanNomorParkirToolStripMenuItem.Name = "masukkanNomorParkirToolStripMenuItem";
            this.masukkanNomorParkirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.masukkanNomorParkirToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.masukkanNomorParkirToolStripMenuItem.Text = "Masukkan Nomor Parkir";
            this.masukkanNomorParkirToolStripMenuItem.Click += new System.EventHandler(this.masukkanNomorParkirToolStripMenuItem_Click);
            // 
            // bayarCetakToolStripMenuItem
            // 
            this.bayarCetakToolStripMenuItem.Name = "bayarCetakToolStripMenuItem";
            this.bayarCetakToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.bayarCetakToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.bayarCetakToolStripMenuItem.Text = "Bayar && Cetak";
            this.bayarCetakToolStripMenuItem.Click += new System.EventHandler(this.bayarCetakToolStripMenuItem_Click);
            // 
            // batalBayarToolStripMenuItem
            // 
            this.batalBayarToolStripMenuItem.Name = "batalBayarToolStripMenuItem";
            this.batalBayarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.batalBayarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.batalBayarToolStripMenuItem.Text = "Batal Bayar";
            this.batalBayarToolStripMenuItem.Click += new System.EventHandler(this.batalBayarToolStripMenuItem_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatorToolStripMenuItem,
            this.karyawanToolStripMenuItem,
            this.kuotaParkirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.transaksiToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterDataToolStripMenuItem.Text = "&Master Data";
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.operatorToolStripMenuItem.Text = "Operator";
            this.operatorToolStripMenuItem.Click += new System.EventHandler(this.operatorToolStripMenuItem_Click);
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            this.karyawanToolStripMenuItem.Click += new System.EventHandler(this.karyawanToolStripMenuItem_Click);
            // 
            // kuotaParkirToolStripMenuItem
            // 
            this.kuotaParkirToolStripMenuItem.Name = "kuotaParkirToolStripMenuItem";
            this.kuotaParkirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.kuotaParkirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kuotaParkirToolStripMenuItem.Text = "Kuota Parkir";
            this.kuotaParkirToolStripMenuItem.Click += new System.EventHandler(this.kuotaParkirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 6);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatTransaksiToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // lihatTransaksiToolStripMenuItem
            // 
            this.lihatTransaksiToolStripMenuItem.Name = "lihatTransaksiToolStripMenuItem";
            this.lihatTransaksiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.lihatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.lihatTransaksiToolStripMenuItem.Text = "Lihat Transaksi...";
            this.lihatTransaksiToolStripMenuItem.Click += new System.EventHandler(this.lihatTransaksiToolStripMenuItem_Click);
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangToolStripMenuItem});
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bantuanToolStripMenuItem.Text = "Ban&tuan";
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            this.tentangToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tentangToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.tentangToolStripMenuItem.Text = "Tentang...";
            this.tentangToolStripMenuItem.Click += new System.EventHandler(this.tentangToolStripMenuItem_Click);
            // 
            // grStatus
            // 
            this.grStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grStatus.BackColor = System.Drawing.Color.Black;
            this.grStatus.Controls.Add(this.listView1);
            this.grStatus.Location = new System.Drawing.Point(0, 486);
            this.grStatus.Name = "grStatus";
            this.grStatus.Size = new System.Drawing.Size(784, 74);
            this.grStatus.TabIndex = 1;
            this.grStatus.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.Location = new System.Drawing.Point(6, 14);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(772, 54);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            // 
            // grUtama
            // 
            this.grUtama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grUtama.BackColor = System.Drawing.Color.Black;
            this.grUtama.Controls.Add(this.lbTot);
            this.grUtama.Controls.Add(this.txtUser);
            this.grUtama.Controls.Add(this.grJam);
            this.grUtama.Controls.Add(this.grParkir);
            this.grUtama.Controls.Add(this.dtParkir);
            this.grUtama.Location = new System.Drawing.Point(0, 25);
            this.grUtama.Name = "grUtama";
            this.grUtama.Size = new System.Drawing.Size(784, 467);
            this.grUtama.TabIndex = 2;
            this.grUtama.TabStop = false;
            // 
            // lbTot
            // 
            this.lbTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTot.AutoSize = true;
            this.lbTot.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTot.ForeColor = System.Drawing.Color.White;
            this.lbTot.Location = new System.Drawing.Point(12, 437);
            this.lbTot.Name = "lbTot";
            this.lbTot.Size = new System.Drawing.Size(480, 18);
            this.lbTot.TabIndex = 3;
            this.lbTot.Text = "Banyaknya kendaraan terparkir kali ini adalah 12 kendaraan.";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(610, 437);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(168, 18);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "User: Tiara Larasati";
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grJam
            // 
            this.grJam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grJam.Controls.Add(this.lblTanggal);
            this.grJam.Controls.Add(this.lblJam);
            this.grJam.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grJam.ForeColor = System.Drawing.Color.White;
            this.grJam.Location = new System.Drawing.Point(475, 12);
            this.grJam.Name = "grJam";
            this.grJam.Size = new System.Drawing.Size(297, 108);
            this.grJam.TabIndex = 1;
            this.grJam.TabStop = false;
            this.grJam.Text = "Jam && Tanggal";
            // 
            // lblTanggal
            // 
            this.lblTanggal.Location = new System.Drawing.Point(16, 76);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(263, 19);
            this.lblTanggal.TabIndex = 1;
            this.lblTanggal.Text = "Selasa, 31 Desember 2019";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJam
            // 
            this.lblJam.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.Location = new System.Drawing.Point(6, 21);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(285, 52);
            this.lblJam.TabIndex = 0;
            this.lblJam.Text = "12:24:35";
            this.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grParkir
            // 
            this.grParkir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grParkir.Controls.Add(this.txtError);
            this.grParkir.Controls.Add(this.label1);
            this.grParkir.Controls.Add(this.textBox1);
            this.grParkir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grParkir.ForeColor = System.Drawing.Color.White;
            this.grParkir.Location = new System.Drawing.Point(12, 12);
            this.grParkir.Name = "grParkir";
            this.grParkir.Size = new System.Drawing.Size(457, 108);
            this.grParkir.TabIndex = 0;
            this.grParkir.TabStop = false;
            this.grParkir.Text = "Nomor Parkir:";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Location = new System.Drawing.Point(13, 79);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(64, 18);
            this.txtError.TabIndex = 2;
            this.txtError.Text = "%ERROR%";
            this.txtError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtError.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(180, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "[ENTER] Proses Cek Nomor Parkir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(16, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dtParkir
            // 
            this.dtParkir.AllowUserToAddRows = false;
            this.dtParkir.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dtParkir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtParkir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtParkir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtParkir.BackgroundColor = System.Drawing.Color.Black;
            this.dtParkir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtParkir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtParkir.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtParkir.Location = new System.Drawing.Point(12, 126);
            this.dtParkir.MultiSelect = false;
            this.dtParkir.Name = "dtParkir";
            this.dtParkir.ReadOnly = true;
            this.dtParkir.RowHeadersVisible = false;
            this.dtParkir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtParkir.ShowCellErrors = false;
            this.dtParkir.ShowCellToolTips = false;
            this.dtParkir.ShowEditingIcon = false;
            this.dtParkir.ShowRowErrors = false;
            this.dtParkir.Size = new System.Drawing.Size(760, 299);
            this.dtParkir.TabIndex = 2;
            this.dtParkir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtParkir_CellClick);
            this.dtParkir.DoubleClick += new System.EventHandler(this.dtParkir_DoubleClick);
            this.dtParkir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtParkir_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grResult
            // 
            this.grResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grResult.Controls.Add(this.hdTanggal);
            this.grResult.Controls.Add(this.listView2);
            this.grResult.Controls.Add(this.lbHarga);
            this.grResult.Controls.Add(this.label14);
            this.grResult.Controls.Add(this.lbDur);
            this.grResult.Controls.Add(this.label12);
            this.grResult.Controls.Add(this.lbJamParkir);
            this.grResult.Controls.Add(this.lbTgl);
            this.grResult.Controls.Add(this.lbJenis);
            this.grResult.Controls.Add(this.lbParkir);
            this.grResult.Controls.Add(this.label7);
            this.grResult.Controls.Add(this.label6);
            this.grResult.Controls.Add(this.label5);
            this.grResult.Controls.Add(this.label3);
            this.grResult.Controls.Add(this.label2);
            this.grResult.ForeColor = System.Drawing.Color.White;
            this.grResult.Location = new System.Drawing.Point(160, 116);
            this.grResult.Name = "grResult";
            this.grResult.Size = new System.Drawing.Size(498, 364);
            this.grResult.TabIndex = 4;
            this.grResult.TabStop = false;
            this.grResult.Visible = false;
            // 
            // hdTanggal
            // 
            this.hdTanggal.AutoSize = true;
            this.hdTanggal.Location = new System.Drawing.Point(378, 339);
            this.hdTanggal.Name = "hdTanggal";
            this.hdTanggal.Size = new System.Drawing.Size(114, 13);
            this.hdTanggal.TabIndex = 14;
            this.hdTanggal.Text = "yyyy-MM-dd HH.mm.ss";
            this.hdTanggal.Visible = false;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.AutoArrange = false;
            this.listView2.BackColor = System.Drawing.Color.Black;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.White;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9});
            this.listView2.Location = new System.Drawing.Point(6, 327);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(486, 32);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.SmallIcon;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            this.listView2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView2_KeyPress);
            // 
            // lbHarga
            // 
            this.lbHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHarga.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHarga.Location = new System.Drawing.Point(86, 227);
            this.lbHarga.Name = "lbHarga";
            this.lbHarga.Size = new System.Drawing.Size(408, 55);
            this.lbHarga.TabIndex = 12;
            this.lbHarga.Text = "Rp2000";
            this.lbHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbHarga.UseCompatibleTextRendering = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 11;
            this.label14.Text = "Harga:";
            // 
            // lbDur
            // 
            this.lbDur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDur.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDur.Location = new System.Drawing.Point(167, 196);
            this.lbDur.Name = "lbDur";
            this.lbDur.Size = new System.Drawing.Size(325, 23);
            this.lbDur.TabIndex = 10;
            this.lbDur.Text = "1 jam 2 menit 35 detik";
            this.lbDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDur.UseCompatibleTextRendering = true;
            this.lbDur.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Durasi Parkir:";
            // 
            // lbJamParkir
            // 
            this.lbJamParkir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJamParkir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJamParkir.Location = new System.Drawing.Point(249, 166);
            this.lbJamParkir.Name = "lbJamParkir";
            this.lbJamParkir.Size = new System.Drawing.Size(245, 19);
            this.lbJamParkir.TabIndex = 8;
            this.lbJamParkir.Text = "12:25:13 WIB";
            this.lbJamParkir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbJamParkir.UseCompatibleTextRendering = true;
            // 
            // lbTgl
            // 
            this.lbTgl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTgl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTgl.Location = new System.Drawing.Point(177, 133);
            this.lbTgl.Name = "lbTgl";
            this.lbTgl.Size = new System.Drawing.Size(315, 20);
            this.lbTgl.TabIndex = 7;
            this.lbTgl.Text = "Jum\'at, 21 Desember 2019";
            this.lbTgl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTgl.UseCompatibleTextRendering = true;
            // 
            // lbJenis
            // 
            this.lbJenis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJenis.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJenis.Location = new System.Drawing.Point(252, 102);
            this.lbJenis.Name = "lbJenis";
            this.lbJenis.Size = new System.Drawing.Size(242, 18);
            this.lbJenis.TabIndex = 6;
            this.lbJenis.Text = "Sepeda Motor";
            this.lbJenis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbJenis.UseCompatibleTextRendering = true;
            this.lbJenis.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbParkir
            // 
            this.lbParkir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbParkir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParkir.Location = new System.Drawing.Point(226, 67);
            this.lbParkir.Name = "lbParkir";
            this.lbParkir.Size = new System.Drawing.Size(266, 23);
            this.lbParkir.TabIndex = 5;
            this.lbParkir.Text = "20191212110305";
            this.lbParkir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbParkir.UseCompatibleTextRendering = true;
            this.lbParkir.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(483, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kendaraan ditemukan!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Jam Masuk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tanggal Masuk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jenis Kendaraan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nomor Parkir:";
            // 
            // tmrHide
            // 
            this.tmrHide.Interval = 3000;
            this.tmrHide.Tick += new System.EventHandler(this.tmrHide_Tick);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grResult);
            this.Controls.Add(this.grUtama);
            this.Controls.Add(this.grStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridPark Smart Parking System: Operator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grStatus.ResumeLayout(false);
            this.grUtama.ResumeLayout(false);
            this.grUtama.PerformLayout();
            this.grJam.ResumeLayout(false);
            this.grParkir.ResumeLayout(false);
            this.grParkir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtParkir)).EndInit();
            this.grResult.ResumeLayout(false);
            this.grResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem berkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penggunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koneksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gantiShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masukkanNomorParkirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuotaParkirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
        private System.Windows.Forms.GroupBox grStatus;
        private System.Windows.Forms.GroupBox grUtama;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grJam;
        private System.Windows.Forms.GroupBox grParkir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtParkir;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.ToolStripMenuItem bayarCetakToolStripMenuItem;
        private System.Windows.Forms.Label lbTot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grResult;
        private System.Windows.Forms.Label lbTgl;
        private System.Windows.Forms.Label lbJenis;
        private System.Windows.Forms.Label lbParkir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHarga;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbDur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbJamParkir;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripMenuItem batalBayarToolStripMenuItem;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Timer tmrHide;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label hdTanggal;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        public System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Timer timer3;
    }
}