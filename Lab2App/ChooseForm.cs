using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class ChooseForm : Form
    {
        private LoginForm loginForm;

        public bool ExitOnClose = true;

        public ChooseForm(LoginForm login)
        {
            InitializeComponent();

            loginForm = login;

            this.FormClosed += (s, e) =>
            {
                if (ExitOnClose)
                {
                    Application.Exit();
                }
            };
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm(loginForm, this);
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm(loginForm, this);
            mushroom.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

