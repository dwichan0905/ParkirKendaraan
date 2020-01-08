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
    public partial class frmOperator : Form {
        public frmFormulirOperator frm;
        public string username { get; set; }
        public frmOperator () {
            InitializeComponent();
        }
        public void refreshData () {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT NIK, nama AS 'Nama Operator', level AS 'Level' " +
                                      "FROM operator " +
                                      "WHERE NIK != @niklogin ";
                    cmd.Parameters.Add("@niklogin", SqlDbType.VarChar).Value = username;
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "operator");
                    this.dtOperator.DataSource = ds;
                    this.dtOperator.DataMember = "operator";
                    this.dtOperator.ReadOnly = true;
                    this.dtOperator.ClearSelection();
                    foreach (DataGridViewRow row in this.dtOperator.Rows) {
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOperator_Load (object sender, EventArgs e) {
            refreshData();
        }

        private void button3_Click (object sender, EventArgs e) {
            frm = new frmFormulirOperator(this);
            frm.username = this.username;
            frm.ShowDialog(this);
        }

        private void button1_Click (object sender, EventArgs e) {
            if (dtOperator.CurrentCell.RowIndex > -1) {
                DialogResult rs = MessageBox.Show(this, "Yakin ingin menghapus operator '" + dtOperator.Rows[dtOperator.CurrentCell.RowIndex].Cells[1].Value + "' dengan NIK " + dtOperator.Rows[dtOperator.CurrentCell.RowIndex].Cells[0].Value + "?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == System.Windows.Forms.DialogResult.Yes) {
                    string users = dtOperator.Rows[dtOperator.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                        try {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "delete_operator";
                            cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = dtOperator.Rows[dtOperator.CurrentCell.RowIndex].Cells[0].Value;

                            cmd.ExecuteNonQuery();

                            conn.Close();
                            refreshData();
                            MessageBox.Show(this, "Berhasil menghapus operator '" + users + "'!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (SqlException ex) {
                            MessageBox.Show("SQL ERROR: " + ex.Message);
                        }
                    }
                }
            } else {
                MessageBox.Show(this, "Pilih karyawan yang akan Anda hapus!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click (object sender, EventArgs e) {
            if (dtOperator.CurrentCell.RowIndex > -1) {
                try {
                    string[] baru = new string[3];
                    using (SqlConnection myConnection = new SqlConnection()) {
                        string oString = "SELECT * FROM operator WHERE NIK = @NIK";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = dtOperator.Rows[dtOperator.CurrentCell.RowIndex].Cells[0].Value;
                        myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader()) {
                            while (oReader.Read()) {
                                baru[0] = oReader["NIK"].ToString();
                                baru[1] = oReader["nama"].ToString();
                                baru[2] = oReader["level"].ToString();
                            }

                            myConnection.Close();
                        }
                    }
                    frm = new frmFormulirOperator(this, baru[0], baru[1], baru[2]);
                    frm.username = this.username;
                    frm.ShowDialog(this);
                } catch (Exception ex) {
                    MessageBox.Show(this, "ERR: " + ex.ToString());
                }
            } else {
                MessageBox.Show(this, "Pilih operator yang akan Anda ubah!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
