using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirCustomer {
    public partial class frmEditPengguna : Form {
        public string username { get; set; }
        public string password { get; set; }
        private frmMain frm;
        public frmEditPengguna (frmMain frm) {
            InitializeComponent();
            this.frm = frm;
        }

        private void button1_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void frmEditPengguna_Load (object sender, EventArgs e) {

        }

        private void button2_Click (object sender, EventArgs e) {
            if (txtNama.Text == "") {
                MessageBox.Show(this, "Nama Lengkap wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else {
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True")) {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE karyawan SET nama = @nama, alamat = @alamat, instansi = @instansi WHERE NIK = @NIK";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = txtNama.Text;
                    cmd.Parameters.Add("@alamat", SqlDbType.VarChar).Value = txtAlamat.Text;
                    cmd.Parameters.Add("@instansi", SqlDbType.VarChar).Value = txtInstansi.Text;

                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                }
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True")) {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE operator SET nama = @nama WHERE NIK = @NIK";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = txtNama.Text;

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                frm.txtUser.Text = txtNama.Text;
                MessageBox.Show(this, "Berhasil menyimpan konfigurasi!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click (object sender, EventArgs e) {
            if ((txtOld.Text == "") || (txtNew.Text == "") || (txtCon.Text == "")) {
                MessageBox.Show(this, "Semua form wajib terisi!", "Not Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOld.Focus();
                return;
            } else if (txtOld.Text != password) {
                MessageBox.Show(this, "Kata Sandi lama Anda salah!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOld.Focus();
                return;
            } else {
                if (txtNew.Text != txtCon.Text) {
                    MessageBox.Show(this, "Kata Sandi baru tidak valid atau tidak sama!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOld.Focus();
                    return;
                } else {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True")) {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "UPDATE operator SET pasword = @password WHERE NIK = @NIK";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;
                        cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtNew.Text;

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    MessageBox.Show(this, "Berhasil mengubah kata sandi Anda!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
