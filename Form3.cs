using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {  

        public Form3(string clientName, string clientNumber, string clientEmail, string clientInvoice, string invoiceTotal, string[,] clothing, string[,] size, string[,] material, string[,] extra)
        {   
            InitializeComponent();
            // Hope msiza 62803050
            this.Text = clientName + " |" + " " + clientNumber;
            custDetails.Text = "Name: " + clientName;
            custNumber.Text = "Phone NUmber: "+ clientNumber;
            custEmailAddress.Text = "E-Mail: "+ clientEmail;
            invoice.Text = clientInvoice;
            invoiceCost.Text = "Amount: R" + invoiceTotal;

            addItemsToGrid(clothing);
            addItemsToGrid(size);
            addItemsToGrid(material);
            addItemsToGrid(extra);


        }

        private void addItemsToGrid(string[,] invoiceArray)
        {
            for (int i = 0; i < invoiceArray.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, 2);

                for (int j = 0; j < invoiceArray.GetLength(1); j++)
                {
                    row.Cells[j].Value = invoiceArray[i, j];
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
