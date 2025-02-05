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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(109, 33);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "Frary's Widget Factory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 93);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Widget Name";
            // 
            // txtWidgetName
            // 
            txtWidgetName.Location = new Point(158, 90);
            txtWidgetName.Name = "txtWidgetName";
            txtWidgetName.Size = new Size(241, 23);
            txtWidgetName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 134);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Widget Price";
            // 
            // txtWidgetPrice
            // 
            txtWidgetPrice.Location = new Point(158, 131);
            txtWidgetPrice.Name = "txtWidgetPrice";
            txtWidgetPrice.Size = new Size(236, 23);
            txtWidgetPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(158, 172);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(236, 23);
            txtQuantity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 175);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Quantity";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(68, 305);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 39);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "&Display Answer";
            btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(211, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 39);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(383, 305);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 39);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(58, 205);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(400, 94);
            lstOut.TabIndex = 7;
            lstOut.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 356);
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
    }
}
