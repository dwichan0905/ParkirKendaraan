using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirCustomer {
    public partial class frmMain : Form {
        private System.Windows.Forms.Form frm;
        private frmConfig frmConfig = new frmConfig();
        private frmEditPengguna frmEdit;
        private frmKaryawan frmKaryawan;
        private frmTransaksi frmTrans = new frmTransaksi();
        private frmOperator frmOperator = new frmOperator();
        private frmAbout frmAbout = new frmAbout();
        private frmKuotaManager frmKuota = new frmKuotaManager();
        public string username { get; set; }
        private initConnection ic;

        [DllImport("user32.dll")]
        static extern bool CreateCaret (IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);
        [DllImport("user32.dll")]
        static extern bool ShowCaret (IntPtr hWnd);

        public frmMain (System.Windows.Forms.Form i) {
            InitializeComponent();
            frm = i;
            textBox1.GotFocus += new EventHandler(textBox1_GotFocus);
           
        }

        void textBox1_GotFocus (object sender, EventArgs e) {
            DrawCaret(textBox1);
        }

        public void DrawCaret (Control ctrl) {
            var nHeight = 32;
            var nWidth = 10;

            //nHeight = Font.Height;

            CreateCaret(ctrl.Handle, IntPtr.Zero, nWidth, nHeight);
            ShowCaret(ctrl.Handle);
        }

        private void status () {
            if (listView1.SelectedItems[0].Selected == true) {
                switch (listView1.SelectedItems[0].Text) {
                    case "[F1] TENTANG":
                        frmAbout.ShowDialog(this);
                        break;
                    case "[F3] GANTI SHIFT":
                        frm.Show();
                        this.Dispose();
                        break;
                    case "[F6] UBAH KUOTA PARKIR":
                        showKuota();
                        break;
                    case "[F9] KELUAR":
                        this.Close();
                        break;
                    case "[F11] LIHAT TRANSAKSI":
                        frmTrans.ShowDialog(this);
                        break;
                    case "[F12] PENG. AKUN":
                        usersettings();
                        break;
                    case "[INS] INPUT NO. PARKIR":
                        textBox1.Focus();
                        break;
                    default:
                        break;
                }
                listView1.SelectedItems[0].Selected = false;
            }
        }

        private void showKuota()
        {
            frmKuota.ShowDialog(this);
        }

        private void showBayar () {
            bayarCetakToolStripMenuItem.Enabled = true;
            batalBayarToolStripMenuItem.Enabled = true;
            masukkanNomorParkirToolStripMenuItem.Enabled = false;
            grUtama.Visible = false;
            grResult.Visible = true;
            grStatus.Visible = false;
            listView2.Items[0].Selected = true;
            listView2.Focus();
        }

        private void applyBayar () {
            try {
                using (SqlConnection conn = new SqlConnection()) {
                    conn.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO transaksi VALUES (@id, @jenis, @masuk, @keluar, @harga, @nik)";
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = lbParkir.Text;
                    cmd.Parameters.Add("@jenis", SqlDbType.VarChar).Value = (lbJenis.Text == "Sepeda Motor" ? "Motor" : lbJenis.Text);
                    cmd.Parameters.Add("@masuk", SqlDbType.DateTime).Value = DateTime.Parse(hdTanggal.Text);
                    cmd.Parameters.Add("@keluar", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@harga", SqlDbType.Int).Value = int.Parse(lbHarga.Text.Substring(2));
                    cmd.Parameters.Add("@nik", SqlDbType.VarChar).Value = username;

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                using (SqlConnection conn5 = new SqlConnection()) {
                    conn5.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    conn5.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn5;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "hapus_parkir";
                    cmd.Parameters.Add("@id_parkir", SqlDbType.VarChar).Value = lbParkir.Text;

                    cmd.ExecuteNonQuery();
                    conn5.Close();
                }
                textBox1.Text = "";
                MessageBox.Show(this, "Transaksi berhasil dilakukan!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(this, e.ToString());
            }
        }

        private void bayar () {
            try {
                switch (listView2.SelectedItems[0].Text) {
                    case "[F2] BAYAR & CETAK":
                        DialogResult dg = MessageBox.Show(this, "Proses transaksi ini?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == System.Windows.Forms.DialogResult.Yes) {
                            applyBayar();
                        }
                        break;
                    case "[DEL] Batal":
                        textBox1.SelectAll();
                        break;
                    default:
                        break;
                }
                hideBayar();
            } catch (ArgumentException ex) {
                // gausah ngapa"in
            }
        }

        private void hideBayar () {
            bayarCetakToolStripMenuItem.Enabled = false;
            batalBayarToolStripMenuItem.Enabled = false;
            masukkanNomorParkirToolStripMenuItem.Enabled = true;
            grUtama.Visible = true;
            grResult.Visible = false;
            grStatus.Visible = true;
            textBox1.Focus();
        }

        private void frmMain_FormClosing (object sender, FormClosingEventArgs e) {
            DialogResult rs = MessageBox.Show(this, "Yakin ingin keluar dari aplikasi?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes) {
                frm.Dispose();
                //e.Cancel = false;
                //Application.Exit();
            } else {
                e.Cancel = true;
            }
        }

        private void timer1_Tick (object sender, EventArgs e) {
            DateTime dt = DateTime.Now;
            lblTanggal.Text = dt.ToString("dddd, dd MMMM yyyy");
            lblJam.Text = dt.ToString("HH:mm:ss").Replace(".", ":");
        }

        private void listView1_SelectedIndexChanged (object sender, EventArgs e) {
            
        }

        private void listView1_DoubleClick (object sender, EventArgs e) {
            //MessageBox.Show(this, listView1.SelectedItems[0].Text);
            status();
        }

        private void listView1_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                status();
            }
        }

        private void keluarToolStripMenuItem_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void label9_Click (object sender, EventArgs e) {

        }

        private void label8_Click (object sender, EventArgs e) {

        }

        private void label13_Click (object sender, EventArgs e) {

        }

        private void textBox1_TextChanged (object sender, EventArgs e) {
            textBox1.Focus();
        }

        private void textBox1_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                try {
                    string returnValue;
                    using (SqlConnection conn = new SqlConnection()) {
                        conn.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                        using (SqlCommand sqlcmd = new SqlCommand("SELECT id_parkir FROM parkir WHERE id_parkir = @id", conn)) {
                            sqlcmd.Parameters.Add("@id", SqlDbType.VarChar).Value = textBox1.Text;
                            conn.Open();
                            returnValue = (string) sqlcmd.ExecuteScalar();
                        }
                    }

                    if (String.IsNullOrEmpty(returnValue)) {
                        txtError.Text = "Nomor Parkir (" + textBox1.Text + ") tidak ditemukan!";
                        textBox1.Text = "";
                        txtError.Visible = true;
                        tmrHide.Enabled = true;
                    } else {
                        DateTime dt = DateTime.Now;

                        using (SqlConnection myConnection = new SqlConnection()) {
                            string oString = "SELECT * FROM parkir WHERE id_parkir = @id";
                            SqlCommand oCmd = new SqlCommand(oString, myConnection);
                            oCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = textBox1.Text;
                            myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                            myConnection.Open();
                            using (SqlDataReader oReader = oCmd.ExecuteReader()) {
                                while (oReader.Read()) {
                                    lbParkir.Text = oReader["id_parkir"].ToString();
                                    lbJenis.Text = (oReader["jenis_kend"].ToString() == "Motor" ? "Sepeda Motor" : oReader["jenis_kend"].ToString());
                                    lbTgl.Text = DateTime.Parse(oReader["tgl_masuk"].ToString()).ToString("dddd, dd MMMM yyyy");
                                    lbJamParkir.Text = DateTime.Parse(oReader["tgl_masuk"].ToString()).ToString("HH:mm:ss") + " WIB";
                                    hdTanggal.Text = oReader["tgl_masuk"].ToString();
                                    DateTime date1 = DateTime.Parse(oReader["tgl_masuk"].ToString());
                                    DateTime date2 = DateTime.Now;
                                    double result = (date2 - date1).TotalSeconds;

                                    TimeSpan t = TimeSpan.FromSeconds( result );

                                    lbDur.Text = string.Format("{0:D} jam {1:D} menit {2:D} detik", 
                                                    t.Hours, 
                                                    t.Minutes, 
                                                    t.Seconds);

                                    double menitnya = Math.Floor(t.TotalMinutes / Properties.Settings.Default.tarifper);
                                    double harga = 0.0;

                                    if (lbJenis.Text == "Sepeda Motor") {
                                        harga = Properties.Settings.Default.tarifmotor * menitnya;
                                    } else if (lbJenis.Text == "Mobil") {
                                        harga = Properties.Settings.Default.tarifmobil * menitnya;
                                    } 

                                    lbHarga.Text = "Rp" + harga;

                                    showBayar();
                                    //matchingPerson.firstName = oReader["FirstName"].ToString();
                                    //matchingPerson.lastName = oReader["LastName"].ToString();
                                }

                                myConnection.Close();
                            }
                        }
                    }

                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void batalBayarToolStripMenuItem_Click (object sender, EventArgs e) {
            hideBayar();
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void koneksiToolStripMenuItem_Click (object sender, EventArgs e) {
            frmConfig.ShowDialog();
        }

        private void gantiShiftToolStripMenuItem_Click (object sender, EventArgs e) {
            frm.Show();
            this.Dispose();
        }

        private void frmMain_Load (object sender, EventArgs e) {
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void listView2_DoubleClick (object sender, EventArgs e) {
            bayar();
        }

        private void listView2_SelectedIndexChanged (object sender, EventArgs e) {

        }

        private void listView2_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                bayar();
            }
        }

        private void timer2_Tick (object sender, EventArgs e) {

        }

        private void tmrHide_Tick (object sender, EventArgs e) {
            txtError.Visible = false;
            tmrHide.Enabled = false;
        }

        private void masukkanNomorParkirToolStripMenuItem_Click (object sender, EventArgs e) {
            textBox1.Focus();
        }

        private void bayarCetakToolStripMenuItem_Click (object sender, EventArgs e) {
            bayar();
        }

        private void tmrRefresh_Tick (object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Properties.Settings.Default.DBName + ";Integrated Security=True")) {
                try {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT id_parkir AS \"Nomor Parkir\", " +
                                             "jenis_kend AS \"Jenis\", " +
                                             "CONVERT(VARCHAR, tgl_masuk, 106) AS \"Tanggal Masuk\", " +
                                             "CONVERT(VARCHAR, tgl_masuk, 114) AS \"Jam Masuk\", " +
                                             "kode_lokasi AS \"Lokasi\" " +
                                             "FROM parkir ORDER BY tgl_masuk DESC";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "parkir");
                    dtParkir.DataSource = ds;
                    dtParkir.DataMember = "parkir";
                    dtParkir.ReadOnly = true;
                    dtParkir.ClearSelection();
                    foreach (DataGridViewRow row in dtParkir.Rows)
                    {
                        //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                        //row.DefaultCellStyle.BackColor = Color.Black;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    }
                    tmrRefresh.Interval = 5000;
                    conn.Close();
                } catch (SqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
            using (SqlConnection bcc = new SqlConnection()) {
                bcc.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                bcc.Open();

                string oString2 = "SELECT COUNT(*) FROM parkir";
                SqlCommand oCmd2 = new SqlCommand(oString2, bcc);
                string tot = oCmd2.ExecuteScalar().ToString();
                lbTot.Text = (tot.Equals("0") ? "Tidak ada" : "Ada " + tot) + " kendaraan sedang parkir.";
                
                bcc.Close();
            }
        }

        private void dtParkir_DoubleClick (object sender, EventArgs e) {
            try {
                string returnValue;
                using (SqlConnection conn = new SqlConnection()) {
                    conn.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    using (SqlCommand sqlcmd = new SqlCommand("SELECT id_parkir FROM parkir WHERE id_parkir = @id", conn)) {
                        sqlcmd.Parameters.Add("@id", SqlDbType.VarChar).Value = textBox1.Text;
                        conn.Open();
                        returnValue = (string) sqlcmd.ExecuteScalar();
                    }
                }

                if (String.IsNullOrEmpty(returnValue)) {
                    txtError.Text = "Nomor Parkir (" + textBox1.Text + ") tidak ditemukan!";
                    textBox1.Text = "";
                    txtError.Visible = true;
                    tmrHide.Enabled = true;
                } else {
                    DateTime dt = DateTime.Now;

                    using (SqlConnection myConnection = new SqlConnection()) {
                        string oString = "SELECT * FROM parkir WHERE id_parkir = @id";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = textBox1.Text;
                        myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader()) {
                            while (oReader.Read()) {
                                lbParkir.Text = oReader["id_parkir"].ToString();
                                lbJenis.Text = (oReader["jenis_kend"].ToString() == "Motor" ? "Sepeda Motor" : oReader["jenis_kend"].ToString());
                                lbTgl.Text = DateTime.Parse(oReader["tgl_masuk"].ToString()).ToString("dddd, dd MMMM yyyy");
                                lbJamParkir.Text = DateTime.Parse(oReader["tgl_masuk"].ToString()).ToString("HH:mm:ss") + " WIB";
                                hdTanggal.Text = oReader["tgl_masuk"].ToString();
                                DateTime date1 = DateTime.Parse(oReader["tgl_masuk"].ToString());
                                DateTime date2 = DateTime.Now;
                                double result = (date2 - date1).TotalSeconds;

                                TimeSpan t = TimeSpan.FromSeconds(result);

                                lbDur.Text = string.Format("{0:D} jam {1:D} menit {2:D} detik",
                                                t.Hours,
                                                t.Minutes,
                                                t.Seconds);

                                double menitnya = Math.Floor(t.TotalMinutes / Properties.Settings.Default.tarifper);
                                double harga = 0.0;

                                if (lbJenis.Text == "Sepeda Motor") {
                                    harga = Properties.Settings.Default.tarifmotor * menitnya;
                                } else if (lbJenis.Text == "Mobil") {
                                    harga = Properties.Settings.Default.tarifmobil * menitnya;
                                }

                                lbHarga.Text = "Rp" + harga;

                                showBayar();
                                //matchingPerson.firstName = oReader["FirstName"].ToString();
                                //matchingPerson.lastName = oReader["LastName"].ToString();
                            }

                            myConnection.Close();
                        }
                    }
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtParkir_CellClick (object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1) {
                textBox1.Text = dtParkir[0, e.RowIndex].Value.ToString();
            } else {
                textBox1.Text = "";
            }
        }

        private void dtParkir_KeyPress (object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == 32) || e.KeyChar == 13) { // SPASI/ENTER
                if (dtParkir.SelectedRows[0].Index == 0)
                    dtParkir.Rows[0].Selected = true;
                if (dtParkir.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dtParkir.SelectedRows[0];
                    textBox1.Text = row.Cells[0].Value.ToString();
                }
                
            }
        }

        private void timer2_Tick_1 (object sender, EventArgs e) {
            textBox1.SelectAll();
            textBox1.Focus();
            timer2.Enabled = false;
        }

        private void lihatTransaksiToolStripMenuItem_Click (object sender, EventArgs e) {
            frmTrans.ShowDialog(this);
        }

        private void tentangToolStripMenuItem_Click (object sender, EventArgs e) {
            frmAbout.ShowDialog(this);
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKaryawan = new frmKaryawan(username);
            frmKaryawan.ShowDialog(this);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtParkir.Rows)
            {
                //if (Convert.ToInt32(row.Cells[0].Value) < Convert.ToInt32(row.Cells[1].Value)) {
                //row.DefaultCellStyle.BackColor = Color.Black;
                row.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
                row.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            }
        }

        private void kuotaParkirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showKuota();
        }

        private void operatorToolStripMenuItem_Click (object sender, EventArgs e) {
            frmOperator.username = this.username;
            frmOperator.ShowDialog(this);
        }

        private void usersettings () {
            try {
                using (SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True")) {
                    conn.Open();
                    frmEdit = new frmEditPengguna(this);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT a.NIK, a.nama, a.alamat, a.instansi, b.pasword FROM karyawan a INNER JOIN operator b ON a.NIK = b.NIK WHERE a.NIK = @nik";
                    cmd.Parameters.Add("@nik", SqlDbType.VarChar).Value = username;
                    cmd.Connection = conn;

                    using (SqlDataReader sdr = cmd.ExecuteReader()) {
                        while (sdr.Read()) {
                            frmEdit.txtNama.Text = sdr[1].ToString();
                            frmEdit.txtAlamat.Text = sdr[2].ToString();
                            frmEdit.txtInstansi.Text = sdr[3].ToString();
                            frmEdit.username = username;
                            frmEdit.password = sdr[4].ToString();
                        }
                    }
                    frmEdit.ShowDialog(this);
                    conn.Close();
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        private void penggunaToolStripMenuItem_Click (object sender, EventArgs e) {
            usersettings();
        }
    }
}
