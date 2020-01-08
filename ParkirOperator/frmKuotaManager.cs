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
    public partial class frmKuotaManager : Form {
        public frmKuotaManager () {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e) {

        }

        private void clear () {
            txtKode.Text = "";
            cmbJenis.SelectedIndex = 0;
            numKuota.Value = 1;
        }

        public void refreshData () {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT kode_lokasi AS 'Kode Tempat', jenis_kend AS 'Jenis', kuota AS 'Kuota' " +
                                      "FROM lokasi " +
                                      "ORDER BY kode_lokasi ASC, jenis_kend ASC";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "kuota");
                    this.dtKuota.DataSource = ds;
                    this.dtKuota.DataMember = "kuota";
                    this.dtKuota.ReadOnly = true;
                    this.dtKuota.ClearSelection();
                    foreach (DataGridViewRow row in this.dtKuota.Rows) {
                        //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                        //row.DefaultCellStyle.BackColor = Color.Black;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    }
                    clear();
                    conn.Close();
                } catch (SqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
        }

        private void frmKuotaManager_Load (object sender, EventArgs e) {
            refreshData();
            clear();
        }

        private void button3_Click (object sender, EventArgs e) {
            if (dtKuota.CurrentCell.RowIndex > -1) {
                DialogResult dr = MessageBox.Show(this, "Yakin ingin menghapus tempat berkode '" + dtKuota.Rows[dtKuota.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' untuk " + dtKuota.Rows[dtKuota.CurrentCell.RowIndex].Cells[1].Value.ToString() + "?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes) {
                    try {
                        using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "DELETE FROM lokasi WHERE kode_lokasi = @kode_lokasi";
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;
                            cmd.Parameters.Add("@kode_lokasi", SqlDbType.VarChar).Value = dtKuota.Rows[dtKuota.CurrentCell.RowIndex].Cells[0].Value.ToString();

                            cmd.ExecuteNonQuery();
                            refreshData();
                            MessageBox.Show(this, "Berhasil dihapus!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(this, ex.ToString());
                    }
                }
            } else {
                MessageBox.Show(this, "Anda wajib memilih mana yang akan dihapus!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtKuota_CellDoubleClick (object sender, DataGridViewCellEventArgs e) {
            txtKode.Text = dtKuota.Rows[dtKuota.CurrentCell.RowIndex].Cells[0].Value.ToString();
            cmbJenis.Text = dtKuota.Rows[dtKuota.CurrentCell.RowIndex].Cells[1].Value.ToString();
            numKuota.Value = int.Parse(dtKuota.Rows[dtKuota.CurrentCell.RowIndex].Cells[2].Value.ToString());
        }

        private void button2_Click (object sender, EventArgs e) {
            try {
                if (txtKode.Text == "") {
                    MessageBox.Show(this, "Kode tempat parkir wajib diisi!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "tambah_lokasi";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@kode_lokasi", SqlDbType.VarChar).Value = txtKode.Text;
                    cmd.Parameters.Add("@jenis_kend", SqlDbType.VarChar).Value = cmbJenis.Text;
                    cmd.Parameters.Add("@kuota", SqlDbType.Int).Value = numKuota.Value;

                    cmd.ExecuteNonQuery();
                    refreshData();
                    MessageBox.Show(this, "Berhasil ditambahkan!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.ToString());
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
