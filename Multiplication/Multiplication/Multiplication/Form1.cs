//using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtpassword.Size = new Size(this.txtpassword.Size.Width, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stathis\Source\Repos\elef-ant\Multiplication\Multiplication\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM LoginTable WHERE USERNAME = '" + txtusername.Text.Trim() + "' AND PASSWORD = '" + txtpassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);

                    if (dta.Rows.Count == 1)
                    {
                        query = "SELECT id FROM LoginTable WHERE USERNAME = '" + txtusername.Text.Trim() + "'";
                        sda = new SqlDataAdapter(query, conn);
                        sda.Fill(dta);

                        Program.activeID = Convert.ToInt32(dta.Rows[0]["id"].ToString()); 
                        Program.activeUser = txtusername.Text.Trim();
                               
                        this.Hide();
                        MainPage f3 = new MainPage();
                        f3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Δεν βρέθηκε χρήστης με αυτά τα στοιχεία. Παρακαλώ προσπαθήστε ξανά ή εγγραφείτε ως νέος χρήστης.", "Error!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registration = new Register();
            registration.ShowDialog();
        }

        private bool isValid()
        {
            if (txtpassword.Text.TrimStart() == string.Empty || txtusername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Παρακαλούμε συμπληρώστε όλα τα ζητούμενα στοιχεία.", "Error!");
                return false;
            }
            return true;
        }

        private void helpbuttom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φόρμα εισόδου στο λογαριασμό χρήστη στην εφαρμογή. " +
                "Συμπληρώστε όλα τα ζητούμενα στοιχεία και μπείτε το λογαριασμό σας πατώντας στο κουμπί 'Σύνδεση'. " +
                "Αν έχετε ήδη λογαριασμό, μπορείτε να δημιουργείσετε πατώντας στο κουμπί 'Νέος Λογαριασμός'.", "Βοήθεια!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
