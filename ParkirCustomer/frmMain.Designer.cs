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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabled2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabled3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "GridPark Smart Parking System";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(969, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Silakan pilih jenis kendaraan Anda:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJam
            // 
            this.lblJam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJam.BackColor = System.Drawing.SystemColors.Control;
            this.lblJam.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.Location = new System.Drawing.Point(826, 0);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(173, 37);
            this.lblJam.TabIndex = 5;
            this.lblJam.Text = "12:25:39";
            this.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            this.lblTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTanggal.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(822, 37);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(177, 24);
            this.lblTanggal.TabIndex = 6;
            this.lblTanggal.Text = "December 12, 2020";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTanggal.Click += new System.EventHandler(this.lblTanggal_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(414, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 56);
            this.button4.TabIndex = 7;
            this.button4.Text = "Karyawan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 37);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aksiToolStripMenuItem
            // 
            this.aksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorToolStripMenuItem,
            this.mobilToolStripMenuItem,
            this.karyawanToolStripMenuItem,
            this.pengaturanToolStripMenuItem,
            this.disabledToolStripMenuItem,
            this.disabled2ToolStripMenuItem,
            this.disabled3ToolStripMenuItem});
            this.aksiToolStripMenuItem.Name = "aksiToolStripMenuItem";
            this.aksiToolStripMenuItem.Size = new System.Drawing.Size(41, 33);
            this.aksiToolStripMenuItem.Text = "Aksi";
            // 
            // motorToolStripMenuItem
            // 
            this.motorToolStripMenuItem.Name = "motorToolStripMenuItem";
            this.motorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.motorToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.motorToolStripMenuItem.Text = "Motor";
            this.motorToolStripMenuItem.Visible = false;
            this.motorToolStripMenuItem.Click += new System.EventHandler(this.motorToolStripMenuItem_Click);
            // 
            // mobilToolStripMenuItem
            // 
            this.mobilToolStripMenuItem.Name = "mobilToolStripMenuItem";
            this.mobilToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mobilToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mobilToolStripMenuItem.Text = "Mobil";
            this.mobilToolStripMenuItem.Visible = false;
            this.mobilToolStripMenuItem.Click += new System.EventHandler(this.mobilToolStripMenuItem_Click);
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            this.karyawanToolStripMenuItem.Visible = false;
            this.karyawanToolStripMenuItem.Click += new System.EventHandler(this.karyawanToolStripMenuItem_Click);
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F8)));
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            this.pengaturanToolStripMenuItem.Visible = false;
            this.pengaturanToolStripMenuItem.Click += new System.EventHandler(this.pengaturanToolStripMenuItem_Click);
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.disabledToolStripMenuItem.Text = "disabled";
            this.disabledToolStripMenuItem.Visible = false;
            // 
            // disabled2ToolStripMenuItem
            // 
            this.disabled2ToolStripMenuItem.Name = "disabled2ToolStripMenuItem";
            this.disabled2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Tab)));
            this.disabled2ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.disabled2ToolStripMenuItem.Text = "disabled 2";
            this.disabled2ToolStripMenuItem.Visible = false;
            // 
            // disabled3ToolStripMenuItem
            // 
            this.disabled3ToolStripMenuItem.Name = "disabled3ToolStripMenuItem";
            this.disabled3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Delete)));
            this.disabled3ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.disabled3ToolStripMenuItem.Text = "disabled 3";
            this.disabled3ToolStripMenuItem.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ParkirCustomer.Properties.Resources.mobil;
            this.button2.Location = new System.Drawing.Point(523, 128);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20);
            this.button2.Size = new System.Drawing.Size(461, 378);
            this.button2.TabIndex = 1;
            this.button2.Text = "MOBIL";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ParkirCustomer.Properties.Resources.motor;
            this.button1.Location = new System.Drawing.Point(15, 128);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20);
            this.button1.Size = new System.Drawing.Size(490, 378);
            this.button1.TabIndex = 0;
            this.button1.Text = "MOTOR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(0, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(999, 562);
            this.label3.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 600);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblJam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridPark Parking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabled2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabled3ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

