using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frary_sp25_M24_t2
{
    public partial class Form2 : Form
    {
        Form1 tForm;
        public Form2(Form1 f1)
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
            sw = File.CreateText(tForm.cfgFile);

            sw.Close();
            
        }
    }
}
