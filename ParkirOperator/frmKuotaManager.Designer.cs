namespace ParkirCustomer {
    partial class frmKuotaManager {
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
            this.dtKuota = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.numKuota = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtKuota)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKuota)).BeginInit();
            this.SuspendLayout();
            // 
            // dtKuota
            // 
            this.dtKuota.AllowUserToAddRows = false;
            this.dtKuota.AllowUserToDeleteRows = false;
            this.dtKuota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtKuota.BackgroundColor = System.Drawing.Color.Black;
            this.dtKuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtKuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKuota.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtKuota.Location = new System.Drawing.Point(6, 52);
            this.dtKuota.MultiSelect = false;
            this.dtKuota.Name = "dtKuota";
            this.dtKuota.ReadOnly = true;
            this.dtKuota.RowHeadersVisible = false;
            this.dtKuota.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtKuota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtKuota.Size = new System.Drawing.Size(331, 155);
            this.dtKuota.TabIndex = 0;
            this.dtKuota.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtKuota_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numKuota);
            this.groupBox1.Controls.Add(this.cmbJenis);
            this.groupBox1.Controls.Add(this.txtKode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtKuota);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(153, 19);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(105, 20);
            this.txtKode.TabIndex = 0;
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Motor",
            "Mobil",
            "Karyawan"});
            this.cmbJenis.Location = new System.Drawing.Point(153, 45);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(129, 21);
            this.cmbJenis.TabIndex = 1;
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numKuota
            // 
            this.numKuota.Location = new System.Drawing.Point(153, 72);
            this.numKuota.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numKuota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKuota.Name = "numKuota";
            this.numKuota.Size = new System.Drawing.Size(61, 20);
            this.numKuota.TabIndex = 2;
            this.numKuota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tutup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Tempat Parkir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jenis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kuota:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Simpan/Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(125, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmKuotaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(367, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKuotaManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuota Parkir";
            this.Load += new System.EventHandler(this.frmKuotaManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtKuota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKuota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtKuota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKuota;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}