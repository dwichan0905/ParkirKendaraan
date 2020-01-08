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
    public partial class frmFormulirOperator : Form {
        private frmKaryawan frm;
        private frmOperator frm2;
        private string nik = "";
        private bool editMode = false;
        public string username { get; set; }
        
        public frmFormulirOperator(frmOperator frm)
        {
            InitializeComponent();
            editMode = false;
            this.nik = "";
            this.frm2 = frm;
            this.Text = "Tambah Operator";
            cmbNIK.Text = "";
            cmbNIK.Enabled = true;
            button3.Visible = true;
            txtNama.Text = "";
            cmbLevel.SelectedIndex = 1;
            txtPassword.Text = "";
            txtConPassword.Text = "";
            lbWarning.Visible = false;
        }
        public frmFormulirOperator(frmOperator frm, string nik, string nama, string level)
        {
            InitializeComponent();
            editMode = true;
            this.nik = nik;
            this.frm2 = frm;
            this.Text = "Edit Operator";
            cmbNIK.Text = nik;
            cmbNIK.Enabled = false;
            button3.Visible = false;
            txtNama.Text = nama;
            cmbLevel.Text = level;
            txtPassword.Visible = false;
            txtConPassword.Visible = false;
            lbWarning.Visible = true;
        }

        private void cmbNIK_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                    try {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT nama FROM operator WHERE NIK = @NIK";
                        cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = cmbNIK.Text;

                        txtNama.Text = ((cmd.ExecuteScalar() == null) || (cmd.ExecuteScalar().ToString() == "") ? "not found" : cmd.ExecuteScalar().ToString());

                        conn.Close();
                        frm2.refreshData();
                    } catch (SqlException ex) {
                        MessageBox.Show("SQL ERROR: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click (object sender, EventArgs e) {
            frm = new frmKaryawan(username, this);
            frm.ShowDialog(this);
        }

        private void button1_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void frmFormulirOperator_Load (object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT NIK " +
                                      "FROM operator " +
                                      "WHERE NIK != @niklogin ";
                    cmd.Parameters.Add("@niklogin", SqlDbType.VarChar).Value = username;
                    cmbNIK.Items.Clear();
                    using (SqlDataReader oReader = cmd.ExecuteReader()) {
                        while (oReader.Read()) {
                            cmbNIK.Items.Add(oReader[0].ToString());
                        }
                    }
                    
                    conn.Close();
                } catch (SqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
        }

        private void button2_Click (object sender, EventArgs e) {
            if (cmbLevel.Text == "") {
                MessageBox.Show(this, "Kolom Level wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (editMode == true) {
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                    try {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "tambah_operator";
                        cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = cmbNIK.Text;
                        cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = txtNama.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;
                        cmd.Parameters.Add("@level", SqlDbType.VarChar).Value = cmbLevel.Text;

                        cmd.ExecuteNonQuery();

                        conn.Close();
                        frm2.refreshData();
                        MessageBox.Show(this, "Operator '" + txtNama.Text + "' dengan NIK '" + cmbNIK.Text + "' berhasil diubah!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    } catch (SqlException ex) {
                        MessageBox.Show("SQL ERROR: " + ex.Message);
                    }
                }
            } else {
                bool isExist = false;
                if (cmbNIK.Text == "") {
                    MessageBox.Show(this, "Kolom NIK wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((txtPassword.Text == "") || (txtConPassword.Text == "")) {
                    MessageBox.Show(this, "Kolom Kata Sandi wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPassword.Text != txtConPassword.Text) {
                    MessageBox.Show(this, "Kata Sandi tidak sama, periksa kembali!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                    try {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM operator WHERE NIK = @NIK";
                        cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = cmbNIK.Text;

                        isExist = (cmd.ExecuteScalar().ToString() == "1" ? true : false);

                        conn.Close();
                        frm2.refreshData();
                    } catch (SqlException ex) {
                        MessageBox.Show("SQL ERROR: " + ex.Message);
                    }
                }
                if (isExist) {
                    MessageBox.Show(this, "NIK '" + cmbNIK.Text + "' sudah menjadi operator/admin!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbNIK.Focus();
                } else {
                    if ((txtNama.Text == "") || (txtNama.Text == "not found")) {
                        MessageBox.Show(this, "NIK belum/tidak dapat diproses! Silakan pilih NIK karyawan yang ada, atau tekan Enter pada kolom NIK!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbNIK.Focus();
                    }
                    using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                        try {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "tambah_operator";
                            cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = cmbNIK.Text;
                            cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = txtNama.Text;
                            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;
                            cmd.Parameters.Add("@level", SqlDbType.VarChar).Value = cmbLevel.Text;

                            cmd.ExecuteNonQuery();

                            conn.Close();
                            frm2.refreshData();
                            MessageBox.Show(this, "Operator '" + txtNama.Text + "' dengan NIK '" + cmbNIK.Text + "' berhasil disimpan!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        } catch (SqlException ex) {
                            MessageBox.Show("SQL ERROR: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void cmbNIK_TextUpdate (object sender, EventArgs e) {

        }

        private void cmbNIK_SelectedValueChanged (object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT nama FROM operator WHERE NIK = @NIK";
                    cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = cmbNIK.Text;

                    txtNama.Text = (cmd.ExecuteScalar().ToString() == "" ? "not found" : cmd.ExecuteScalar().ToString());

                    conn.Close();
                    frm2.refreshData();
                } catch (SqlException ex) {
                    MessageBox.Show("SQL ERROR: " + ex.Message);
                }
            }
        }

        private void cmbNIK_SelectedIndexChanged (object sender, EventArgs e) {

        }
    }
}
