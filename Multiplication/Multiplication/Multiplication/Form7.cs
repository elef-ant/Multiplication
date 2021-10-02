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
    public partial class results : Form
    {
        public results()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resutlTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f3 = new MainPage();
            f3.Show();
        }

        private void results_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void results_Load(object sender, EventArgs e)
        {
            int crs;
            int tls;
            int[] usererrors = new int[10];
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stathis\Source\Repos\elef-ant\Multiplication\Multiplication\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();

                //retrieve user data
                string query = "SELECT ec1" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                usererrors[0] = Convert.ToInt32(dta.Rows[0]["ec1"].ToString());

                query = "SELECT ec2" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[1] = Convert.ToInt32(dta.Rows[0]["ec2"].ToString());

                query = "SELECT ec3" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[2] = Convert.ToInt32(dta.Rows[0]["ec3"].ToString());

                query = "SELECT ec4" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[3] = Convert.ToInt32(dta.Rows[0]["ec4"].ToString());

                query = "SELECT ec5" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[4] = Convert.ToInt32(dta.Rows[0]["ec5"].ToString());

                query = "SELECT ec6" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[5] = Convert.ToInt32(dta.Rows[0]["ec6"].ToString());

                query = "SELECT ec7" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[6] = Convert.ToInt32(dta.Rows[0]["ec7"].ToString());

                query = "SELECT ec8" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[7] = Convert.ToInt32(dta.Rows[0]["ec8"].ToString());

                query = "SELECT ec9" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[8] = Convert.ToInt32(dta.Rows[0]["ec9"].ToString());

                query = "SELECT ec10" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                usererrors[9] = Convert.ToInt32(dta.Rows[0]["ec10"].ToString());

                query = "SELECT corrects" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                crs = Convert.ToInt32(dta.Rows[0]["corrects"].ToString());

                query = "SELECT total" +
                    " FROM ErrorTable WHERE ID = '" + Program.activeID + "'";
                cmd = new SqlCommand(query, conn);
                sda = new SqlDataAdapter(query, conn);
                dta = new DataTable();
                sda.Fill(dta);
                tls = Convert.ToInt32(dta.Rows[0]["total"].ToString());
            }
            label13.Text = usererrors[0].ToString();
            label15.Text = usererrors[1].ToString();
            label17.Text = usererrors[2].ToString();
            label19.Text = usererrors[3].ToString();
            label18.Text = usererrors[4].ToString();
            label16.Text = usererrors[5].ToString();
            label14.Text = usererrors[6].ToString();
            label12.Text = usererrors[7].ToString();
            label20.Text = usererrors[8].ToString();
            label21.Text = usererrors[9].ToString();

            double temp1 = Convert.ToDouble(crs);
            double temp2 = Convert.ToDouble(tls);
            double temp = (temp1 / temp2) * 100;

            if (temp2 == 0)
            {
                label23.Text = "--";
            }
            else
            {
                label23.Text = temp.ToString("0.0") + "%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Προβάλλονται τα λάθη σας ανά προπαίδεια και το ποσοστό σωστών απαντήσεων σε όλα τα τεστ συνολικά.", "Βοήθεια!");
        }
    }
}
