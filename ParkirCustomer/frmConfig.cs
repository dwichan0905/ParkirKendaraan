using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Media;

namespace ParkirCustomer {
    public partial class frmConfig : Form {
        private System.Windows.Forms.Form frmUtama;
        private initConnection ic;
        public frmConfig (System.Windows.Forms.Form i) {
            InitializeComponent();
            frmUtama = i;
        }

        private void frmConfig_Load (object sender, EventArgs e) {
            ic = new initConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DBName);
            txtHead1.Text = Properties.Settings.Default.Header1;
            txtHead2.Text = Properties.Settings.Default.Header2;
            txtServer.Text = Properties.Settings.Default.Server;
            txtDB.Text = Properties.Settings.Default.DBName;

            lblStatus.Text = "Status: " + (ic.isSQLConnected() ? "Terhubung" : "Tidak Terhubung");
            greet.Checked = Properties.Settings.Default.greet;
            if (Properties.Settings.Default.greet == true) {
                custgreet.Visible = true;
                custgreet.Checked = Properties.Settings.Default.customgreet;
                if (Properties.Settings.Default.customgreet == true) {
                    gbGreet.Visible = true;
                } else {
                    gbGreet.Visible = false;
                }
                txtGreet.Text = Properties.Settings.Default.greettext;
            } else {
                custgreet.Visible = false;
                gbGreet.Visible = false;
            }
        }

        private void frmConfig_FormClosed (object sender, FormClosedEventArgs e) {
            frmUtama.Show();
        }

        private void button4_Click (object sender, EventArgs e) {
            DialogResult msg = MessageBox.Show(this, "Yakin ingin keluar dari aplikasi?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes) {
                try {
                    using (Process myProcess = new Process()) {
                        myProcess.StartInfo.UseShellExecute = false;
                        // You can start any process, HelloWorld is a do-nothing example.
                        myProcess.StartInfo.FileName = "C:\\Windows\\explorer.exe";
                        myProcess.StartInfo.CreateNoWindow = true;
                        myProcess.Start();
                        // This code assumes the process you are starting will terminate itself. 
                        // Given that is is started without a window so you cannot terminate it 
                        // on the desktop, it must terminate itself or you can do it programmatically
                        // from this application using the Kill method.
                        Application.Exit();
                    }
                } catch (Exception ey) {
                    Console.WriteLine(ey.Message);
                }
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void txtOldPIN_TextChanged (object sender, EventArgs e) {

        }

        private void txtOldPIN_KeyPress (object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void button2_Click (object sender, EventArgs e) {
            Properties.Settings.Default.Header1 = txtHead1.Text;
            Properties.Settings.Default.Header2 = txtHead2.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show(this, "Kustomisasi Pencetakan berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click (object sender, EventArgs e) {
            if (txtOldPIN.Text != Properties.Settings.Default.passkey) {
                MessageBox.Show(this, "PIN Lama salah!", "Wrong PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if ((txtNewPin.Text != txtNewPin2.Text) || (txtNewPin.Text == "") || (txtNewPin2.Text == "")) {
                    MessageBox.Show(this, "PIN Baru tidak sah!", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    Properties.Settings.Default.passkey = txtNewPin.Text;
                    Properties.Settings.Default.Save();
                    txtOldPIN.Text = "";
                    txtNewPin.Text = "";
                    txtNewPin2.Text = "";
                    MessageBox.Show(this, "PIN Admin berhasil diganti!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button6_Click (object sender, EventArgs e) {
            try {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(tes_cetak);
                // Set the printer name. 
                //pd.PrinterSettings.PrinterName = "\\NS5\hpoffice
                //pd.PrinterSettings.PrinterName = "Zebra New GK420t"               
                pd.Print();
            } catch (Exception ex) {
                Console.Write("Error: " + ex.ToString());
            }
        }

        private void tes_cetak (object sender, PrintPageEventArgs ev) {
            DateTime dt = DateTime.Now;
            Font printFont = new Font("3 of 9 Barcode", 22);
            Font printFont1 = new Font("Consolas", 9);
            Pen pen = new Pen(new SolidBrush(Color.Black));

            SolidBrush br = new SolidBrush(Color.Black);

            ev.Graphics.DrawString(txtHead1.Text, printFont1, br, 10, 10);
            ev.Graphics.DrawString(txtHead2.Text, printFont1, br, 10, 30);
            ev.Graphics.DrawLine(pen, 10, 50, 280, 50);
            ev.Graphics.DrawString("TIKET PARKIR KENDARAAN", printFont1, br, 60, 60);
            ev.Graphics.DrawString("Masuk", printFont1, br, 10, 85);
            ev.Graphics.DrawString(": " + dt.ToString("dddd, dd/MM/yyyy HH:mm:ss"), printFont1, br, 70, 85);
            ev.Graphics.DrawString("Jenis", printFont1, br, 10, 105);
            ev.Graphics.DrawString(": Ujicoba Cetak", printFont1, br, 70, 105);
            ev.Graphics.DrawString("12345678901234", printFont, br, 15, 135);
            ev.Graphics.DrawString("12345678901234", printFont1, br, 90, 160);
        }

        private void button8_Click (object sender, EventArgs e) {
            DialogResult msg = MessageBox.Show(this, "Yakin ingin memulai ulang komputer?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes) {
                Process.Start(@"C:\Windows\System32\shutdown.exe", @"-r -t 0");
                Application.Exit();
            }
        }

        private void button7_Click (object sender, EventArgs e) {
            DialogResult msg = MessageBox.Show(this, "Yakin ingin mematikan komputer?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes) {
                Process.Start(@"C:\Windows\System32\shutdown.exe", @"-s -t 0");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Menghubungkan...";
            ic = new initConnection(txtServer.Text, txtDB.Text);
            if (ic.isSQLConnected())
            {
                lblStatus.Text = "Status: Terhubung";
                Properties.Settings.Default.Server = txtServer.Text;
                Properties.Settings.Default.DBName = txtDB.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show(this, "Koneksi smart system berhasil terhubung ke database dan konfigurasi berhasil disimpan!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatus.Text = "Status: Tidak Terhubung";
                MessageBox.Show(this, "Koneksi smart system gagal terhubung ke database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void greet_CheckedChanged (object sender, EventArgs e) {
            if (greet.Checked)
                custgreet.Visible = true;
            else
                custgreet.Visible = false;
        }

        private void custgreet_CheckedChanged (object sender, EventArgs e) {
            if (custgreet.Visible == true && custgreet.Checked == true) {
                gbGreet.Visible = true;
            } else {
                gbGreet.Visible = false;
            }
        }

        private void button9_Click (object sender, EventArgs e) {
            if (custgreet.Checked == true) {
                SpeechSynthesizer sc = new SpeechSynthesizer();
                sc.SpeakAsync(txtGreet.Text == "" ? "Null" : txtGreet.Text);
            } else {
                SoundPlayer snd = new SoundPlayer(Properties.Resources.welcome);
                snd.Play();
            }
        }

        private void button10_Click (object sender, EventArgs e) {
            if (custgreet.Checked == true && txtGreet.Text == "") {
                MessageBox.Show(this, "Greeting wajib diisi!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGreet.Focus();
                return;
            }

            Properties.Settings.Default.greet = greet.Checked;
            Properties.Settings.Default.customgreet = custgreet.Checked;
            Properties.Settings.Default.greettext = txtGreet.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show(this, "Konfigurasi berhasil disimpan!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
