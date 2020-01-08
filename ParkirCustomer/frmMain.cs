using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Data.SqlClient;

namespace ParkirCustomer {
    public partial class frmMain : Form {
        private initConnection conn;
        private frmPassword frmPassword;
        private frmKaryawan frmKaryawan;
        private string didapat = "", kode = "";
        public frmMain () {
            Process.Start(@"C:\Windows\System32\taskkill.exe", @"/F /IM explorer.exe");  
            InitializeComponent();
        }

        public void playWelcome () {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.welcome);
            snd.Play();
        }

        private void button2_Click (object sender, EventArgs e) {
            try {
                button1.Enabled = false;
                button2.Enabled = false;
                DateTime dt = DateTime.Now;
                var list = new List<string[]>() { };
                conn = new initConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DBName);

                using (SqlConnection myConnection = new SqlConnection()) {
                    string oString = "SELECT * FROM lokasi WHERE jenis_kend = 'Mobil'";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader()) {
                        while (oReader.Read()) {
                            string[] baru = new string[2];
                            baru[0] = oReader["kode_lokasi"].ToString();
                            baru[1] = oReader["kuota"].ToString();
                            list.Add(baru);

                            //matchingPerson.firstName = oReader["FirstName"].ToString();
                            //matchingPerson.lastName = oReader["LastName"].ToString();
                        }

                        myConnection.Close();
                    }
                }

                using (SqlConnection bcc = new SqlConnection()) {
                    bcc.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    bcc.Open();
                    foreach (string[] y in list) {
                        string oString2 = "SELECT COUNT(*) FROM parkir WHERE kode_lokasi = '" + y[0] + "'";
                        SqlCommand oCmd2 = new SqlCommand(oString2, bcc);
                        if (int.Parse(oCmd2.ExecuteScalar().ToString()) < int.Parse(y[1].ToString())) {
                            didapat = y[0].ToString();
                            kode = dt.ToString("yyyyMMddHHmmss");
                            break;
                        }
                    }
                    bcc.Close();
                }

