using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirCustomer {
    public partial class frmKaryawan : Form {
        private string didapat = "", kode = "";
        private frmMain frm;
        public frmKaryawan (frmMain i) {
            InitializeComponent();
            frm = i;
        }

        private void button11_Click (object sender, EventArgs e) {
            txtPassword.Text = (txtPassword.Text == "" ? "" : txtPassword.Text.Remove(txtPassword.Text.Length - 1));
        }

        private void button13_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void button12_Click (object sender, EventArgs e) {
            try {
                string returnValue;
                using (SqlConnection conn = new SqlConnection()) {
                    conn.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    using (SqlCommand sqlcmd = new SqlCommand("SELECT nama FROM karyawan WHERE NIK = @nik", conn)) {
                        sqlcmd.Parameters.Add("@nik", SqlDbType.VarChar).Value = txtPassword.Text;
                        conn.Open();
                        returnValue = (string) sqlcmd.ExecuteScalar();
                    }
                }

                if (String.IsNullOrEmpty(returnValue)) {
                    MessageBox.Show(this, "NIK Salah!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                } else {
                    DateTime dt = DateTime.Now;
                    var list = new List<string[]>() { };

                    using (SqlConnection myConnection = new SqlConnection()) {
                        string oString = "SELECT * FROM lokasi WHERE jenis_kend = 'Karyawan'";
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
                            jenis_kend.Value = "Karyawan";
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
                    if (Properties.Settings.Default.greet) {
                        if (Properties.Settings.Default.customgreet) {
                            SpeechSynthesizer sc = new SpeechSynthesizer();
                            sc.SpeakAsync(Properties.Settings.Default.greettext);
                        } else {
                            frm.playWelcome();
                        }
                    }
                    frmInfo frmd = new frmInfo();
                    frmd.lbTempat.Text = didapat;
                    frmd.lbKet.Text = "Karyawan - " + returnValue;
                    frmd.timer1.Enabled = true;
                    frmd.ShowDialog(this);
                    this.Dispose();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
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

        private void txtPassword_TextChanged (object sender, EventArgs e) {

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

        private void frmKaryawan_Load (object sender, EventArgs e) {
            
        }
    }
}
