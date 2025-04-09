using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frary_sp25_M24_t2
{
    internal partial class Form2 : Form
    {
        Form1 tForm;
        internal Form2(Form1 f1)
        {
            InitializeComponent();
            tForm = f1;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            // set form1 Properties
            tForm.RegularDiscount = double.Parse(txtRegular.Text);
            tForm.GoldDiscount = double.Parse(txtGold.Text);    
            tForm.EliteDiscount = double.Parse(txtElite.Text);
            //opening the config file to save the values
            sw = File.CreateText(tForm.cfgFile);
            // save the properties in the file - MAKE SURE THEY ARE IN THE CORRECT ORDER
            sw.WriteLine(tForm.RegularDiscount.ToString());
            sw.WriteLine(tForm.GoldDiscount.ToString());
            sw.WriteLine(tForm.EliteDiscount.ToString());
            sw.Close();
            this.Hide();
            
        }
    }
}
