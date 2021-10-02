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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lessons f4 = new lessons();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            testlist f5 = new testlist();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            results f5 = new results();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.activeUser = null;
            Program.activeID = 0;
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            label1.Text = "Καλως ήρθες, " + Program.activeUser + ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατώντας το κουμπί 'Μαθήματα', ανοίγει το παράθυρο με τη θεωρία. " +
                "Με το κουμπί 'Ασκήσεις' ανοίγει το παράθυρο με την επιλογή των ασκήσεων. " +
                "Το κουμπί 'Βαθμολογίες' ανοίγει το παράθυρο με τους βαθμούς του χρήστη." +
                "Με το κουμπί 'Αποσύνδεση', γίνεται αποσύνδεση χρήστη και το κουμπί 'Έξοδος', κλέινει η εφαρμογή.'", "Βοήθεια!");
        }
    }
}
