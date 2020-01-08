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
    public partial class frmKaryawan : Form {
        private frmFormulirKaryawan frm;
        private frmFormulirOperator frm2;
        private string niklogin;

        public frmKaryawan (string nik) {
            InitializeComponent();
            this.niklogin = nik;
            this.lbMessage.Visible = false;
        }

        public frmKaryawan (string nik, frmFormulirOperator frmForm) {
            InitializeComponent();
            this.niklogin = nik;
            this.frm2 = frmForm;
            this.lbMessage.Visible = true;
        }

        private void button4_Click (object sender, EventArgs e) {
            this.Close();
        }

        public void refreshData()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT NIK, nama, instansi " +
                                      "FROM karyawan " +
                                      "WHERE NIK != @niklogin ";
                    cmd.Parameters.Add("@niklogin", SqlDbType.VarChar).Value = niklogin;
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "karyawan");
                    this.dtKaryawan.DataSource = ds;
                    this.dtKaryawan.DataMember = "karyawan";
                    this.dtKaryawan.ReadOnly = true;
                    this.dtKaryawan.ClearSelection();
                    foreach (DataGridViewRow row in this.dtKaryawan.Rows)
                    {
                        //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                        //row.DefaultCellStyle.BackColor = Color.Black;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
        }

        private void frmKaryawan_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtKaryawan.CurrentCell.RowIndex > -1)
            {
                DialogResult rs = MessageBox.Show(this, "Yakin ingin menghapus karyawan '" + dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[1].Value + "' dengan NIK " + dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[0].Value + "?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == System.Windows.Forms.DialogResult.Yes)
                {
                    string users = dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "delete_karyawan";
                            cmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[0].Value;

                            cmd.ExecuteNonQuery();
                            
                            conn.Close();
                            refreshData();
                            MessageBox.Show(this, "Berhasil menghapus karyawan '" + users + "'!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("SQL ERROR: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Pilih karyawan yang akan Anda hapus!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT NIK, nama AS 'Nama Karyawan', instansi AS 'Instansi' " +
                                          "FROM karyawan " +
                                          "WHERE (NIK LIKE @search OR nama LIKE @search) AND NIK != @niklogin ";
                        cmd.Parameters.Add("@niklogin", SqlDbType.VarChar).Value = niklogin;
                        cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = "%" + txtCari.Text + "%";
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(ds, "karyawan");
                        this.dtKaryawan.DataSource = ds;
                        this.dtKaryawan.DataMember = "karyawan";
                        this.dtKaryawan.ReadOnly = true;
                        this.dtKaryawan.ClearSelection();
                        foreach (DataGridViewRow row in this.dtKaryawan.Rows)
                        {
                            //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                            //row.DefaultCellStyle.BackColor = Color.Black;
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                            row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                            row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                        }
                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("SQL ERROR: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm = new frmFormulirKaryawan(this);
            frm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtKaryawan.CurrentCell.RowIndex > -1)
            {
                try
                {
                    string[] baru = new string[4];
                    using (SqlConnection myConnection = new SqlConnection())
                    {
                        string oString = "SELECT * FROM karyawan WHERE NIK = @NIK";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.Add("@NIK", SqlDbType.VarChar).Value = dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[0].Value;
                        myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                baru[0] = oReader["NIK"].ToString();
                                baru[1] = oReader["nama"].ToString();
                                baru[2] = oReader["alamat"].ToString();
                                baru[3] = oReader["instansi"].ToString();
                            }

                            myConnection.Close();
                        }
                    }
                    frm = new frmFormulirKaryawan(this, baru[0], baru[1], baru[2], baru[3]);
                    frm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "ERR: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "Pilih karyawan yang akan Anda ubah!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dtKaryawan_DoubleClick (object sender, EventArgs e) {
            if (dtKaryawan.CurrentCell.RowIndex > -1) {
                if (frm2 != null) {
                    frm2.cmbNIK.Text = dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    frm2.txtNama.Text = dtKaryawan.Rows[dtKaryawan.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    this.Close();
                }
            }
        }
    }
}
