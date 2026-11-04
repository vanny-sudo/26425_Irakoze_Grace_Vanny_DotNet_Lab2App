namespace Lab2App
{
    partial class MushroomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInfo = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(333, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom Guess";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.Gold;
            lblInfo.Location = new Point(159, 103);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(593, 76);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Think of one of these mushrooms: Agaric Jaunissant, Amanite tue-mouche, Cepe de bordeaux, Coprin chevelu, Girolle, Pied bleu";
            lblInfo.Click += lblInfo_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Purple;
            lblQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.Gold;
            lblQuestion.Location = new Point(229, 192);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(420, 52);
            lblQuestion.TabIndex = 2;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.Violet;
            btnYes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.Black;
            btnYes.Location = new Point(229, 293);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(169, 63);
            btnYes.TabIndex = 3;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Violet;
            btnNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(488, 293);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(161, 63);
            btnNo.TabIndex = 4;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Violet;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(110, 410);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 61);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Violet;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(607, 410);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 61);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(921, 520);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom";
            Load += MushroomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Button btnBack;
        private Button btnLogout;
    }
}