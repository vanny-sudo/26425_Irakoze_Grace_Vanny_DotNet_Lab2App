using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class BicycleForm : Form
    {
        private LoginForm loginForm;
        private ChooseForm chooseForm;
        public bool ExitOnClose = true;
        public BicycleForm(LoginForm login, ChooseForm choose)
        {
            InitializeComponent();
            loginForm = login;
            chooseForm = choose;

            btnCalculate.Click -= btnCalculate_Click;
            btnCalculate.Click += btnCalculate_Click;
            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;
            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;

            this.FormClosed += (s, e) =>
            {
                if (ExitOnClose)
                {
                    Application.Exit();
                }
            };
        }

        private int GetRate(int hour)
        {
            if (hour < 7 || hour >= 21)
            {
                return 500;
            }
            if (hour < 14 || hour >= 19)
            {
                return 1000;
            }
            return 1500;
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void lblEnd_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start;
            int end;

            txtTotal.Clear();

            if (!int.TryParse(txtStart.Text.Trim(), out start))
            {
                MessageBox.Show("Please enter a valid whole number for the starting time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStart.Focus();
                return;
            }

            if (!int.TryParse(txtEnd.Text.Trim(), out end))
            {
                MessageBox.Show("Please enter a valid whole number for the ending time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd.Focus();
                return;
            }

            if (start < 0 || start > 23)
            {
                MessageBox.Show("Invalid starting time. It must be between 0 and 23.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStart.Focus();
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("Invalid ending time. It must be between 1 and 24.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnd.Focus();
                return;
            }

            if (start >= end)
            {
                MessageBox.Show("Starting time must be less than ending time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStart.Focus();
                return;
            }

            int total = 0;
            for (int hour = start; hour < end; hour++)
            {
                total += GetRate(hour);
            }

            txtTotal.Text = total + " RWF";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ExitOnClose = false;
            chooseForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
                ExitOnClose = false;
                chooseForm.ExitOnClose = false;
                chooseForm.Close();

                loginForm.ResetForm();
                loginForm.Show();
                this.Close();
         }
    }
}
