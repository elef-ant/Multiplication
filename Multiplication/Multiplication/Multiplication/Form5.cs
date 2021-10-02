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
    public partial class testlist : Form
    {
        public testlist()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f3 = new MainPage();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            lessons f4 = new lessons();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε τουλάχιστον μία ενότητα.");
                return;
            }
            else
            {
                Array.Clear(Program.epilegmena, 0, Program.epilegmena.Length);
                foreach (int s in checkedListBox1.CheckedIndices)
                {
                    Program.epilegmena[s] = 1;
                }
                Program.examChoice = 0; //askiseis me epilogi
                this.Hide();
                test f6 = new test();
                f6.Show();
            }
                
        }

        private void testlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.examChoice = 1; //epanaliptikes askiseis
            this.Hide();
            test f6 = new test();
            f6.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε τις ενότητες για τις οποίες επιθυμείτε να εξεταστείτε και πατήστε 'Εκκίνηση'." +
                " Εάν επιθυμείτε να εξεταστείτε σε όλες τις ενότητες, μπορείτε να πατήσετε 'Επαναληπτικές Ασκήσεις'.", "Βοήθεια!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.examChoice = 2; //askiseis me lathi
            this.Hide();
            test f6 = new test();
            f6.Show();
        }
    }
}
