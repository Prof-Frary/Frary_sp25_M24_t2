

namespace Frary_sp25_M24_t2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Class level variable
        private string customerType;
        const string REGULAR = "Regular";
        const string GOLD = "Gold";
        const string ELITE = "Elite";


        private void Form1_Load(object sender, EventArgs e)
        {
            rdoRegular.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtQuantity.Clear();
            txtWidgetName.Clear();
            txtWidgetPrice.Clear();
            lstOut.Items.Clear();
            txtWidgetName.Focus();
            rdoRegular.Checked = true;


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSel;
            buttonSel = MessageBox.Show(
                "Do you really want to quit?",
                "Exiting...",
                MessageBoxButtons.YesNo);
            if (buttonSel == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string widgetName;
            int quantity;
            double widgetPrice, percentDiscount, totalCost;
            bool priceValid, qValid, disValid;
            //read text boxes into variables 
            widgetName = txtWidgetName.Text;
            //  percentDiscount = 0.25;
            // Parse converts strings to ints or double
            /*
            widgetPrice = double.Parse(txtWidgetPrice.Text);
            quantity = int.Parse(txtQuantity.Text);
            percentDiscount = double.Parse(txtPctDiscount.Text)/100;
            */
            //convert parses to tryParse
            priceValid = double.TryParse(txtWidgetPrice.Text, out widgetPrice);
            qValid = int.TryParse(txtQuantity.Text, out quantity);
            //    disValid = double.TryParse(txtPctDiscount.Text, out percentDiscount);

            if (priceValid && qValid)
            {
                switch (customerType)
                {
                    case REGULAR:
                        percentDiscount = 0.0;
                        break;
                    case GOLD:
                        percentDiscount = 0.10;
                        break;
                    case ELITE:
                        percentDiscount = 0.20;
                        break;
                    default:
                        lstOut.Items.Add("This should never happen");
                        percentDiscount = 0.0;
                        break;
                }
                //Processing
                totalCost = widgetPrice * quantity;

                // Output

                lstOut.Items.Add("The widget name is " + widgetName);
                lstOut.Items.Add("The widget price is " + widgetPrice.ToString("C"));
                lstOut.Items.Add("The amount of widgets bought is " + quantity.ToString("N0"));
                lstOut.Items.Add("The total cost for this transaction is " + totalCost.ToString("C"));
                lstOut.Items.Add("The percent is is " + percentDiscount.ToString("p1"));
                btnClear.Focus();
                //  lstOut.Items.Add(Math.Sqrt(16));
                // lstOut.Items.Add(Math.Pow(4, 3));
                // + - * / %
            }
            else
            {
                if (!qValid)
                {
                    lstOut.Items.Add("The quantity was not entered as a whole numeric value");
                    txtQuantity.Focus();
                }
                if (!priceValid)
                {
                    lstOut.Items.Add("The widget price was not entered as a numeric value");
                    txtWidgetPrice.Focus();
                }


            }


        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {

            // this will run in cases where check = true and false our code should oy run when true

            if (rdoRegular.Checked)
            {
                customerType = REGULAR;
            }
        }

        private void rdoGold_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGold.Checked)
            {
                customerType = GOLD;
            }
        }

        private void rdoElite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoElite.Checked)
            {
                customerType = ELITE;
            }
        }
    }
}
