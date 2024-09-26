using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string custName, string custEmail)
        {
            InitializeComponent();

            // Hope Msiza | 62803050
            this.Text = custName + ' ' + '|' + ' ' + custEmail;
            custNametext.Text = custName;
            custNum.Text = custEmail;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Hope MSiza | 62803050
            Random random = new Random();
            int invRandom = random.Next(100, 1000);

            string randomNum = String.Concat("INV-", invRandom.ToString());
            invNum.Text = randomNum;

            pants.Checked = true;
            small.Checked = true;
            extraCheck.Checked = true;
            stain.Checked = true;
            nylon.Checked = true;
        }

        private void specification_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stainRemoval_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void serviceGroup_Enter(object sender, EventArgs e)
        {

        }

        private void custNametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void custNametext_Leave(object sender, EventArgs e)
        {

        }

        private void custEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void custEmail_Leave(object sender, EventArgs e)
        {
            // hope msiza || 62803050

            string email = custEmail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            bool isValid = Regex.IsMatch(email, pattern);

            if (isValid)
            {
                // do nothing
            }
            else
            {
                MessageBox.Show("The E-Mail you entered is incorrect please input correct name");
                custEmail.Focus();
            };

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void invNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcType_Click(object sender, EventArgs e)
        {
            //Hope msiza | 62803050

            double total = 100; // starting price for alterations

            if (coat.Checked || dress.Checked)
            {
                total += 50; // additional price for coats and dresses
            }

            typeTotal.Text = total.ToString();
        }

        private void calcMaterial_Click(object sender, EventArgs e)
        {
            //Hope msiza | 62803050

            double total = 80; // starting price

            if (nylon.Checked || Silk.Checked || leather.Checked)
            {
                total += 40;
            }

            materialTotal.Text = total.ToString();
        }

        private void calcTotal_Click(object sender, EventArgs e)
        {
            // Hope msiza | 62803050

            double total = 0;

            double type4Total = double.Parse(typeTotal.Text);
            double size4Total = double.Parse(sizeTotal.Text);
            double material4Total = double.Parse(materialTotal.Text);
            double ext4Total = double.Parse(extTotal.Text);

            total = type4Total + size4Total + material4Total + ext4Total;

            cost.Text = total.ToString();

        }

        private void calcSize_Click(object sender, EventArgs e)
        {
            //Hope msiza | 62803050

            double total = 0;
            if (small.Checked) { total += 30; }
            if (medium.Checked) { total += 50; }
            if (large.Checked) { total += 70; }
            if (xlarge.Checked) { total += 100; }

            sizeTotal.Text = total.ToString();
        }

        private void calcExt_Click(object sender, EventArgs e)
        {
            // Hope msiza | 62803050

            int total = 0;

            if (stain.Checked) { total += 60; }
            if (restore.Checked) { total += 80; }

            extTotal.Text = total.ToString();
        }

        private void extraCheck_CheckedChanged(object sender, EventArgs e)
        {
            // hope msiza | 62803050

            if (extraCheck.Checked)
            {
                extraBox.Enabled = true;
            }
            else
            {
                extraBox.Enabled = false;
                restore.Checked = false;
                stain.Checked = false;
            }

        }

        private void invButton_Click(object sender, EventArgs e)
        {
            // Hope msiza 62803050

            // 2D array
            string[,] clothingArray = getInfoClothing();
            string[,] sizeArray = getInfoSize();
            string[,] materialArray = getInfoMaterial();
            string[,] extraArray = getInfoExtra();

            Form3 form3 = new Form3(custNametext.Text, custNum.Text, custEmail.Text, invNum.Text, cost.Text, clothingArray, sizeArray, materialArray, extraArray);
            form3.Show();

        }

        private string[,] getInfoClothing()
        {
            // Hope msiza 62803050
            string[,] invoiceArray = new string[1, 2];
            int row = 0;

            if (shirt.Checked)
            {
                invoiceArray[row, 0] = shirt.Text;
                invoiceArray[row, 1] = typeTotal.Text;
            }
            else if (dress.Checked)
            {
                invoiceArray[row, 0] = dress.Text;
                invoiceArray[row, 1] = typeTotal.Text;
            }
            else if (coat.Checked)
            {
                invoiceArray[row, 0] = coat.Text;
                invoiceArray[row, 1] = typeTotal.Text;
            }
            else if (pants.Checked)
            {
                invoiceArray[row, 0] = pants.Text;
                invoiceArray[row, 1] = typeTotal.Text;
            }
            else if (skirt.Checked)
            {
                invoiceArray[row, 0] = skirt.Text;
                invoiceArray[row, 1] = typeTotal.Text;
            }
            else if (sweater.Checked)
            {
                invoiceArray[row, 0] = sweater.Text;
                invoiceArray[row, 1] = typeTotal.Text;
            }

            return invoiceArray;
        }

        private string[,] getInfoSize()
        {
            // Hope msiza 62803050
            string[,] invoiceArray = new string[1, 2];
            int row = 0;

            if (small.Checked)
            {
                invoiceArray[row, 0] = small.Text;
                invoiceArray[row, 1] = sizeTotal.Text;
            }
            else if (medium.Checked)
            {
                invoiceArray[row, 0] = medium.Text;
                invoiceArray[row, 1] = sizeTotal.Text;
            }
            else if (large.Checked)
            {
                invoiceArray[row, 0] = large.Text;
                invoiceArray[row, 1] = sizeTotal.Text;
            }
            else if (xlarge.Checked)
            {
                invoiceArray[row, 0] = xlarge.Text;
                invoiceArray[row, 1] = sizeTotal.Text;
            }

            return invoiceArray;
        }

        private string[,] getInfoMaterial()
        {
            // Hope msiza 62803050
            string[,] invoiceArray = new string[1, 2];
            int row = 0;

            if (nylon.Checked)
            {
                invoiceArray[row, 0] = nylon.Text;
                invoiceArray[row, 1] = materialTotal.Text;
            }
            else if (cotton.Checked)
            {
                invoiceArray[row, 0] = cotton.Text;
                invoiceArray[row, 1] = materialTotal.Text;
            }
            else if (wool.Checked)
            {
                invoiceArray[row, 0] = wool.Text;
                invoiceArray[row, 1] = materialTotal.Text;
            }
            else if (Silk.Checked)
            {
                invoiceArray[row, 0] = Silk.Text;
                invoiceArray[row, 1] = materialTotal.Text;
            }
            else if (jean.Checked)
            {
                invoiceArray[row, 0] = jean.Text;
                invoiceArray[row, 1] = materialTotal.Text;
            }
            else if (leather.Checked)
            {
                invoiceArray[row, 0] = leather.Text;
                invoiceArray[row, 1] = materialTotal.Text;
            }

            return invoiceArray;
        }

        private string[,] getInfoExtra()
        {
            // Hope msiza 63803050
            string[,] invoiceArray = new string[4, 2]; 
            int row = 0;

            if (stain.Checked)
            {
                invoiceArray[row, 0] = stain.Text;
                invoiceArray[row, 1] = extTotal.Text;
                row++;
            }
            if (restore.Checked)
            {
                invoiceArray[row, 0] = restore.Text;
                invoiceArray[row, 1] = extTotal.Text;
                row++;
            }

            return invoiceArray;
        }

        private void sizeBox_Enter(object sender, EventArgs e)
        {

        }

        private void altNone_CheckedChanged(object sender, EventArgs e)
        {
            if (altNone.Checked)
            {
                typeTotal.Text = "0";
                sizeTotal.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (dryNone.Checked)
            {
                materialTotal.Text = "0";
            }
        }
    }
}
