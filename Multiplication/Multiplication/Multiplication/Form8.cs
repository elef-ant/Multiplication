using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class pinakes : Form
    {
        public pinakes()
        {
            InitializeComponent();
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pinakes_Load(object sender, EventArgs e)
        {
            int i = Program.lessonChoice;
            label00.Text = i.ToString();
            label10.Text = i.ToString();
            label20.Text = i.ToString();
            label30.Text = i.ToString();
            label40.Text = i.ToString();
            label50.Text = i.ToString();
            label60.Text = i.ToString();
            label70.Text = i.ToString();
            label80.Text = i.ToString();
            label90.Text = i.ToString();

            int a = (Int32.Parse(label00.Text) * Int32.Parse(label01.Text) ) ;
            label02.Text = a.ToString();
            a = (Int32.Parse(label10.Text) * Int32.Parse(label11.Text));
            label12.Text = a.ToString();
            a = (Int32.Parse(label20.Text) * Int32.Parse(label21.Text));
            label22.Text = a.ToString();
            a = (Int32.Parse(label30.Text) * Int32.Parse(label31.Text));
            label32.Text = a.ToString();
            a = (Int32.Parse(label40.Text) * Int32.Parse(label41.Text));
            label42.Text = a.ToString();
            a = (Int32.Parse(label50.Text) * Int32.Parse(label51.Text));
            label52.Text = a.ToString();
            a = (Int32.Parse(label60.Text) * Int32.Parse(label61.Text));
            label62.Text = a.ToString();
            a = (Int32.Parse(label70.Text) * Int32.Parse(label71.Text));
            label72.Text = a.ToString();
            a = (Int32.Parse(label80.Text) * Int32.Parse(label81.Text));
            label82.Text = a.ToString();
            a = (Int32.Parse(label90.Text) * Int32.Parse(label91.Text));
            label92.Text = a.ToString();

            label27.Text = "Προπαίδεια του " + i.ToString();

            if (Program.lessonChoice == 1)
            {
                label28.Text = "Κάθε αριθμός που πολλαπλασιάζεται με το 1 παραμένει ίδιος!";
            }
            else if (Program.lessonChoice == 2)
            {
                label28.Text = "Κάθε αριθμός που πολλαπλασιάζεται με το 2 είναι σαν να προστίθεται με τον εαυτό του!";
            }
            else if (Program.lessonChoice == 3)
            {
                label28.Text = "Το άθροισμα των ψηφίων των πολλαπλάσιων του 3 ισούται με 3, 6 ή 9!";
            }
            else if (Program.lessonChoice == 4)
            {
                label28.Text = "";
                pictureBox1.Hide();
            }
            else if (Program.lessonChoice == 5)
            {
                label28.Text = "Όλα τα πολλαπλάσια του 5 τελειώνουν σε '0' ή '5'!";
            }
            else if (Program.lessonChoice == 6)
            {
                label28.Text = "Το άθροισμα των ψηφίων των πολλαπλάσιων του 6 ισούται με 3, 6 ή 9!";
            }
            else if (Program.lessonChoice == 7)
            {
                label28.Text = "";
                pictureBox1.Hide();
            }
            else if (Program.lessonChoice == 8)
            {
                label28.Text = "";
                pictureBox1.Hide();
            }
            else if (Program.lessonChoice == 9)
            {
                label28.Text = "Το άθροισμα των ψηφίων των πολλαπλάσιων του 9 ισούται με 9!";
            }
            else if (Program.lessonChoice == 10)
            {
                label28.Text = "Κάθε αριθμός που πολλαπλασιάζεται με το 10 απλά αποκτά ένα '0' στο τέλος!";
            }

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lessons f4 = new lessons();
            f4.Show();
        }

        private void pinakes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
