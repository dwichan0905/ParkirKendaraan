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
    public partial class frmFormulirKaryawan : Form {
        private frmKaryawan frm;
        private string nik = "";
        private bool editMode = false;
        public frmFormulirKaryawan(frmKaryawan frm)
        {
            InitializeComponent();
            editMode = false;
            this.nik = "";
            this.frm = frm;
            this.Text = "Tambah Karyawan";
            txtNIK.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtInstansi.Text = "";
            txtNIK.ReadOnly = false;
        }
        public frmFormulirKaryawan(frmKaryawan frm, string nik, string nama, string alamat, string instansi)
        {
            InitializeComponent();
            editMode = true;
            this.nik = nik;
            this.frm = frm;
            this.Text = "Edit Karyawan";
            txtNIK.Text = nik;
            txtNama.Text = nama;
            txtAlamat.Text = alamat;
            txtInstansi.Text = instansi;
            txtNIK.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNIK.Text == "")
            {
                MessageBox.Show(this, "Kolom NIK wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNama.Text == "")
            {
                MessageBox.Show(this, "Kolom Nama Karyawan wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (editMode == true)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "tambah_karyawan";
                        cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = txtNIK.Text;
                        cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = txtNama.Text;
                        cmd.Parameters.Add("@alamat", SqlDbType.VarChar).Value = txtAlamat.Text;
                        cmd.Parameters.Add("@instansi", SqlDbType.VarChar).Value = txtInstansi.Text;

                        cmd.ExecuteNonQuery();

                        conn.Close();
                        frm.refreshData();
                        MessageBox.Show(this, "Karyawan '" + txtNama.Text + "' dengan NIK '" + txtNIK.Text + "' berhasil diubah!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL ERROR: " + ex.Message);
                    }
                }
            }
            else
            {
                bool isExist = false;
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM karyawan WHERE NIK = @NIK";
                        cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = txtNIK.Text;

                        isExist = (cmd.ExecuteScalar().ToString() == "1" ? true : false);

                        conn.Close();
                        frm.refreshData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL ERROR: " + ex.Message);
                    }
                }
                if (isExist)
                {
                    MessageBox.Show(this, "NIK '" + txtNIK.Text + "' sudah ada dalam database!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNIK.Focus();
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "tambah_karyawan";
                            cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = txtNIK.Text;
                            cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = txtNama.Text;
                            cmd.Parameters.Add("@alamat", SqlDbType.VarChar).Value = txtAlamat.Text;
                            cmd.Parameters.Add("@instansi", SqlDbType.VarChar).Value = txtInstansi.Text;

                            cmd.ExecuteNonQuery();

                            conn.Close();
                            frm.refreshData();
                            MessageBox.Show(this, "Karyawan '" + txtNama.Text + "' dengan NIK '" + txtNIK.Text + "' berhasil disimpan!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("SQL ERROR: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormulirKaryawan_Load (object sender, EventArgs e) {

        }
    }
}
