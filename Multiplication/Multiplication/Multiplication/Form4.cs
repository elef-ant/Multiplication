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
    public partial class lessons : Form
    {
        public lessons()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            testlist f5 = new testlist();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 1;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 2;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 3;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 4;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 5;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 6;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 7;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 8;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 9;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.lessonChoice = 10;
            this.Hide();
            pinakes f8 = new pinakes();
            f8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f3 = new MainPage();
            f3.Show();
        }

        private void lessons_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.examChoice = 1; //epanaliptikes askiseis
            this.Hide();
            test f6 = new test();
            f6.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατώντας κάποιο από τα 10 πρώτα κουμπιά, επιλέγετε ποιου αριθμού να μάθετε την προπαίδεια." +
                " Πατώντας 'Ασκήσεις με επιλογή ενοτήτων' θα διαλέξετε σε ποιες ενότητες θέλετε να εξεταστείτε." +
                " Πατώντας το 'Επαναληπτικές Ασκήσεις' θα εξεταστείτε σε όλες τις ενότητες.", "Βοήθεια!");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Program.examChoice = 2; //askiseis me lathi
            this.Hide();
            test f6 = new test();
            f6.Show();
        }
    }
}
