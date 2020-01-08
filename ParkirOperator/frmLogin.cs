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
    public partial class frmLogin : Form {
        private frmConfig qq = new frmConfig();
        public frmLogin () {
            InitializeComponent();
        }

        private void loginProcess () {
            try {
                frmMain frm = new frmMain(this);
                bool login = false;
                string nama = "";
                using (SqlConnection myConnection = new SqlConnection()) {
                    string oString = "SELECT * FROM operator WHERE NIK = @nik";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.Add("@nik", SqlDbType.VarChar).Value = txtNIK.Text;

                    myConnection.ConnectionString = @"Data Source=" + Properties.Settings.Default.Server + "; Initial Catalog=" + Properties.Settings.Default.DBName + "; Integrated Security=True";
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader()) {
                        while (oReader.Read()) {
                            if (txtPassword.Text == oReader["pasword"].ToString()) {
                                login = true;
                                if (oReader["level"].ToString() == "Admin") {
                                    frm.operatorToolStripMenuItem.Visible = true;
                                    frm.karyawanToolStripMenuItem.Visible = true;
                                } else if (oReader["level"].ToString() == "Operator") {
                                    frm.operatorToolStripMenuItem.Visible = false;
                                    frm.karyawanToolStripMenuItem.Visible = false;
                                } else {
                                    MessageBox.Show(this, "Unknown error expected. Login aborted.");
                                    return;
                                }
                                nama = oReader["nama"].ToString();
                                frm.username = oReader["NIK"].ToString();
                                frm.txtUser.Text = oReader["nama"].ToString();
                            } else {
                                login = false;
                            }
                        }

                        myConnection.Close();
                    }
                    if (login == true) {
                        MessageBox.Show(this, "Selamat datang, " + nama + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.Show();
                        this.txtNIK.Text = "";
                        this.txtPassword.Text = "";
                        this.Visible = false;
                    } else {
                        MessageBox.Show(this, "NIK/Password salah!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(this, e.ToString());
            }
            
            
        }

        private void splitContainer1_Panel2_Paint (object sender, PaintEventArgs e) {

        }

        private void label3_Click (object sender, EventArgs e) {

        }

        private void btnLogin_Click (object sender, EventArgs e) {
            loginProcess();
        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void btnConfig_Click (object sender, EventArgs e) {
            qq.tbConfig.TabPages.RemoveByKey("tabPage1");
            qq.tbConfig.TabPages.RemoveByKey("tabPage3");
            qq.ShowDialog(this);
        }

        private void txtNIK_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) txtPassword.Focus();
        }

        private void txtPassword_KeyPress (object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) loginProcess();
        }
    }
}
