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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            lessons f4 = new lessons();
            f4.Show();
        }

        private void test_Load(object sender, EventArgs e)
        {
            int[] askiseis = new int[20];
            List<int> enotites = new List<int>();
            int counter = 0; ;
            Random rnd = new Random();
            if (Program.examChoice == 1)
            {
                enotites.Clear();
                enotites.Add(1);
                enotites.Add(2);
                enotites.Add(3);
                enotites.Add(4);
                enotites.Add(5);
                enotites.Add(6);
                enotites.Add(7);
                enotites.Add(8);
                enotites.Add(9);
                enotites.Add(10);
                label1.Text = "Έχετε επιλέξει τις επαναληπτικές ασκήσεις όλων των ενοτήτων.";
                counter = 10;

            }
            else if (Program.examChoice == 0)
            {
                enotites.Clear();
                for (int i = 0; i < 10; i++)
                {
                    if (Program.epilegmena[i] == 1)
                    {
                        enotites.Add(i + 1);
                        counter++;
                    }
                }
                string epwp = "";
                if (counter == 1)
                {
                    epwp = enotites.ElementAt(0).ToString() + ".";
                }
                else if (counter == 2)
                {
                    for (int i = 0; i < counter; i++)
                    {
                        if (i != counter - 1)
                        {
                            epwp = epwp + " " + enotites.ElementAt(i).ToString() + " ";
                        }
                        else
                        {
                            epwp = epwp + " και " + enotites.ElementAt(i).ToString() + ".";
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < counter; i++)
                    {
                        if (i != counter - 1)
                        {
                            epwp = epwp + " " + enotites.ElementAt(i).ToString() + ", ";
                        }
                        else
                        {
                            epwp = epwp + " και " + enotites.ElementAt(i).ToString() + ".";
                        }

                    }
                }

                if (counter == 1)
                {
                    label1.Text = "Έχeτε επιλέξει την ενότητα" + epwp;
                }
                else
                {
                    label1.Text = "Έχeτε επιλέξει τις ενότητες" + epwp;
                }
            }
            else if (Program.examChoice == 2)
            {
                label1.Text = "Έχετε επιλέξει ασκήσεις με βάση τα λάθη σας.";
                enotites.Clear();
                int crs;
                int tls;
                int[] usererrors = new int[10];
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stathis\Source\Repos\elef-ant\Multiplication\Multiplication\Database1.mdf;Integrated Security=True"))
                {
                    //int crs;
                    //int tls;
                    //int[] usererrors = new int[10];

                    conn.Open();

                    //retrieve user data
                    //corrects
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

                for (int i = 0; i < 10; i++)
                {
                    if (usererrors[i] > 5)
                    {
                        counter++;
                        enotites.Add(i + 1);
                    }
                }
            }
            if (counter == 0) // ισχύει μόνο αν έχει επιλέξει ασκήσεις με βάση τα λάθη του, αλλά δεν έχει αρκετά λάθη.
            {
                enotites.Clear();
                enotites.Add(1);
                enotites.Add(2);
                enotites.Add(3);
                enotites.Add(4);
                enotites.Add(5);
                enotites.Add(6);
                enotites.Add(7);
                enotites.Add(8);
                enotites.Add(9);
                enotites.Add(10);
                label1.Text = "Δεν έχετε αρκετές αδυναμίες. Δοκιμάστε επαναλληπτικές ασκήσεις.";
                counter = 10;
                for (int i = 0; i < 20; i++)
                {
                    int pop = rnd.Next(0, counter);
                    askiseis[i] = enotites.ElementAt(pop);
                }
            }
            else //Δημιουργία ασκήσεων.
            {
                for (int i = 0; i < 20; i++)
                {
                    int pop = rnd.Next(0, counter);
                    askiseis[i] = enotites.ElementAt(pop);
                }
            }            


            label2.Text = askiseis[0].ToString();
            int pr1 = rnd.Next(1, 11);
            label4.Text = pr1.ToString();

            label9.Text = askiseis[1].ToString();
            pr1 = rnd.Next(1, 11);
            label7.Text = pr1.ToString();

            label13.Text = askiseis[2].ToString();
            pr1 = rnd.Next(1, 11);
            label11.Text = pr1.ToString();

            label17.Text = askiseis[3].ToString();
            pr1 = rnd.Next(1, 11);
            label15.Text = pr1.ToString();

            label21.Text = askiseis[4].ToString();
            pr1 = rnd.Next(1, 11);
            label19.Text = pr1.ToString();

            label25.Text = askiseis[5].ToString();
            pr1 = rnd.Next(1, 11);
            label23.Text = pr1.ToString();

            label29.Text = askiseis[6].ToString();
            pr1 = rnd.Next(1, 11);
            label27.Text = pr1.ToString();

            label33.Text = askiseis[7].ToString();
            pr1 = rnd.Next(1, 11);
            label31.Text = pr1.ToString();

            label37.Text = askiseis[8].ToString();
            pr1 = rnd.Next(1, 11);
            label35.Text = pr1.ToString();

            label41.Text = askiseis[9].ToString();
            pr1 = rnd.Next(1, 11);
            label39.Text = pr1.ToString();

            label45.Text = askiseis[10].ToString();
            pr1 = rnd.Next(1, 11);
            label43.Text = pr1.ToString();

            label49.Text = askiseis[11].ToString();
            pr1 = rnd.Next(1, 11);
            label47.Text = pr1.ToString();

            label53.Text = askiseis[12].ToString();
            pr1 = rnd.Next(1, 11);
            label51.Text = pr1.ToString();

            label57.Text = askiseis[13].ToString();
            pr1 = rnd.Next(1, 11);
            label55.Text = pr1.ToString();

            label61.Text = askiseis[14].ToString();
            pr1 = rnd.Next(1, 11);
            label59.Text = pr1.ToString();

            label65.Text = askiseis[15].ToString();
            pr1 = rnd.Next(1, 11);
            label63.Text = pr1.ToString();

            label69.Text = askiseis[16].ToString();
            pr1 = rnd.Next(1, 11);
            label67.Text = pr1.ToString();

            label73.Text = askiseis[17].ToString();
            pr1 = rnd.Next(1, 11);
            label71.Text = pr1.ToString();

            label77.Text = askiseis[18].ToString();
            pr1 = rnd.Next(1, 11);
            label75.Text = pr1.ToString();

            label81.Text = askiseis[19].ToString();
            pr1 = rnd.Next(1, 11);
            label79.Text = pr1.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim() == string.Empty) || (textBox2.Text.Trim() == string.Empty) || (textBox3.Text.Trim() == string.Empty) || (textBox4.Text.Trim() == string.Empty) || (textBox5.Text.Trim() == string.Empty) || (textBox6.Text.Trim() == string.Empty) || (textBox7.Text.Trim() == string.Empty) || (textBox8.Text.Trim() == string.Empty) || (textBox9.Text.Trim() == string.Empty) || (textBox10.Text.Trim() == string.Empty) || (textBox11.Text.Trim() == string.Empty) || (textBox12.Text.Trim() == string.Empty) || (textBox13.Text.Trim() == string.Empty) || (textBox14.Text.Trim() == string.Empty) || (textBox15.Text.Trim() == string.Empty) || (textBox16.Text.Trim() == string.Empty) || (textBox17.Text.Trim() == string.Empty) || (textBox18.Text.Trim() == string.Empty) || (textBox19.Text.Trim() == string.Empty) || (textBox20.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Παρακαλώ απαντήστε σε όλες τις ερωτήσεις");
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                int errorcnt = 0;
                int[] errorAr = new int[10];
                int correctcnt = 0;

                int temp1 = Int32.Parse(label2.Text);
                int temp2 = Int32.Parse(label4.Text);
                int temp3 = Int32.Parse(textBox1.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox1.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox1.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label9.Text);
                temp2 = Int32.Parse(label7.Text);
                temp3 = Int32.Parse(textBox2.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox2.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox2.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label13.Text);
                temp2 = Int32.Parse(label11.Text);
                temp3 = Int32.Parse(textBox3.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox3.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox3.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label15.Text);
                temp2 = Int32.Parse(label17.Text);
                temp3 = Int32.Parse(textBox4.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox4.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox4.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label19.Text);
                temp2 = Int32.Parse(label21.Text);
                temp3 = Int32.Parse(textBox5.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox5.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox5.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label23.Text);
                temp2 = Int32.Parse(label25.Text);
                temp3 = Int32.Parse(textBox6.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox6.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox6.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label27.Text);
                temp2 = Int32.Parse(label29.Text);
                temp3 = Int32.Parse(textBox7.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox7.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox7.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label31.Text);
                temp2 = Int32.Parse(label33.Text);
                temp3 = Int32.Parse(textBox8.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox8.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox8.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label35.Text);
                temp2 = Int32.Parse(label37.Text);
                temp3 = Int32.Parse(textBox9.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox9.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox9.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label39.Text);
                temp2 = Int32.Parse(label41.Text);
                temp3 = Int32.Parse(textBox10.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox10.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox10.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label43.Text);
                temp2 = Int32.Parse(label45.Text);
                temp3 = Int32.Parse(textBox11.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox11.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox11.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label47.Text);
                temp2 = Int32.Parse(label49.Text);
                temp3 = Int32.Parse(textBox12.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox12.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox12.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label51.Text);
                temp2 = Int32.Parse(label53.Text);
                temp3 = Int32.Parse(textBox13.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox13.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox13.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label55.Text);
                temp2 = Int32.Parse(label57.Text);
                temp3 = Int32.Parse(textBox14.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox14.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox14.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label59.Text);
                temp2 = Int32.Parse(label61.Text);
                temp3 = Int32.Parse(textBox15.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox15.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox15.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label63.Text);
                temp2 = Int32.Parse(label65.Text);
                temp3 = Int32.Parse(textBox16.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox16.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox16.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label67.Text);
                temp2 = Int32.Parse(label69.Text);
                temp3 = Int32.Parse(textBox17.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox17.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox17.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label73.Text);
                temp2 = Int32.Parse(label71.Text);
                temp3 = Int32.Parse(textBox18.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox18.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox18.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label77.Text);
                temp2 = Int32.Parse(label75.Text);
                temp3 = Int32.Parse(textBox19.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox19.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox19.BackColor = Color.Green;
                }
                temp1 = Int32.Parse(label79.Text);
                temp2 = Int32.Parse(label81.Text);
                temp3 = Int32.Parse(textBox20.Text);
                if (temp3 != (temp2 * temp1))
                {
                    errorcnt++;
                    textBox20.BackColor = Color.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        if (temp1 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                        else if (temp2 == (i + 1))
                        {
                            errorAr[i] = errorAr[i] + 1;
                        }
                    }
                }
                else
                {
                    textBox20.BackColor = Color.Green;
                }
                label82.Text = "Αριθμός λαθών: " + errorcnt.ToString();
                correctcnt = 20 - errorcnt;

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

                    //update user data
                    query = " UPDATE ErrorTABLE SET EC1 = @ec1, EC2 = @ec2, EC3 = @ec3, EC4 = @ec4, EC5 = @ec5, EC6 = @ec6, EC7 = @ec7, EC8 = @ec8, EC9 = @ec9, EC10 = @ec10, CORRECTS = @Corrects,TOTAL = @Total WHERE ID = '" + Program.activeID + "'";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("ec1", usererrors[0] + errorAr[0]);
                    cmd.Parameters.Add("ec2", usererrors[1] + errorAr[1]);
                    cmd.Parameters.Add("ec3", usererrors[2] + errorAr[2]);
                    cmd.Parameters.Add("ec4", usererrors[3] + errorAr[3]);
                    cmd.Parameters.Add("ec5", usererrors[4] + errorAr[4]);
                    cmd.Parameters.Add("ec6", usererrors[5] + errorAr[5]);
                    cmd.Parameters.Add("ec7", usererrors[6] + errorAr[6]);
                    cmd.Parameters.Add("ec8", usererrors[7] + errorAr[7]);
                    cmd.Parameters.Add("ec9", usererrors[8] + errorAr[8]);
                    cmd.Parameters.Add("ec10", usererrors[9] + errorAr[9]);
                    cmd.Parameters.AddWithValue("Corrects", crs + correctcnt);
                    cmd.Parameters.AddWithValue("Total", tls + 20);
                    cmd.ExecuteNonQuery();


                    if ((Program.examChoice == 2) && (errorcnt < 4))
                    {
                        query = " UPDATE ErrorTABLE SET EC1 = @ec1, EC2 = @ec2, EC3 = @ec3, EC4 = @ec4, EC5 = @ec5, EC6 = @ec6, EC7 = @ec7, EC8 = @ec8, EC9 = @ec9, EC10 = @ec10 WHERE ID = '" + Program.activeID + "'";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("ec1", 1);
                        cmd.Parameters.Add("ec2", 1);
                        cmd.Parameters.Add("ec3", 1);
                        cmd.Parameters.Add("ec4", 1);
                        cmd.Parameters.Add("ec5", 1);
                        cmd.Parameters.Add("ec6", 1);
                        cmd.Parameters.Add("ec7", 1);
                        cmd.Parameters.Add("ec8", 1);
                        cmd.Parameters.Add("ec9", 1);
                        cmd.Parameters.Add("ec10", 1);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] askiseis = new int[20];
            List<int> enotites = new List<int>();
            int counter = 0; ;
            Random rnd = new Random();
            if (Program.examChoice == 1)
            {
                enotites.Clear();
                enotites.Add(1);
                enotites.Add(2);
                enotites.Add(3);
                enotites.Add(4);
                enotites.Add(5);
                enotites.Add(6);
                enotites.Add(7);
                enotites.Add(8);
                enotites.Add(9);
                enotites.Add(10);
                label1.Text = "Έχeτε επιλέξει τις επαναληπτικές ασκήσεις όλων των ενοτήτων";
                counter = 10;

            }
            else if (Program.examChoice == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Program.epilegmena[i] == 1)
                    {
                        enotites.Add(i + 1);
                        counter++;
                    }
                }
            }
            else if (Program.examChoice == 2)
            {
                enotites.Clear();
                int crs;
                int tls;
                int[] usererrors = new int[10];
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stathis\Source\Repos\elef-ant\Multiplication\Multiplication\Database1.mdf;Integrated Security=True"))
                {
                    //int crs;
                    //int tls;
                    //int[] usererrors = new int[10];

                    conn.Open();

                    //retrieve user data
                    //corrects
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

                for (int i = 0; i < 10; i++)
                {
                    if (usererrors[i] > 5)
                    {
                        counter++;
                        enotites.Add(i + 1);
                    }
                }
            }

            // φτιαχνει τις 20 ασκήσεις
            if (counter == 0) // ισχύει μόνο αν έχει επιλέξει ασκήσεις με βάση τα λάθη του, αλλά δεν έχει αρκετά λάθη.
            {
                enotites.Clear();
                enotites.Add(1);
                enotites.Add(2);
                enotites.Add(3);
                enotites.Add(4);
                enotites.Add(5);
                enotites.Add(6);
                enotites.Add(7);
                enotites.Add(8);
                enotites.Add(9);
                enotites.Add(10);
                label1.Text = "Δεν έχετε αρκετές αδυναμίες. Δοκιμάστε επαναλληπτικές ασκήσεις.";
                counter = 10;
                for (int i = 0; i < 20; i++)
                {
                    int pop = rnd.Next(0, counter);
                    askiseis[i] = enotites.ElementAt(pop);
                }
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    int pop = rnd.Next(0, counter);
                    askiseis[i] = enotites.ElementAt(pop);
                }
            }

            //βάζει τιμές στα label ανάλογα τις ενότητες
            label2.Text = askiseis[0].ToString();
            int pr1 = rnd.Next(1, 11);
            label4.Text = pr1.ToString();

            label9.Text = askiseis[1].ToString();
            pr1 = rnd.Next(1, 11);
            label7.Text = pr1.ToString();

            label13.Text = askiseis[2].ToString();
            pr1 = rnd.Next(1, 11);
            label11.Text = pr1.ToString();

            label17.Text = askiseis[3].ToString();
            pr1 = rnd.Next(1, 11);
            label15.Text = pr1.ToString();

            label21.Text = askiseis[4].ToString();
            pr1 = rnd.Next(1, 11);
            label19.Text = pr1.ToString();

            label25.Text = askiseis[5].ToString();
            pr1 = rnd.Next(1, 11);
            label23.Text = pr1.ToString();

            label29.Text = askiseis[6].ToString();
            pr1 = rnd.Next(1, 11);
            label27.Text = pr1.ToString();

            label33.Text = askiseis[7].ToString();
            pr1 = rnd.Next(1, 11);
            label31.Text = pr1.ToString();

            label37.Text = askiseis[8].ToString();
            pr1 = rnd.Next(1, 11);
            label35.Text = pr1.ToString();

            label41.Text = askiseis[9].ToString();
            pr1 = rnd.Next(1, 11);
            label39.Text = pr1.ToString();

            label45.Text = askiseis[10].ToString();
            pr1 = rnd.Next(1, 11);
            label43.Text = pr1.ToString();

            label49.Text = askiseis[11].ToString();
            pr1 = rnd.Next(1, 11);
            label47.Text = pr1.ToString();

            label53.Text = askiseis[12].ToString();
            pr1 = rnd.Next(1, 11);
            label51.Text = pr1.ToString();

            label57.Text = askiseis[13].ToString();
            pr1 = rnd.Next(1, 11);
            label55.Text = pr1.ToString();

            label61.Text = askiseis[14].ToString();
            pr1 = rnd.Next(1, 11);
            label59.Text = pr1.ToString();

            label65.Text = askiseis[15].ToString();
            pr1 = rnd.Next(1, 11);
            label63.Text = pr1.ToString();

            label69.Text = askiseis[16].ToString();
            pr1 = rnd.Next(1, 11);
            label67.Text = pr1.ToString();

            label73.Text = askiseis[17].ToString();
            pr1 = rnd.Next(1, 11);
            label71.Text = pr1.ToString();

            label77.Text = askiseis[18].ToString();
            pr1 = rnd.Next(1, 11);
            label75.Text = pr1.ToString();

            label81.Text = askiseis[19].ToString();
            pr1 = rnd.Next(1, 11);
            label79.Text = pr1.ToString();

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox15.BackColor = Color.White;
            textBox16.BackColor = Color.White;
            textBox17.BackColor = Color.White;
            textBox18.BackColor = Color.White;
            textBox19.BackColor = Color.White;
            textBox20.BackColor = Color.White;

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
            textBox11.Text = String.Empty;
            textBox12.Text = String.Empty;
            textBox13.Text = String.Empty;
            textBox14.Text = String.Empty;
            textBox15.Text = String.Empty;
            textBox16.Text = String.Empty;
            textBox17.Text = String.Empty;
            textBox18.Text = String.Empty;
            textBox19.Text = String.Empty;
            textBox20.Text = String.Empty;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συμπληρώστε τις απαντήσεις σας και πατήστε 'Υποβολή'. Αν θέλετε καινούριες ασκήσεις, πατήστε 'Νέες Ασκήσεις'.", "Βοήθεια!");
        }
    }
}
