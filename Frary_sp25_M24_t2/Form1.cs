

namespace Frary_sp25_M24_t2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            txtWidgetName.Clear();
            txtWidgetPrice.Clear();
            lstOut.Items.Clear();
            txtWidgetName.Focus();


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string widgetName;
            int quantity;
            double widgetPrice, percentDiscount, totalCost;
            bool priceValid, qValid, disValid;
            //read text boxes into variables 
            widgetName = txtWidgetName.Text;
            // Parse converts strings to ints or double
            /*
            widgetPrice = double.Parse(txtWidgetPrice.Text);
            quantity = int.Parse(txtQuantity.Text);
            percentDiscount = double.Parse(txtPctDiscount.Text)/100;
            */
            //convert parses to tryParse
            priceValid = double.TryParse(txtWidgetPrice.Text, out widgetPrice);
            qValid = int.TryParse(txtQuantity.Text, out quantity);
            disValid = double.TryParse(txtPctDiscount.Text, out percentDiscount);

            if (priceValid && qValid && disValid)
            {
                totalCost = widgetPrice * quantity;
                lstOut.Items.Add("The widget name is " + widgetName);
                lstOut.Items.Add("The widget price is " + widgetPrice.ToString("C"));
                lstOut.Items.Add("The amount of widgets bought is " + quantity.ToString("N0"));
                lstOut.Items.Add("The total cost for this transaction is " + totalCost.ToString("C"));
                lstOut.Items.Add("The percent is is " + percentDiscount.ToString("p1"));
              //  lstOut.Items.Add(Math.Sqrt(16));
               // lstOut.Items.Add(Math.Pow(4, 3));
                // + - * / %
            }else
            {
                lstOut.Items.Add("some of the numric entruies were not entered correctly");
            }


        }
    }
}
