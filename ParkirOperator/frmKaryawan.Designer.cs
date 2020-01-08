namespace ParkirCustomer {
    partial class frmKaryawan {
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
            this.dtKaryawan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtKaryawan
            // 
            this.dtKaryawan.AllowUserToAddRows = false;
            this.dtKaryawan.AllowUserToDeleteRows = false;
            this.dtKaryawan.AllowUserToResizeColumns = false;
            this.dtKaryawan.AllowUserToResizeRows = false;
            this.dtKaryawan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtKaryawan.BackgroundColor = System.Drawing.Color.Black;
            this.dtKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKaryawan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtKaryawan.Location = new System.Drawing.Point(12, 43);
            this.dtKaryawan.Name = "dtKaryawan";
            this.dtKaryawan.ReadOnly = true;
            this.dtKaryawan.RowHeadersVisible = false;
            this.dtKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtKaryawan.Size = new System.Drawing.Size(476, 305);
            this.dtKaryawan.TabIndex = 0;
            this.dtKaryawan.DoubleClick += new System.EventHandler(this.dtKaryawan_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(174, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(93, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(413, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tutup";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.Black;
            this.txtCari.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.ForeColor = System.Drawing.Color.White;
            this.txtCari.Location = new System.Drawing.Point(345, 12);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(143, 25);
            this.txtCari.TabIndex = 5;
            this.txtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCari_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cari:";
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(12, 406);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(269, 31);
            this.lbMessage.TabIndex = 7;
            this.lbMessage.Text = "Klik dua kali untuk memilih karyawan yang akan dijadikan operator.";
            this.lbMessage.Visible = false;
            // 
            // frmKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 449);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtKaryawan);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manajemen Karyawan";
            this.Load += new System.EventHandler(this.frmKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtKaryawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtKaryawan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMessage;
    }
}