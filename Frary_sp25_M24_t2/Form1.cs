

using Microsoft.VisualBasic.Logging;
using System.Security.Policy;

namespace Frary_sp25_M24_t2
{
    internal partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }
        // Class level variable
        private string customerType;
        // ICA 6 - declare variable for each filename
        internal string cfgFile = "DiscountCFG1.txt";
        private string logFile = "LogTrans.txt";
        const string REGULAR = "Regular";
        const string GOLD = "Gold";
        const string ELITE = "Elite";
        const double MAX_DISCOUNT = 0.99;
        const int LISTBOX = 1;
        const int LOGFILE = 2;
        const int BOTH = 3;
        // ICA 7
        private double regularDiscount;
        private double goldDiscount;
        private double eliteDiscount;
        // ICA 9
        // sf  stands for settings form
        Form2 sf;

        //ICA 8
        //Property that doesn't allow setting to
        //negative or greater than 50%
        internal double RegularDiscount
        {
            get { return regularDiscount; }
            set
            {
                if (value >= 0 || value <= MAX_DISCOUNT)
                {
                    regularDiscount = value;
                }
            }
        }
        internal double GoldDiscount
        {
            get { return goldDiscount; }
            set
            {
                if (value >= 0 || value <= MAX_DISCOUNT)
                {
                    goldDiscount = value;
                }
            }
        }

        internal double EliteDiscount
        {
            get { return eliteDiscount; }
            set
            {
                if (value >= 0 || value <= MAX_DISCOUNT)
                {
                    eliteDiscount = value;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader srCfg;

            // ica 9
            sf = new Form2(this);


            rdoRegular.Checked = true;
            bool fileWasNotFound = true;
            do
            {
                try
                {
                    srCfg = File.OpenText(cfgFile);
                    fileWasNotFound = false;
                    try
                    {
                        RegularDiscount = double.Parse(srCfg.ReadLine());
                        GoldDiscount = double.Parse(srCfg.ReadLine());
                        EliteDiscount = double.Parse(srCfg.ReadLine());
                        srCfg.Close();
                    }
                    catch (FormatException ex)
                    {
                        // if something is bad in the file you can't depend on anything in the file
                        // set discounts to some default values
                        lstOut.ForeColor = Color.Red;
                        lstOut.Items.Add("File data  corrupted. Values were set to defaults");
                        lstOut.Items.Add(ex.Message);
                        regularDiscount = 0.2;
                        goldDiscount = 0.25;
                        eliteDiscount = 0.3;
                        srCfg.Close();
                    }

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message + " Please enter a new file name", "File Not Found");
                    // OFD.InitialDirectory = 
                    OFD.Filter = "Text Files|*.txt| All Files |*.*";
                    OFD.Title = "Open Configuration File";
                    OFD.ShowDialog();
                    cfgFile = OFD.FileName;
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
            double amtDiscount, subTotal;

            //read text boxes into variables 
            widgetName = txtWidgetName.Text.Trim();

            // pretend widget name is a name of a person
            // this code is not required for your project
            // but you may want to use it if you have a customer name

            string fName, lName;
            int posSpace;

            posSpace = widgetName.IndexOf(" ");
            if (posSpace != -1)
            {
                fName = widgetName.Substring(0, posSpace);
                lName = widgetName.Substring(posSpace).Trim();
                lstOut.Items.Add("First Name is " + fName);
                lstOut.Items.Add("Last Name is " + lName);
            }

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
                subTotal = widgetPrice * quantity;
                amtDiscount = subTotal * percentDiscount;
                totalCost = subTotal - amtDiscount;

                // Output
                output("*************** Beginning of Transaction " + DateTime.Now.ToString("G") + "  *****************", LOGFILE);
                output("The widget name is " + widgetName, BOTH);
                output("The Customer type is " + customerType, BOTH);
                output("The widget price is " + widgetPrice.ToString("C"), BOTH);
                output("The amount of widgets bought is " + quantity.ToString("N0"), BOTH);
                output("The subtotal  is " + subTotal.ToString("C"), BOTH);
                output("The percent discount is " + percentDiscount.ToString("p0"), BOTH);
                output("The amount of the  discount is " + amtDiscount.ToString("C"), BOTH);
                output("The total cost for this transaction is " + totalCost.ToString("C"), BOTH);
                output("The percent is is " + percentDiscount.ToString("p1"), BOTH);                
                btnClear.Focus();
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
        private void output(string msg, int outputType)
        {
            StreamWriter log;
            if (outputType == LISTBOX || outputType == BOTH)
            {
                lstOut.Items.Add(msg);
            }
            if (outputType == LOGFILE || outputType == BOTH)
            {
                log = File.AppendText(logFile);
                log.WriteLine(msg);
                log.Close();
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.txtRegular.Text = RegularDiscount.ToString();
            sf.txtGold.Text = GoldDiscount.ToString();
            sf.txtElite.Text = EliteDiscount.ToString();
            sf.ShowDialog();
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const int MAX_LINES = 2000;
            string[] logLines = new string[MAX_LINES];
            StreamReader sr = File.OpenText(logFile);
            int numLines = 0;
            while (!sr.EndOfStream)
            {
                logLines[numLines] = sr.ReadLine();
                numLines++;
            }
            int begin = -2;
            int end = 4;
            for (int i = 0; i < numLines; i++)
            {
                if (logLines[i] == "The Customer type is " + customerType)
                {
                    for (int j = i + begin; j <= i + end; j++)
                    {
                        lstOut.Items.Add(logLines[j]);
                    }
                }

            }

            double[] grades = new double[MAX_LINES];




            sr.Close();
        }

        private void numberArrayTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[50];
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = i;
            }
            lstOut.Items.Add(numbers.Average());


        }
    }
}
