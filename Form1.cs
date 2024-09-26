using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class introForm : Form
    {
        public introForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hope Msiza 62803050 
            this.Text = myName.Text;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            //Hope MSiza 62803050

            Form2 form2 = new Form2(CustNameTxt.Text, custNum.Text);
            form2.Show();
        }

        private void sbmitBtn_Click(object sender, EventArgs e)
        {
            this.Text = CustNameTxt.Text + " | " + custNum.Text;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustNameTxt_Leave(object sender, EventArgs e)
        {
            // Hope msiza | 62803050

            string name = CustNameTxt.Text;
            string pattern = @"[A-Za-z]+(?: [A-Za-z]+)*$";

            bool isValid = Regex.IsMatch(name, pattern);

            if (isValid)
            {
                // do nothing
            }
            else
            {
                MessageBox.Show("The name you entered is incorrect please input correct name");
                CustNameTxt.Focus();
            };

            // change to uppercase letters
            CustNameTxt.Text = CustNameTxt.Text.ToUpper();
        }

        private void custEmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void custEmaillbl_Click(object sender, EventArgs e)
        {

        }

        private void custNum_Leave(object sender, EventArgs e)
        {   
            // hope msiza 62803050
            string custNumtxt = custNum.Text;
            if(custNumtxt.Length < 10 || custNumtxt.Length > 15)
            {
                MessageBox.Show("Telephone numbers should be between 10 and 15 characters");
                custNum.Focus();
            }

            string pattern = @"^[0-9]+$";
            bool isValid = Regex.IsMatch(custNum.Text, pattern);

            if (isValid)
            {
                // do nothing
            }
            else
            {
                MessageBox.Show("Enter only characters between 0 and 9");
                custNum.Focus();
            }
        }
    }
}
