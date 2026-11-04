namespace Lab2App
{
    partial class BicycleForm
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
            lblStart = new Label();
            txtStart = new TextBox();
            lblEnd = new Label();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnBack = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(509, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle Rental";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.ForeColor = Color.Gold;
            lblStart.Location = new Point(92, 81);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(185, 25);
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting time (0-23):";
            lblStart.Click += lblStart_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(362, 78);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(296, 31);
            txtStart.TabIndex = 2;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.ForeColor = Color.Gold;
            lblEnd.Location = new Point(92, 156);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(175, 25);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "Ending time (1-24):";
            lblEnd.Click += lblEnd_Click;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(362, 156);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(296, 31);
            txtEnd.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Violet;
            btnCalculate.Location = new Point(431, 218);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(185, 60);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Gold;
            lblTotal.Location = new Point(92, 298);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTotal_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(198, 298);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(264, 31);
            txtTotal.TabIndex = 7;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Violet;
            btnBack.Location = new Point(198, 378);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(156, 60);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Violet;
            btnLogout.Location = new Point(469, 378);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 60);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Gold;
            groupBox1.Location = new Point(724, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 251);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rental rates (per hour)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 175);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 2;
            label4.Text = "14h to 19h: 1500 RWF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 121);
            label3.Name = "label3";
            label3.Size = new Size(318, 25);
            label3.TabIndex = 1;
            label3.Text = "7h to 14h and 19h to 21h: 1000 RWF";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(298, 25);
            label2.TabIndex = 0;
            label2.Text = "0h to 7h and 21h to 24h: 500 RWF";
            label2.Click += label2_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1191, 494);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(lblEnd);
            Controls.Add(txtStart);
            Controls.Add(lblStart);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle";
            Load += BicycleForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStart;
        private TextBox txtStart;
        private Label lblEnd;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnBack;
        private Button btnLogout;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}