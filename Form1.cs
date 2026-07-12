using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnBooks.Click += btnBooks_Click;
            btnMembers.Click += btnMembers_Click;
            btnTransactions.Click += btnTransactions_Click;
            btnLogout.Click += btnLogout_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
