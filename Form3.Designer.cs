namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            custDetails = new Label();
            custEmailAddress = new Label();
            custNumber = new Label();
            invoice = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            invoiceCost = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // custDetails
            // 
            custDetails.AutoSize = true;
            custDetails.Location = new Point(12, 19);
            custDetails.Name = "custDetails";
            custDetails.Size = new Size(38, 15);
            custDetails.TabIndex = 0;
            custDetails.Text = "label1";
            // 
            // custEmailAddress
            // 
            custEmailAddress.AutoSize = true;
            custEmailAddress.Location = new Point(12, 78);
            custEmailAddress.Name = "custEmailAddress";
            custEmailAddress.Size = new Size(38, 15);
            custEmailAddress.TabIndex = 1;
            custEmailAddress.Text = "label2";
            // 
            // custNumber
            // 
            custNumber.AutoSize = true;
            custNumber.Location = new Point(12, 49);
            custNumber.Name = "custNumber";
            custNumber.Size = new Size(38, 15);
            custNumber.TabIndex = 2;
            custNumber.Text = "label3";
            // 
            // invoice
            // 
            invoice.AutoSize = true;
            invoice.Location = new Point(508, 19);
            invoice.Name = "invoice";
            invoice.Size = new Size(38, 15);
            invoice.TabIndex = 3;
            invoice.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 78);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // invoiceCost
            // 
            invoiceCost.AutoSize = true;
            invoiceCost.Location = new Point(509, 44);
            invoiceCost.Name = "invoiceCost";
            invoiceCost.Size = new Size(38, 15);
            invoiceCost.TabIndex = 7;
            invoiceCost.Text = "label4";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 346);
            dataGridView1.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(dataGridView1);
            Controls.Add(invoiceCost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(invoice);
            Controls.Add(custNumber);
            Controls.Add(custEmailAddress);
            Controls.Add(custDetails);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label custDetails;
        private Label custEmailAddress;
        private Label custNumber;
        private Label invoice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label invoiceCost;
        private DataGridView dataGridView1;
    }
}