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

namespace Multiplication
{
    public partial class Register : Form
    {
        SqlCommand cmd = new SqlCommand();


        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stathis\Source\Repos\elef-ant\Multiplication\Multiplication\Database1.mdf;Integrated Security=True"))
                if (isValid())
                {
                    if (txtconfpassword.Text.Trim() == txtpassword.Text.Trim())
                    {
                        string query = "SELECT * FROM LoginTable WHERE USERNAME = '" + txtusername.Text.Trim() + "' OR EMAIL = '" + txtemail.Text.Trim() + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                        DataTable dta = new DataTable();
                        sda.Fill(dta);

                        if (dta.Rows.Count == 1)
                        {
                            MessageBox.Show("Ο χρήστης υπάρχει ήδη. Παρακαλώ κάντε είσοδο στην εφαρμογή ή δημιουργείστε νέο λογαριασμό", "Error!");
                        }
                        else
                        {
                            conn.Open();
                            query = "INSERT INTO LoginTABLE VALUES(@username,@password,@email)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("username", txtusername.Text);
                            cmd.Parameters.AddWithValue("password", txtpassword.Text);
                            cmd.Parameters.AddWithValue("email", txtemail.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ο λογαριασμός δημιουργήθηκε, παρακαλώ συνδεθείτε.", "Έτοιμο!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            query = "INSERT INTO ErrorTable " +
                                "(ec1,ec2,ec3,ec4,ec5,ec6,ec7,ec8,ec9,ec10,corrects,total) " +
                                "VALUES(@ec1,@ec2,@ec3,@ec4,@ec5,@ec6,@ec7,@ec8,@ec9,@ec10,@corrects,@total)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("ec1", 0);
                            cmd.Parameters.AddWithValue("ec2", 0);
                            cmd.Parameters.AddWithValue("ec3", 0);
                            cmd.Parameters.AddWithValue("ec4", 0);
                            cmd.Parameters.AddWithValue("ec5", 0);
                            cmd.Parameters.AddWithValue("ec6", 0);
                            cmd.Parameters.AddWithValue("ec7", 0);
                            cmd.Parameters.AddWithValue("ec8", 0);
                            cmd.Parameters.AddWithValue("ec9", 0);
                            cmd.Parameters.AddWithValue("ec10", 0);
                            cmd.Parameters.AddWithValue("corrects", 0);
                            cmd.Parameters.AddWithValue("total", 0);
                            cmd.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ο κωδικός πρόσβασης δεν επιβεβαιώθηκε. Παρακαλώ προσπαθήστε ξανά", "Error!");
                    }
                }
        }

        private bool isValid()
        {
            if (txtpassword.Text.TrimStart() == string.Empty || txtusername.Text.TrimStart() == string.Empty || txtemail.Text.TrimStart() == string.Empty || txtconfpassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Παρακαλούμε συμπληρώστε όλα τα ζητούμενα στοιχεία", "Error!");
                return false;
            }
            return true;
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void helpbutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Φόρμα δημιουργίας λογαριασμού χρήστη για την εφαρμογή. " +
                "Συμπληρώστε όλα τα ζητούμενα στοιχεία και δημιουργείστε το λογαριασμό σας πατώντας στο κουμπί 'Δημιουργία Λογαριασμού'. " +
                "Αν έχετε ήδη λογαριασμό, μπορείτε να συνδεθείτε πατώντας στο κουμπί 'Έχω ήδη λογαριασμό'.", "Βοήθεια!");
        }
    }
}
