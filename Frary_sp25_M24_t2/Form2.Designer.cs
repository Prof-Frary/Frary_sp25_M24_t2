namespace Frary_sp25_M24_t2
{
    partial class Form2
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
            label1 = new Label();
            txtRegular = new TextBox();
            txtGold = new TextBox();
            label2 = new Label();
            txtElite = new TextBox();
            label3 = new Label();
            btnReturn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 71);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Regular";
            // 
            // txtRegular
            // 
            txtRegular.Location = new Point(181, 63);
            txtRegular.Name = "txtRegular";
            txtRegular.Size = new Size(100, 23);
            txtRegular.TabIndex = 1;
            // 
            // txtGold
            // 
            txtGold.Location = new Point(181, 95);
            txtGold.Name = "txtGold";
            txtGold.Size = new Size(100, 23);
            txtGold.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 103);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Gold";
            // 
            // txtElite
            // 
            txtElite.Location = new Point(181, 129);
            txtElite.Name = "txtElite";
            txtElite.Size = new Size(100, 23);
            txtElite.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 137);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Elite";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(137, 174);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(104, 23);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return && Save";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 19);
            label4.Name = "label4";
            label4.Size = new Size(235, 21);
            label4.TabIndex = 7;
            label4.Text = "Customer Level Discount Rates";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 257);
            Controls.Add(label4);
            Controls.Add(btnReturn);
            Controls.Add(txtElite);
            Controls.Add(label3);
            Controls.Add(txtGold);
            Controls.Add(label2);
            Controls.Add(txtRegular);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Widget Program Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnReturn;
        private Label label4;
        public TextBox txtRegular;
        public TextBox txtGold;
        public TextBox txtElite;
    }
}