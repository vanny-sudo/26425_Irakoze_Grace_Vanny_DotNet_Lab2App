namespace Lab2App
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(246, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose an Option";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = Color.Violet;
            btnBicycle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBicycle.Location = new Point(98, 187);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(229, 81);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.BackColor = Color.Violet;
            btnMushroom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMushroom.Location = new Point(413, 187);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(233, 81);
            btnMushroom.TabIndex = 2;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            Load += ChooseForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}