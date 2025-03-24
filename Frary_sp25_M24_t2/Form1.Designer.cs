namespace Frary_sp25_M24_t2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtWidgetName = new TextBox();
            label3 = new Label();
            txtWidgetPrice = new TextBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lstOut = new ListBox();
            groupBox1 = new GroupBox();
            rdoElite = new RadioButton();
            rdoGold = new RadioButton();
            rdoRegular = new RadioButton();
            OFD = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "Frary's Widget Factory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 163);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Widget Name";
            // 
            // txtWidgetName
            // 
            txtWidgetName.Location = new Point(161, 160);
            txtWidgetName.Name = "txtWidgetName";
            txtWidgetName.Size = new Size(241, 23);
            txtWidgetName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 204);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Widget Price";
            // 
            // txtWidgetPrice
            // 
            txtWidgetPrice.Location = new Point(161, 201);
            txtWidgetPrice.Name = "txtWidgetPrice";
            txtWidgetPrice.Size = new Size(236, 23);
            txtWidgetPrice.TabIndex = 4;
            txtWidgetPrice.Text = "10";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(161, 242);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(236, 23);
            txtQuantity.TabIndex = 6;
            txtQuantity.Text = "20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 245);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Quantity";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(49, 416);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 39);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "&Display Answer";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(216, 416);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 39);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(388, 416);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 39);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(63, 316);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(400, 94);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoElite);
            groupBox1.Controls.Add(rdoGold);
            groupBox1.Controls.Add(rdoRegular);
            groupBox1.Location = new Point(58, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 63);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Type";
            // 
            // rdoElite
            // 
            rdoElite.AutoSize = true;
            rdoElite.Location = new Point(305, 29);
            rdoElite.Name = "rdoElite";
            rdoElite.Size = new Size(47, 19);
            rdoElite.TabIndex = 2;
            rdoElite.Text = "Elite";
            rdoElite.UseVisualStyleBackColor = true;
            rdoElite.CheckedChanged += rdoElite_CheckedChanged;
            // 
            // rdoGold
            // 
            rdoGold.AutoSize = true;
            rdoGold.Location = new Point(168, 29);
            rdoGold.Name = "rdoGold";
            rdoGold.Size = new Size(50, 19);
            rdoGold.TabIndex = 1;
            rdoGold.Text = "Gold";
            rdoGold.UseVisualStyleBackColor = true;
            rdoGold.CheckedChanged += rdoGold_CheckedChanged;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(31, 29);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(65, 19);
            rdoRegular.TabIndex = 0;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            rdoRegular.CheckedChanged += rdoRegular_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 477);
            Controls.Add(groupBox1);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtWidgetPrice);
            Controls.Add(label3);
            Controls.Add(txtWidgetName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Your Name Here";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWidgetName;
        private Label label3;
        private TextBox txtWidgetPrice;
        private TextBox txtQuantity;
        private Label label4;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnQuit;
        private ListBox lstOut;
        private GroupBox groupBox1;
        private RadioButton rdoElite;
        private RadioButton rdoGold;
        private RadioButton rdoRegular;
        private OpenFileDialog OFD;
    }
}
