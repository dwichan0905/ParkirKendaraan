using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Collections.Specialized;

namespace ParkirCustomer {
    public partial class frmPassword : Form {
        private System.Windows.Forms.Form frmUtama;
        public frmPassword (System.Windows.Forms.Form i) {
            InitializeComponent();
            frmUtama = i;
        }

        private void button11_Click (object sender, EventArgs e) {
            txtPassword.Text = (txtPassword.Text == "" ? "" : txtPassword.Text.Remove(txtPassword.Text.Length - 1));
        }

        private void button13_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void button12_Click (object sender, EventArgs e) {
            //MessageBox.Show(this, Properties.Settings.Default.passkey);
            if (txtPassword.Text == Properties.Settings.Default.passkey) {
                frmConfig frm = new frmConfig(frmUtama);
                frm.Show();
                frmUtama.Hide();
                this.Close();
            } else {
                MessageBox.Show(this, "PIN Salah!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void button10_Click (object sender, EventArgs e) {
            txtPassword.Text += "0";
        }

        private void button7_Click (object sender, EventArgs e) {
            txtPassword.Text += "1";
        }

        private void button8_Click (object sender, EventArgs e) {
            txtPassword.Text += "2";
        }

        private void button9_Click (object sender, EventArgs e) {
            txtPassword.Text += "3";
        }

        private void button4_Click (object sender, EventArgs e) {
            txtPassword.Text += "4";
        }

        private void button5_Click (object sender, EventArgs e) {
            txtPassword.Text += "5";
        }

        private void button6_Click (object sender, EventArgs e) {
            txtPassword.Text += "6";
        }

        private void button1_Click (object sender, EventArgs e) {
            txtPassword.Text += "7";
        }

        private void button2_Click (object sender, EventArgs e) {
            txtPassword.Text += "8";
        }

        private void button3_Click (object sender, EventArgs e) {
            txtPassword.Text += "9";
        }

        private void txtPassword_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }

            if (e.KeyChar == 13) {
                button12.PerformClick();
            }
        }
    }
}
