namespace WinFormsApp1
{
    partial class introForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introForm));
            form1Header = new RichTextBox();
            description = new RichTextBox();
            pictureBox1 = new PictureBox();
            myName = new TextBox();
            btnForm2 = new Button();
            CustNameTxt = new TextBox();
            custNum = new TextBox();
            custNameLbl = new Label();
            custNumlbl = new Label();
            sbmitBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // form1Header
            // 
            form1Header.BorderStyle = BorderStyle.None;
            form1Header.Enabled = false;
            form1Header.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            form1Header.ForeColor = SystemColors.HotTrack;
            form1Header.Location = new Point(12, 26);
            form1Header.Name = "form1Header";
            form1Header.Size = new Size(268, 43);
            form1Header.TabIndex = 0;
            form1Header.Text = "The Garment Shop";
            // 
            // description
            // 
            description.BorderStyle = BorderStyle.None;
            description.Enabled = false;
            description.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            description.ForeColor = SystemColors.HotTrack;
            description.Location = new Point(12, 75);
            description.Name = "description";
            description.Size = new Size(277, 96);
            description.TabIndex = 1;
            description.Text = "The Garment Shop mends all type of garments. Whether it is damaged, heavely stained and discoloured we can help you fix it";
            description.TextChanged += description_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 179);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // myName
            // 
            myName.BorderStyle = BorderStyle.None;
            myName.Enabled = false;
            myName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            myName.ForeColor = SystemColors.HotTrack;
            myName.Location = new Point(368, 26);
            myName.Name = "myName";
            myName.Size = new Size(198, 18);
            myName.TabIndex = 3;
            myName.Text = "Hope Msiza | 62803050";
            // 
            // btnForm2
            // 
            btnForm2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnForm2.ForeColor = SystemColors.Highlight;
            btnForm2.Location = new Point(368, 297);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(115, 30);
            btnForm2.TabIndex = 5;
            btnForm2.Text = "Continue";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // CustNameTxt
            // 
            CustNameTxt.Location = new Point(12, 206);
            CustNameTxt.Name = "CustNameTxt";
            CustNameTxt.Size = new Size(218, 23);
            CustNameTxt.TabIndex = 6;
            CustNameTxt.Leave += CustNameTxt_Leave;
            // 
            // custNum
            // 
            custNum.Location = new Point(12, 264);
            custNum.Name = "custNum";
            custNum.Size = new Size(218, 23);
            custNum.TabIndex = 7;
            custNum.TextChanged += custEmailTxt_TextChanged;
            custNum.Leave += custNum_Leave;
            // 
            // custNameLbl
            // 
            custNameLbl.AutoSize = true;
            custNameLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            custNameLbl.ForeColor = SystemColors.Highlight;
            custNameLbl.Location = new Point(12, 184);
            custNameLbl.Name = "custNameLbl";
            custNameLbl.Size = new Size(144, 19);
            custNameLbl.TabIndex = 8;
            custNameLbl.Text = "Enter your fullname:";
            // 
            // custNumlbl
            // 
            custNumlbl.AutoSize = true;
            custNumlbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            custNumlbl.ForeColor = SystemColors.Highlight;
            custNumlbl.Location = new Point(12, 242);
            custNumlbl.Name = "custNumlbl";
            custNumlbl.Size = new Size(168, 19);
            custNumlbl.TabIndex = 9;
            custNumlbl.Text = "Enter your Cell number:";
            custNumlbl.Click += custEmaillbl_Click;
            // 
            // sbmitBtn
            // 
            sbmitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbmitBtn.ForeColor = SystemColors.Highlight;
            sbmitBtn.Location = new Point(12, 303);
            sbmitBtn.Name = "sbmitBtn";
            sbmitBtn.Size = new Size(103, 24);
            sbmitBtn.TabIndex = 10;
            sbmitBtn.Text = "Submit";
            sbmitBtn.UseVisualStyleBackColor = true;
            sbmitBtn.Click += sbmitBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // introForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 374);
            Controls.Add(sbmitBtn);
            Controls.Add(custNumlbl);
            Controls.Add(custNameLbl);
            Controls.Add(custNum);
            Controls.Add(CustNameTxt);
            Controls.Add(btnForm2);
            Controls.Add(myName);
            Controls.Add(pictureBox1);
            Controls.Add(description);
            Controls.Add(form1Header);
            Name = "introForm";
            Text = "Hope Msiza | 62803050";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox form1Header;
        private RichTextBox description;
        private PictureBox pictureBox1;
        private TextBox myName;
        private Button btnForm2;
        private TextBox CustNameTxt;
        private TextBox custNum;
        private Label custNameLbl;
        private Label custNumlbl;
        private Button sbmitBtn;
        private ContextMenuStrip contextMenuStrip1;
    }
}