                if (didapat == "") {
                    MessageBox.Show(this, "Tempat parkir penuh semua!!", "Not enough", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } else {
                    using (SqlConnection scn = new SqlConnection()) {
                        scn.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                        scn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = scn;
                        cmd.CommandText = "tambah_kend";
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter id_parkir = new SqlParameter("@id_parkir", SqlDbType.VarChar);
                        SqlParameter jenis_kend = new SqlParameter("@jenis_kend", SqlDbType.VarChar);
                        SqlParameter tgl_masuk = new SqlParameter("@tgl_masuk", SqlDbType.DateTime);
                        SqlParameter kode_lokasi = new SqlParameter("@kode_lokasi", SqlDbType.VarChar);

                        id_parkir.Value = kode;
                        jenis_kend.Value = "Mobil";
                        tgl_masuk.Value = DateTime.Now;
                        kode_lokasi.Value = didapat;

                        cmd.Parameters.Add(id_parkir);
                        cmd.Parameters.Add(jenis_kend);
                        cmd.Parameters.Add(tgl_masuk);
                        cmd.Parameters.Add(kode_lokasi);

                        cmd.ExecuteNonQuery();
                        scn.Close();
                    }
                }
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(printMobil);
                // Set the printer name. 
                //pd.PrinterSettings.PrinterName = "\\NS5\hpoffice
                //pd.PrinterSettings.PrinterName = "Zebra New GK420t"               
                pd.Print();
                if (Properties.Settings.Default.greet) {
                    if (Properties.Settings.Default.customgreet) {
                        SpeechSynthesizer sc = new SpeechSynthesizer();
                        sc.SpeakAsync(Properties.Settings.Default.greettext);
                    } else {
                        playWelcome();
                    }
                }
                frmInfo frm = new frmInfo();
                frm.lbTempat.Text = didapat;
                frm.lbKet.Text = "Mobil";
                frm.timer1.Enabled = true;
                frm.ShowDialog(this);
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.ToString());
            } finally {
                didapat = "";
                kode = "";
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button3_Click (object sender, EventArgs e) {
            try {
                if (frmPassword.Visible == true) {
                    frmPassword.Focus();
                } else {
                    frmPassword = new frmPassword(this);
                    frmPassword.Show();
                }
            } catch (Exception ex) {
                frmPassword = new frmPassword(this);
                frmPassword.Show();
            }
        }

        private void timer1_Tick (object sender, EventArgs e) {
            DateTime dt = DateTime.Now;
            lblTanggal.Text = dt.ToString("dddd, dd/MM/yyyy");
            lblJam.Text = dt.ToString("HH:mm:ss").Replace(".", ":");
        }

        private void lblTanggal_Click (object sender, EventArgs e) {

        }

        private void button4_Click (object sender, EventArgs e) {
            try {
                if (frmKaryawan.Visible == true) {
                    frmKaryawan.Focus();
                } else {
                    frmKaryawan = new frmKaryawan(this);
                    frmKaryawan.ShowDialog();
                }
            } catch (Exception ex) {
                frmKaryawan = new frmKaryawan(this);
                frmKaryawan.ShowDialog();
            }
        }

        private void frmMain_Load (object sender, EventArgs e) {
            
        }

        private void button1_Click (object sender, EventArgs e) {
            try {
                button1.Enabled = false;
                button2.Enabled = false;
                DateTime dt = DateTime.Now;
                var list = new List<string[]>() { };
                conn = new initConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DBName);

                using (SqlConnection myConnection = new SqlConnection()) {
                    string oString = "SELECT * FROM lokasi WHERE jenis_kend = 'Motor'";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader()) {
                        while (oReader.Read()) {
                            string[] baru = new string[2];
                            baru[0] = oReader["kode_lokasi"].ToString();
                            baru[1] = oReader["kuota"].ToString();
                            list.Add(baru);

                            //matchingPerson.firstName = oReader["FirstName"].ToString();
                            //matchingPerson.lastName = oReader["LastName"].ToString();
                        }

                        myConnection.Close();
                    }
                }

                using (SqlConnection bcc = new SqlConnection()) {
                    bcc.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    bcc.Open();
                    foreach (string[] y in list) {
                        string oString2 = "SELECT COUNT(*) FROM parkir WHERE kode_lokasi = '" + y[0] + "'";
                        SqlCommand oCmd2 = new SqlCommand(oString2, bcc);
                        if (int.Parse(oCmd2.ExecuteScalar().ToString()) < int.Parse(y[1].ToString())) {
                            didapat = y[0].ToString();
                            kode = dt.ToString("yyyyMMddHHmmss");
                            break;
                        }
                    }
                    bcc.Close();
                }
                
                if (didapat == "") {
                    MessageBox.Show(this, "Tempat parkir penuh semua!!", "Not enough", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } else {
                    using (SqlConnection scn = new SqlConnection()) {
                        scn.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                        scn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = scn;
                        cmd.CommandText = "tambah_kend";
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter id_parkir = new SqlParameter("@id_parkir", SqlDbType.VarChar);
                        SqlParameter jenis_kend = new SqlParameter("@jenis_kend", SqlDbType.VarChar);
                        SqlParameter tgl_masuk = new SqlParameter("@tgl_masuk", SqlDbType.DateTime);
                        SqlParameter kode_lokasi = new SqlParameter("@kode_lokasi", SqlDbType.VarChar);

                        id_parkir.Value = kode;
                        jenis_kend.Value = "Motor";
                        tgl_masuk.Value = DateTime.Now;
                        kode_lokasi.Value = didapat;

                        cmd.Parameters.Add(id_parkir);
                        cmd.Parameters.Add(jenis_kend);
                        cmd.Parameters.Add(tgl_masuk);
                        cmd.Parameters.Add(kode_lokasi);

                        cmd.ExecuteNonQuery();
                        scn.Close();
                    }
                }

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(printMotor);
                // Set the printer name. 
                //pd.PrinterSettings.PrinterName = "\\NS5\hpoffice
                //pd.PrinterSettings.PrinterName = "Zebra New GK420t"               
                pd.Print();
                //playWelcome();
                if (Properties.Settings.Default.greet) {
                    if (Properties.Settings.Default.customgreet) {
                        SpeechSynthesizer sc = new SpeechSynthesizer();
                        sc.SpeakAsync(Properties.Settings.Default.greettext);
                    } else {
                        playWelcome();
                    }
                }
                frmInfo frm = new frmInfo();
                frm.lbTempat.Text = didapat;
                frm.lbKet.Text = "Motor";
                frm.timer1.Enabled = true;
                frm.ShowDialog(this);
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.ToString());
            } finally {
                didapat = "";
                kode = "";
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        void printMotor (object sender, PrintPageEventArgs ev) {
            DateTime dt = DateTime.Now;
            Font printFont = new Font("3 of 9 Barcode", 22);
            Font printFont1 = new Font("Consolas", 9);
            Pen pen = new Pen(new SolidBrush(Color.Black));

            SolidBrush br = new SolidBrush(Color.Black);

            ev.Graphics.DrawString(Properties.Settings.Default.Header1, printFont1, br, 10, 10);
            ev.Graphics.DrawString(Properties.Settings.Default.Header2, printFont1, br, 10, 30);
            ev.Graphics.DrawLine(pen, 10, 50, 280, 50);
            ev.Graphics.DrawString("TIKET PARKIR KENDARAAN", printFont1, br, 60, 60);
            ev.Graphics.DrawString("Masuk", printFont1, br, 10, 85);
            ev.Graphics.DrawString(": " + dt.ToString("dddd, dd/MM/yyyy HH:mm:ss"), printFont1, br, 70, 85);
            ev.Graphics.DrawString("Jenis", printFont1, br, 10, 105);
            ev.Graphics.DrawString(": Sepeda Motor", printFont1, br, 70, 105);
            ev.Graphics.DrawString("Tempat", printFont1, br, 10, 125);
            ev.Graphics.DrawString(": " + didapat + " (parkir disini)", printFont1, br, 70, 125);
            ev.Graphics.DrawString(kode, printFont, br, 15, 155);
            ev.Graphics.DrawString(kode, printFont1, br, 90, 180);
            ev.Graphics.DrawString("Tiket parkir ini jangan sampai hilang!", printFont1, br, 10, 200);
            ev.Graphics.DrawString("Jika hilang, anda harus membayar", printFont1, br, 10, 215);
            ev.Graphics.DrawString("  denda sebesar Rp20.000,-", printFont1, br, 10, 230);
        }

        void printMobil (object sender, PrintPageEventArgs ev) {
            DateTime dt = DateTime.Now;
            Font printFont = new Font("3 of 9 Barcode", 22);
            Font printFont1 = new Font("Consolas", 9);
            Pen pen = new Pen(new SolidBrush(Color.Black));

            SolidBrush br = new SolidBrush(Color.Black);

            ev.Graphics.DrawString(Properties.Settings.Default.Header1, printFont1, br, 10, 10);
            ev.Graphics.DrawString(Properties.Settings.Default.Header2, printFont1, br, 10, 30);
            ev.Graphics.DrawLine(pen, 10, 50, 280, 50);
            ev.Graphics.DrawString("TIKET PARKIR KENDARAAN", printFont1, br, 60, 60);
            ev.Graphics.DrawString("Masuk", printFont1, br, 10, 85);
            ev.Graphics.DrawString(": " + dt.ToString("dddd, dd/MM/yyyy HH:mm:ss"), printFont1, br, 70, 85);
            ev.Graphics.DrawString("Jenis", printFont1, br, 10, 105);
            ev.Graphics.DrawString(": Mobil", printFont1, br, 70, 105);
            ev.Graphics.DrawString("Tempat", printFont1, br, 10, 125);
            ev.Graphics.DrawString(": " + didapat + " (parkir disini)", printFont1, br, 70, 125);
            ev.Graphics.DrawString(kode, printFont, br, 15, 155);
            ev.Graphics.DrawString(kode, printFont1, br, 90, 180);
            ev.Graphics.DrawString("Tiket parkir ini jangan sampai hilang!", printFont1, br, 10, 200);
            ev.Graphics.DrawString("Jika hilang, anda harus membayar", printFont1, br, 10, 215);
            ev.Graphics.DrawString("  denda sebesar Rp20.000,-", printFont1, br, 10, 230);
        }

        private void pengaturanToolStripMenuItem_Click (object sender, EventArgs e) {
            try {
                if (frmPassword.Visible == true) {
                    frmPassword.Focus();
                } else {
                    frmPassword = new frmPassword(this);
                    frmPassword.ShowDialog();
                }
            } catch (Exception ex) {
                frmPassword = new frmPassword(this);
                frmPassword.ShowDialog();
            }
        }

        private void motorToolStripMenuItem_Click (object sender, EventArgs e) {
            button1.PerformClick();
        }

        private void mobilToolStripMenuItem_Click (object sender, EventArgs e) {
            button2.PerformClick();
        }

        private void karyawanToolStripMenuItem_Click (object sender, EventArgs e) {
            button4.PerformClick();
        }
    }
}
