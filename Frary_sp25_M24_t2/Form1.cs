

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
        // ICA 6 - declare variable for each filename
        private string cfgFile = "DiscountCFG.txt";
        private string logFile = "LogTrans.txt";
        const string REGULAR = "Regular";
        const string GOLD = "Gold";
        const string ELITE = "Elite";
        // ICA 7
        private double regularDiscount;
        private double goldDiscount;
        private double eliteDiscount;


        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader srCfg;
            rdoRegular.Checked = true;
            bool fileWasNotFound = true;
            do
            {
                try
                {
                    srCfg = File.OpenText(cfgFile);
                    fileWasNotFound = false;
                    regularDiscount = double.Parse(srCfg.ReadLine());
                    goldDiscount = double.Parse(srCfg.ReadLine());
                    eliteDiscount = double.Parse(srCfg.ReadLine());
                    srCfg.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message + " Please enter a new file name", "File Not Found");
                    OFD.ShowDialog();
                    cfgFile = OFD.FileName;
                }
                catch (IOException ex)
                {
                    // will do nexttime
                }
            } while (fileWasNotFound);

            
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
            bool priceValid, qValid;
            // declare streamwrite - ICA 6
            StreamWriter log;


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
                        percentDiscount = regularDiscount;
                        break;
                    case GOLD:
                        percentDiscount = goldDiscount;
                        break;
                    case ELITE:
                        percentDiscount = eliteDiscount;
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
                lstOut.Items.Add("The Customer type is " + customerType);
                lstOut.Items.Add("The widget price is " + widgetPrice.ToString("C"));
                lstOut.Items.Add("The amount of widgets bought is " + quantity.ToString("N0"));
                lstOut.Items.Add("The total cost for this transaction is " + totalCost.ToString("C"));
                lstOut.Items.Add("The percent is is " + percentDiscount.ToString("p1"));
           /*
                lstOut.Items.Add(DateTime.Now.ToString("t"));
                lstOut.Items.Add(DateTime.Now.ToString("T"));
                lstOut.Items.Add(DateTime.Now.ToString("d"));
                lstOut.Items.Add(DateTime.Now.ToString("D"));
                lstOut.Items.Add(DateTime.Now.ToString("G"));
           */
                btnClear.Focus();
                // this opens the log file for append
                // ICA 6
                // Opening file to append
                log = File.AppendText(logFile);
                // write each line form log fiel and Beginning of tranactioo
                log.WriteLine("*************** Beginning of Transaction " + DateTime.Now.ToString("G") +  "  *****************");
                log.WriteLine("The widget name is " + widgetName);
                log.WriteLine("The Customer type is " + customerType);
                log.WriteLine("The widget price is " + widgetPrice.ToString("C"));
                log.WriteLine("The amount of widgets bought is " + quantity.ToString("N0"));
                log.WriteLine("The total cost for this transaction is " + totalCost.ToString("C"));
                log.WriteLine("The percent is is " + percentDiscount.ToString("p1"));
                // ICA6 -close the file
              log.Close();

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
