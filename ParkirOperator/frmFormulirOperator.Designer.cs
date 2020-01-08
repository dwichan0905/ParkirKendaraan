namespace ParkirCustomer {
    partial class frmFormulirOperator {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbNIK = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kata Sandi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ulangi Kata Sandi:";
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(125, 53);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(247, 20);
            this.txtNama.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(124, 154);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(248, 20);
            this.txtConPassword.TabIndex = 7;
            this.txtConPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(275, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(172, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbNIK
            // 
            this.cmbNIK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNIK.FormattingEnabled = true;
            this.cmbNIK.Location = new System.Drawing.Point(125, 20);
            this.cmbNIK.Name = "cmbNIK";
            this.cmbNIK.Size = new System.Drawing.Size(145, 21);
            this.cmbNIK.TabIndex = 10;
            this.cmbNIK.SelectedIndexChanged += new System.EventHandler(this.cmbNIK_SelectedIndexChanged);
            this.cmbNIK.TextUpdate += new System.EventHandler(this.cmbNIK_TextUpdate);
            this.cmbNIK.SelectedValueChanged += new System.EventHandler(this.cmbNIK_SelectedValueChanged);
            this.cmbNIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNIK_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(276, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "Karyawan...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Admin",
            "Operator"});
            this.cmbLevel.Location = new System.Drawing.Point(125, 86);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(108, 21);
            this.cmbLevel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Level:";
            // 
            // lbWarning
            // 
            this.lbWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWarning.Location = new System.Drawing.Point(12, 119);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(360, 75);
            this.lbWarning.TabIndex = 14;
            this.lbWarning.Text = "Untuk mengubah password, operator harus login terlebih dahulu.";
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWarning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama Karyawan:";
            // 
            // frmFormulirOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(385, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbNIK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFormulirOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah/Edit Operator";
            this.Load += new System.EventHandler(this.frmFormulirOperator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.ComboBox cmbNIK;
        public System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label label2;
    }
}