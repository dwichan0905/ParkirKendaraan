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
    public partial class frmTransaksi : Form {
        public frmTransaksi () {
            InitializeComponent();
        }

        private void frmTransaksi_Load (object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT a.jenis_kend AS \"Jenis\", " +
                                            "a.tgl_masuk AS \"Masuk\", " + 
                                            "a.tgl_keluar AS \"Keluar\", " +
                                            "a.harga AS \"Biaya Parkir\", " +
                                            "b.nama AS \"Nama Operator\" " +
                                      "FROM transaksi a " +
                                      "INNER JOIN operator b ON a.NIK = b.NIK " +
                                      "ORDER BY tgl_masuk DESC";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "parkir");
                    dtTrans.DataSource = ds;
                    dtTrans.DataMember = "parkir";
                    dtTrans.ReadOnly = true;
                    dtTrans.ClearSelection();
                    foreach (DataGridViewRow row in dtTrans.Rows) {
                        //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                        //row.DefaultCellStyle.BackColor = Color.Black;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    }
                    conn.Close();
                } catch (SqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
            using (SqlConnection bcc = new SqlConnection()) {
                bcc.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                bcc.Open();

                string oString2 = "SELECT SUM(harga) FROM transaksi";
                SqlCommand oCmd2 = new SqlCommand(oString2, bcc);
                string tot = oCmd2.ExecuteScalar().ToString();
                lbTot.Text = "Pendapatan: Rp" + (tot == "" ? "0" : tot);

                bcc.Close();
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void button3_Click (object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT a.jenis_kend AS \"Jenis\", " +
                                            "a.tgl_masuk AS \"Masuk\", " +
                                            "a.tgl_keluar AS \"Keluar\", " +
                                            "a.harga AS \"Biaya Parkir\", " +
                                            "b.nama AS \"Nama Operator\" " +
                                      "FROM transaksi a " +
                                      "INNER JOIN operator b ON a.NIK = b.NIK " +
                                      "ORDER BY tgl_masuk DESC";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "transaksi");
                    dtTrans.DataSource = ds;
                    dtTrans.DataMember = "transaksi";
                    dtTrans.ReadOnly = true;
                    dtTrans.ClearSelection();
                    foreach (DataGridViewRow row in dtTrans.Rows) {
                        //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                        //row.DefaultCellStyle.BackColor = Color.Black;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    }
                    conn.Close();
                } catch (SqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
            using (SqlConnection bcc = new SqlConnection()) {
                bcc.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                bcc.Open();

                string oString2 = "SELECT SUM(harga) FROM transaksi";
                SqlCommand oCmd2 = new SqlCommand(oString2, bcc);
                string tot = oCmd2.ExecuteScalar().ToString();
                lbTot.Text = "Pendapatan: Rp" + (tot == "" ? "0" : tot);

                bcc.Close();
            }
        }

        private void button2_Click (object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT a.jenis_kend AS \"Jenis\", " +
                                            "a.tgl_masuk AS \"Masuk\", " +
                                            "a.tgl_keluar AS \"Keluar\", " +
                                            "a.harga AS \"Biaya Parkir\", " +
                                            "b.nama AS \"Nama Operator\" " +
                                      "FROM transaksi a " +
                                      "INNER JOIN operator b ON a.NIK = b.NIK " +
                                      "WHERE tgl_keluar BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' " +
                                      "ORDER BY tgl_masuk DESC";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "transaksi");
                    dtTrans.DataSource = ds;
                    dtTrans.DataMember = "transaksi";
                    dtTrans.ReadOnly = true;
                    dtTrans.ClearSelection();
                    foreach (DataGridViewRow row in dtTrans.Rows) {
                        //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                        //row.DefaultCellStyle.BackColor = Color.Black;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    }
                    conn.Close();
                } catch (SqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
            using (SqlConnection bcc = new SqlConnection()) {
                bcc.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                bcc.Open();

                string oString2 = "SELECT SUM(harga) FROM transaksi WHERE tgl_keluar BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ";
                SqlCommand oCmd2 = new SqlCommand(oString2, bcc);
                string tot = oCmd2.ExecuteScalar().ToString();
                lbTot.Text = "Pendapatan: Rp" + (tot == "" ? "0" : tot);

                bcc.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtTrans.Rows)
            {
                //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                //row.DefaultCellStyle.BackColor = Color.Black;
                row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            }
        }
    }
}
