using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirCustomer {
    public partial class frmConfig : Form {
        public frmConfig () {
            InitializeComponent();
        }

        private void button5_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void frmConfig_Load (object sender, EventArgs e) {
            txtHead1.Text = Properties.Settings.Default.header1;
            txtHead2.Text = Properties.Settings.Default.header2;
            txtFoot.Text = Properties.Settings.Default.footer;

            txtServer.Text = Properties.Settings.Default.Server;
            txtDBName.Text = Properties.Settings.Default.DBName;

            numtarif.Value = Properties.Settings.Default.tarifper;
            txtTrfMotor.Text = Properties.Settings.Default.tarifmotor.ToString();
            txtTrfMobil.Text = Properties.Settings.Default.tarifmobil.ToString();

            initConnection ic = new initConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DBName);

            if (ic.isSQLConnected()) {
                lbStatus.Text = "Status: Terhubung";
            } else {
                lbStatus.Text = "Status: Tidak Terhubung";
            }
        }

        private void txtTrfMotor_TextChanged (object sender, EventArgs e) {

        }

        private void txtTrfMotor_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtTrfMobil_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void button3_Click (object sender, EventArgs e) {
            if ((txtTrfMotor.Text != "") || (txtTrfMobil.Text != "") || numtarif.Value != 0) {
                Properties.Settings.Default.tarifper = (int) numtarif.Value;
                Properties.Settings.Default.tarifmobil = int.Parse(txtTrfMobil.Text);
                Properties.Settings.Default.tarifmotor = int.Parse(txtTrfMotor.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show(this, "Berhasil menyimpan tarif parkir!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Mohon isi semua kolom dengan valid!", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click (object sender, EventArgs e) {
            if ((txtHead1.Text != "") && (txtHead2.Text != "")) {
                Properties.Settings.Default.header1 = txtHead1.Text;
                Properties.Settings.Default.header2 = txtHead2.Text;
                Properties.Settings.Default.footer = txtFoot.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show(this, "Berhasil menyimpan header dan footer cetak struk!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Mohon isi header setidaknya 1 baris!", "Null Header", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click (object sender, EventArgs e) {
            if ((txtServer.Text == "") && (txtDBName.Text == "")) {
                MessageBox.Show(this, "Mohon isi informasi koneksi dengan valid!", "Invalid Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                initConnection ic = new initConnection(txtServer.Text, txtDBName.Text);

                if (ic.isSQLConnected()) {
                    Properties.Settings.Default.Server = txtServer.Text;
                    Properties.Settings.Default.DBName = txtDBName.Text;
                    Properties.Settings.Default.Save();

                    MessageBox.Show(this, "Berhasil terhubung dengan server!", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbStatus.Text = "Status: Terhubung";
                } else {
                    MessageBox.Show(this, "Gagal terhubung dengan server!", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbStatus.Text = "Status: Tidak Terhubung";
                }
            }
        }
    }
}
