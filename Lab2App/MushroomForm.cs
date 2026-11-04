using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Lab2App
{
    public partial class MushroomForm : Form
    {
        private LoginForm loginForm;
        private ChooseForm chooseForm;

        public bool ExitOnClose = true;

        private enum Question
        {
            Ring,
            Forest,
            ConvexWithRing,
            Gills,
            ConvexNoRing
        }

        private Question current = Question.Ring;


        public MushroomForm(LoginForm login, ChooseForm choose)
        {
            InitializeComponent();

            loginForm = login;
            chooseForm = choose;

            btnYes.Click -= btnYes_Click;
            btnYes.Click += btnYes_Click;
            btnNo.Click -= btnNo_Click;
            btnNo.Click += btnNo_Click;
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

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            switch (current)
            {
                case Question.Ring:
                    lblQuestion.Text = "Does your mushroom have a ring?";
                    break;
                case Question.Forest:
                    lblQuestion.Text = "Does your mushroom grow in a forest?";
                    break;
                case Question.ConvexWithRing:
                case Question.ConvexNoRing:
                    lblQuestion.Text = "Does your mushroom have a convex cap?";
                    break;
                case Question.Gills:
                    lblQuestion.Text = "Does your mushroom have gills?";
                    break;
            }
        }

        private void ShowResult(string mushroom)
        {
            MessageBox.Show("Your mushroom is: " + mushroom,
                "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            current = Question.Ring;
            ShowQuestion();
        }

        private void Answer(bool yes)
        {
            switch (current)
            {
                case Question.Ring:
                    current = yes ? Question.Forest : Question.Gills;
                    break;

                case Question.Forest:
                    if (yes)
                    {
                        ShowResult("Amanite tue-mouche");
                        return;
                    }
                    current = Question.ConvexWithRing;
                    break;

                case Question.ConvexWithRing:
                    ShowResult(yes ? "Agaric Jaunissant" : "Coprin chevelu");
                    return;

                case Question.Gills:
                    if (!yes)
                    {
                        ShowResult("Cepe de bordeaux");
                        return;
                    }
                    current = Question.ConvexNoRing;
                    break;

                case Question.ConvexNoRing:
                    ShowResult(yes ? "Pied bleu" : "Girolle");
                    return;
            }

            ShowQuestion();
        }

        private void MushroomForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer(true);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ExitOnClose = false;
            chooseForm.Show();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answer(false);

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

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
