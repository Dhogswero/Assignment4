namespace WinFormsApp1
{
    partial class Form2
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
            form2Header = new RichTextBox();
            custNametext = new TextBox();
            custNum = new TextBox();
            labelName = new Label();
            labelCustNum = new Label();
            typeBox = new GroupBox();
            altNone = new RadioButton();
            sweater = new RadioButton();
            skirt = new RadioButton();
            coat = new RadioButton();
            pants = new RadioButton();
            dress = new RadioButton();
            shirt = new RadioButton();
            materialBox = new GroupBox();
            dryNone = new RadioButton();
            leather = new RadioButton();
            wool = new RadioButton();
            Silk = new RadioButton();
            cotton = new RadioButton();
            jean = new RadioButton();
            nylon = new RadioButton();
            invNum = new TextBox();
            rand = new Label();
            cost = new TextBox();
            calcTotal = new Button();
            emailInv = new Button();
            invLbl = new Label();
            stdName = new Label();
            labelEmail = new Label();
            custEmail = new TextBox();
            sizeBox = new GroupBox();
            xlarge = new RadioButton();
            large = new RadioButton();
            medium = new RadioButton();
            small = new RadioButton();
            extraBox = new GroupBox();
            restore = new CheckBox();
            stain = new CheckBox();
            label1 = new Label();
            extraCheck = new CheckBox();
            calcType = new Button();
            typeTotal = new TextBox();
            materialTotal = new TextBox();
            calcMaterial = new Button();
            sizeTotal = new TextBox();
            calcSize = new Button();
            extTotal = new TextBox();
            calcExt = new Button();
            alter = new Label();
            label2 = new Label();
            formDeatils = new GroupBox();
            invButton = new Button();
            typeBox.SuspendLayout();
            materialBox.SuspendLayout();
            sizeBox.SuspendLayout();
            extraBox.SuspendLayout();
            formDeatils.SuspendLayout();
            SuspendLayout();
            // 
            // form2Header
            // 
            form2Header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form2Header.BackColor = SystemColors.Window;
            form2Header.BorderStyle = BorderStyle.None;
            form2Header.Enabled = false;
            form2Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            form2Header.ForeColor = SystemColors.Highlight;
            form2Header.Location = new Point(12, 4);
            form2Header.Name = "form2Header";
            form2Header.Size = new Size(678, 61);
            form2Header.TabIndex = 0;
            form2Header.Text = "Garment mending invoice form";
            // 
            // custNametext
            // 
            custNametext.BorderStyle = BorderStyle.FixedSingle;
            custNametext.Enabled = false;
            custNametext.Location = new Point(7, 53);
            custNametext.MaxLength = 40;
            custNametext.Name = "custNametext";
            custNametext.Size = new Size(203, 23);
            custNametext.TabIndex = 1;
            custNametext.TextChanged += custNametext_TextChanged;
            custNametext.Leave += custNametext_Leave;
            // 
            // custNum
            // 
            custNum.BorderStyle = BorderStyle.FixedSingle;
            custNum.Enabled = false;
            custNum.Location = new Point(264, 53);
            custNum.MaxLength = 40;
            custNum.Name = "custNum";
            custNum.Size = new Size(206, 23);
            custNum.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(5, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 17);
            labelName.TabIndex = 5;
            labelName.Text = "Name :";
            // 
            // labelCustNum
            // 
            labelCustNum.AutoSize = true;
            labelCustNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCustNum.Location = new Point(264, 33);
            labelCustNum.Name = "labelCustNum";
            labelCustNum.Size = new Size(63, 17);
            labelCustNum.TabIndex = 6;
            labelCustNum.Text = "Number:";
            // 
            // typeBox
            // 
            typeBox.BackColor = SystemColors.ControlLightLight;
            typeBox.Controls.Add(altNone);
            typeBox.Controls.Add(sweater);
            typeBox.Controls.Add(skirt);
            typeBox.Controls.Add(coat);
            typeBox.Controls.Add(pants);
            typeBox.Controls.Add(dress);
            typeBox.Controls.Add(shirt);
            typeBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeBox.Location = new Point(16, 276);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(269, 118);
            typeBox.TabIndex = 12;
            typeBox.TabStop = false;
            typeBox.Text = "Type of clothing";
            typeBox.Enter += groupBox3_Enter;
            // 
            // altNone
            // 
            altNone.AutoSize = true;
            altNone.Location = new Point(12, 87);
            altNone.Name = "altNone";
            altNone.Size = new Size(91, 19);
            altNone.TabIndex = 6;
            altNone.TabStop = true;
            altNone.Text = "No selection";
            altNone.UseVisualStyleBackColor = true;
            altNone.CheckedChanged += altNone_CheckedChanged;
            // 
            // sweater
            // 
            sweater.AutoSize = true;
            sweater.Location = new Point(93, 59);
            sweater.Name = "sweater";
            sweater.Size = new Size(67, 19);
            sweater.TabIndex = 5;
            sweater.TabStop = true;
            sweater.Text = "Sweater";
            sweater.UseVisualStyleBackColor = true;
            sweater.CheckedChanged += calcType_Click;
            // 
            // skirt
            // 
            skirt.AutoSize = true;
            skirt.Location = new Point(11, 59);
            skirt.Name = "skirt";
            skirt.Size = new Size(49, 19);
            skirt.TabIndex = 4;
            skirt.TabStop = true;
            skirt.Text = "Skirt";
            skirt.UseVisualStyleBackColor = true;
            skirt.CheckedChanged += calcType_Click;
            // 
            // coat
            // 
            coat.AutoSize = true;
            coat.Location = new Point(93, 27);
            coat.Name = "coat";
            coat.Size = new Size(49, 19);
            coat.TabIndex = 3;
            coat.TabStop = true;
            coat.Text = "Coat";
            coat.UseVisualStyleBackColor = true;
            coat.CheckedChanged += calcType_Click;
            // 
            // pants
            // 
            pants.AutoSize = true;
            pants.Location = new Point(185, 27);
            pants.Name = "pants";
            pants.Size = new Size(54, 19);
            pants.TabIndex = 2;
            pants.TabStop = true;
            pants.Text = "Pants";
            pants.UseVisualStyleBackColor = true;
            pants.CheckedChanged += calcType_Click;
            // 
            // dress
            // 
            dress.AutoSize = true;
            dress.Location = new Point(185, 59);
            dress.Name = "dress";
            dress.Size = new Size(54, 19);
            dress.TabIndex = 1;
            dress.TabStop = true;
            dress.Text = "Dress";
            dress.UseVisualStyleBackColor = true;
            dress.CheckedChanged += calcType_Click;
            // 
            // shirt
            // 
            shirt.AutoSize = true;
            shirt.Location = new Point(10, 27);
            shirt.Name = "shirt";
            shirt.Size = new Size(50, 19);
            shirt.TabIndex = 0;
            shirt.TabStop = true;
            shirt.Text = "Shirt";
            shirt.UseVisualStyleBackColor = true;
            shirt.CheckedChanged += calcType_Click;
            // 
            // materialBox
            // 
            materialBox.BackColor = SystemColors.ControlLightLight;
            materialBox.Controls.Add(dryNone);
            materialBox.Controls.Add(leather);
            materialBox.Controls.Add(wool);
            materialBox.Controls.Add(Silk);
            materialBox.Controls.Add(cotton);
            materialBox.Controls.Add(jean);
            materialBox.Controls.Add(nylon);
            materialBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            materialBox.Location = new Point(389, 276);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(269, 118);
            materialBox.TabIndex = 13;
            materialBox.TabStop = false;
            materialBox.Text = "Clothing material";
            // 
            // dryNone
            // 
            dryNone.AutoSize = true;
            dryNone.Location = new Point(13, 88);
            dryNone.Name = "dryNone";
            dryNone.Size = new Size(91, 19);
            dryNone.TabIndex = 6;
            dryNone.TabStop = true;
            dryNone.Text = "No selection";
            dryNone.UseVisualStyleBackColor = true;
            dryNone.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // leather
            // 
            leather.AutoSize = true;
            leather.Location = new Point(189, 57);
            leather.Name = "leather";
            leather.Size = new Size(64, 19);
            leather.TabIndex = 5;
            leather.TabStop = true;
            leather.Text = "Leather";
            leather.UseVisualStyleBackColor = true;
            leather.CheckedChanged += calcMaterial_Click;
            // 
            // wool
            // 
            wool.AutoSize = true;
            wool.Location = new Point(189, 27);
            wool.Name = "wool";
            wool.Size = new Size(54, 19);
            wool.TabIndex = 4;
            wool.TabStop = true;
            wool.Text = "Wool";
            wool.UseVisualStyleBackColor = true;
            wool.CheckedChanged += calcMaterial_Click;
            // 
            // Silk
            // 
            Silk.AutoSize = true;
            Silk.Location = new Point(118, 57);
            Silk.Name = "Silk";
            Silk.Size = new Size(44, 19);
            Silk.TabIndex = 3;
            Silk.TabStop = true;
            Silk.Text = "Silk";
            Silk.UseVisualStyleBackColor = true;
            Silk.CheckedChanged += calcMaterial_Click;
            // 
            // cotton
            // 
            cotton.AutoSize = true;
            cotton.Location = new Point(11, 57);
            cotton.Name = "cotton";
            cotton.Size = new Size(61, 19);
            cotton.TabIndex = 2;
            cotton.TabStop = true;
            cotton.Text = "Cotton";
            cotton.UseVisualStyleBackColor = true;
            cotton.CheckedChanged += calcMaterial_Click;
            // 
            // jean
            // 
            jean.AutoSize = true;
            jean.Location = new Point(118, 27);
            jean.Name = "jean";
            jean.Size = new Size(49, 19);
            jean.TabIndex = 1;
            jean.TabStop = true;
            jean.Text = "Jean";
            jean.UseVisualStyleBackColor = true;
            jean.CheckedChanged += calcMaterial_Click;
            // 
            // nylon
            // 
            nylon.AutoSize = true;
            nylon.Location = new Point(11, 27);
            nylon.Name = "nylon";
            nylon.Size = new Size(57, 19);
            nylon.TabIndex = 0;
            nylon.TabStop = true;
            nylon.Text = "Nylon";
            nylon.UseVisualStyleBackColor = true;
            nylon.CheckedChanged += calcMaterial_Click;
            // 
            // invNum
            // 
            invNum.BackColor = SystemColors.Info;
            invNum.BorderStyle = BorderStyle.FixedSingle;
            invNum.Enabled = false;
            invNum.Location = new Point(514, 53);
            invNum.MaxLength = 10;
            invNum.Name = "invNum";
            invNum.Size = new Size(154, 23);
            invNum.TabIndex = 14;
            invNum.TextChanged += invNum_TextChanged;
            // 
            // rand
            // 
            rand.AutoSize = true;
            rand.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rand.Location = new Point(260, 177);
            rand.Name = "rand";
            rand.Size = new Size(16, 17);
            rand.TabIndex = 15;
            rand.Text = "R";
            // 
            // cost
            // 
            cost.BackColor = SystemColors.Info;
            cost.BorderStyle = BorderStyle.FixedSingle;
            cost.Enabled = false;
            cost.Location = new Point(282, 172);
            cost.MaxLength = 5;
            cost.Name = "cost";
            cost.Size = new Size(154, 23);
            cost.TabIndex = 16;
            // 
            // calcTotal
            // 
            calcTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calcTotal.Location = new Point(457, 172);
            calcTotal.Name = "calcTotal";
            calcTotal.Size = new Size(100, 33);
            calcTotal.TabIndex = 17;
            calcTotal.Text = "Calculate total";
            calcTotal.UseVisualStyleBackColor = true;
            calcTotal.Click += calcTotal_Click;
            // 
            // emailInv
            // 
            emailInv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailInv.Location = new Point(580, 172);
            emailInv.Name = "emailInv";
            emailInv.Size = new Size(100, 33);
            emailInv.TabIndex = 18;
            emailInv.Text = "Email Invoice";
            emailInv.UseVisualStyleBackColor = true;
            // 
            // invLbl
            // 
            invLbl.AutoSize = true;
            invLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invLbl.Location = new Point(514, 33);
            invLbl.Name = "invLbl";
            invLbl.Size = new Size(56, 17);
            invLbl.TabIndex = 19;
            invLbl.Text = "Invoice:";
            // 
            // stdName
            // 
            stdName.AutoSize = true;
            stdName.Location = new Point(526, 9);
            stdName.Name = "stdName";
            stdName.Size = new Size(126, 15);
            stdName.TabIndex = 20;
            stdName.Text = "Hope Msiza | 62803050";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(4, 91);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(138, 17);
            labelEmail.TabIndex = 22;
            labelEmail.Text = "Enter E-Mail address:";
            // 
            // custEmail
            // 
            custEmail.BorderStyle = BorderStyle.FixedSingle;
            custEmail.Location = new Point(7, 111);
            custEmail.MaxLength = 40;
            custEmail.Name = "custEmail";
            custEmail.Size = new Size(170, 23);
            custEmail.TabIndex = 21;
            custEmail.TextChanged += custEmail_TextChanged;
            custEmail.Leave += custEmail_Leave;
            // 
            // sizeBox
            // 
            sizeBox.BackColor = SystemColors.ControlLightLight;
            sizeBox.Controls.Add(xlarge);
            sizeBox.Controls.Add(large);
            sizeBox.Controls.Add(medium);
            sizeBox.Controls.Add(small);
            sizeBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sizeBox.Location = new Point(17, 477);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(269, 108);
            sizeBox.TabIndex = 23;
            sizeBox.TabStop = false;
            sizeBox.Text = "Size Change";
            sizeBox.Enter += sizeBox_Enter;
            // 
            // xlarge
            // 
            xlarge.AutoSize = true;
            xlarge.Location = new Point(147, 67);
            xlarge.Name = "xlarge";
            xlarge.Size = new Size(112, 19);
            xlarge.TabIndex = 4;
            xlarge.TabStop = true;
            xlarge.Text = "X-Large to Large";
            xlarge.UseVisualStyleBackColor = true;
            xlarge.CheckedChanged += calcSize_Click;
            // 
            // large
            // 
            large.AutoSize = true;
            large.Location = new Point(9, 68);
            large.Name = "large";
            large.Size = new Size(116, 19);
            large.TabIndex = 3;
            large.TabStop = true;
            large.Text = "Large to Medium";
            large.UseVisualStyleBackColor = true;
            large.CheckedChanged += calcSize_Click;
            // 
            // medium
            // 
            medium.AutoSize = true;
            medium.Location = new Point(147, 27);
            medium.Name = "medium";
            medium.Size = new Size(117, 19);
            medium.TabIndex = 2;
            medium.TabStop = true;
            medium.Text = "Medium to Small";
            medium.UseVisualStyleBackColor = true;
            medium.CheckedChanged += calcSize_Click;
            // 
            // small
            // 
            small.AutoSize = true;
            small.Location = new Point(10, 27);
            small.Name = "small";
            small.Size = new Size(112, 19);
            small.TabIndex = 0;
            small.TabStop = true;
            small.Text = "Small to X-small";
            small.UseVisualStyleBackColor = true;
            small.CheckedChanged += calcSize_Click;
            // 
            // extraBox
            // 
            extraBox.BackColor = SystemColors.ControlLightLight;
            extraBox.Controls.Add(restore);
            extraBox.Controls.Add(stain);
            extraBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extraBox.Location = new Point(389, 477);
            extraBox.Name = "extraBox";
            extraBox.Size = new Size(269, 108);
            extraBox.TabIndex = 24;
            extraBox.TabStop = false;
            extraBox.Text = "Select addional service";
            // 
            // restore
            // 
            restore.AutoSize = true;
            restore.Location = new Point(11, 67);
            restore.Name = "restore";
            restore.Size = new Size(102, 19);
            restore.TabIndex = 2;
            restore.Text = "Restore colour";
            restore.UseVisualStyleBackColor = true;
            restore.CheckedChanged += calcExt_Click;
            // 
            // stain
            // 
            stain.AutoSize = true;
            stain.Location = new Point(11, 28);
            stain.Name = "stain";
            stain.Size = new Size(130, 19);
            stain.TabIndex = 0;
            stain.Text = "Deep Stain removal";
            stain.UseVisualStyleBackColor = true;
            stain.CheckedChanged += calcExt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 562);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 25;
            // 
            // extraCheck
            // 
            extraCheck.AutoSize = true;
            extraCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extraCheck.Location = new Point(392, 443);
            extraCheck.Name = "extraCheck";
            extraCheck.Size = new Size(201, 19);
            extraCheck.TabIndex = 26;
            extraCheck.Text = "Do you need additional service?";
            extraCheck.UseVisualStyleBackColor = true;
            extraCheck.CheckedChanged += extraCheck_CheckedChanged;
            // 
            // calcType
            // 
            calcType.Location = new Point(16, 410);
            calcType.Name = "calcType";
            calcType.Size = new Size(75, 23);
            calcType.TabIndex = 29;
            calcType.Text = "Calculate";
            calcType.UseVisualStyleBackColor = true;
            calcType.Click += calcType_Click;
            // 
            // typeTotal
            // 
            typeTotal.BackColor = SystemColors.GradientActiveCaption;
            typeTotal.Enabled = false;
            typeTotal.Location = new Point(109, 410);
            typeTotal.Name = "typeTotal";
            typeTotal.Size = new Size(100, 23);
            typeTotal.TabIndex = 30;
            // 
            // materialTotal
            // 
            materialTotal.BackColor = SystemColors.GradientActiveCaption;
            materialTotal.Enabled = false;
            materialTotal.Location = new Point(482, 409);
            materialTotal.Name = "materialTotal";
            materialTotal.Size = new Size(100, 23);
            materialTotal.TabIndex = 32;
            // 
            // calcMaterial
            // 
            calcMaterial.Location = new Point(392, 409);
            calcMaterial.Name = "calcMaterial";
            calcMaterial.Size = new Size(75, 23);
            calcMaterial.TabIndex = 31;
            calcMaterial.Text = "Calculate";
            calcMaterial.UseVisualStyleBackColor = true;
            calcMaterial.Click += calcMaterial_Click;
            // 
            // sizeTotal
            // 
            sizeTotal.BackColor = SystemColors.GradientActiveCaption;
            sizeTotal.Enabled = false;
            sizeTotal.Location = new Point(109, 600);
            sizeTotal.Name = "sizeTotal";
            sizeTotal.Size = new Size(100, 23);
            sizeTotal.TabIndex = 34;
            // 
            // calcSize
            // 
            calcSize.Location = new Point(19, 599);
            calcSize.Name = "calcSize";
            calcSize.Size = new Size(75, 23);
            calcSize.TabIndex = 33;
            calcSize.Text = "Calculate";
            calcSize.UseVisualStyleBackColor = true;
            calcSize.Click += calcSize_Click;
            // 
            // extTotal
            // 
            extTotal.BackColor = SystemColors.GradientActiveCaption;
            extTotal.Enabled = false;
            extTotal.Location = new Point(482, 609);
            extTotal.Name = "extTotal";
            extTotal.Size = new Size(100, 23);
            extTotal.TabIndex = 36;
            // 
            // calcExt
            // 
            calcExt.Location = new Point(392, 608);
            calcExt.Name = "calcExt";
            calcExt.Size = new Size(75, 23);
            calcExt.TabIndex = 35;
            calcExt.Text = "Calculate";
            calcExt.UseVisualStyleBackColor = true;
            calcExt.Click += calcExt_Click;
            // 
            // alter
            // 
            alter.AutoSize = true;
            alter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alter.Location = new Point(17, 244);
            alter.Name = "alter";
            alter.Size = new Size(155, 20);
            alter.TabIndex = 37;
            alter.Text = "Alterations from R100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 244);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 38;
            label2.Text = "Dry Clean from R80";
            // 
            // formDeatils
            // 
            formDeatils.BackColor = SystemColors.GradientActiveCaption;
            formDeatils.Controls.Add(custNametext);
            formDeatils.Controls.Add(custEmail);
            formDeatils.Controls.Add(labelEmail);
            formDeatils.Controls.Add(labelName);
            formDeatils.Controls.Add(custNum);
            formDeatils.Controls.Add(labelCustNum);
            formDeatils.Controls.Add(invNum);
            formDeatils.Controls.Add(invLbl);
            formDeatils.Location = new Point(12, 71);
            formDeatils.Name = "formDeatils";
            formDeatils.Size = new Size(678, 158);
            formDeatils.TabIndex = 39;
            formDeatils.TabStop = false;
            formDeatils.Text = "Invoice Details";
            // 
            // invButton
            // 
            invButton.Location = new Point(392, 669);
            invButton.Name = "invButton";
            invButton.Size = new Size(147, 43);
            invButton.TabIndex = 40;
            invButton.Text = "Continue to invoice >";
            invButton.UseVisualStyleBackColor = true;
            invButton.Click += invButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 736);
            Controls.Add(invButton);
            Controls.Add(label2);
            Controls.Add(alter);
            Controls.Add(extTotal);
            Controls.Add(calcExt);
            Controls.Add(sizeTotal);
            Controls.Add(calcSize);
            Controls.Add(materialTotal);
            Controls.Add(calcMaterial);
            Controls.Add(typeTotal);
            Controls.Add(calcType);
            Controls.Add(extraCheck);
            Controls.Add(label1);
            Controls.Add(extraBox);
            Controls.Add(sizeBox);
            Controls.Add(materialBox);
            Controls.Add(stdName);
            Controls.Add(emailInv);
            Controls.Add(calcTotal);
            Controls.Add(cost);
            Controls.Add(rand);
            Controls.Add(typeBox);
            Controls.Add(form2Header);
            Controls.Add(formDeatils);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            typeBox.ResumeLayout(false);
            typeBox.PerformLayout();
            materialBox.ResumeLayout(false);
            materialBox.PerformLayout();
            sizeBox.ResumeLayout(false);
            sizeBox.PerformLayout();
            extraBox.ResumeLayout(false);
            extraBox.PerformLayout();
            formDeatils.ResumeLayout(false);
            formDeatils.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox form2Header;
        private TextBox custNametext;
        private TextBox custNum;
        private Label labelName;
        private Label labelCustNum;
        private GroupBox typeBox;
        private GroupBox materialBox;
        private TextBox invNum;
        private Label rand;
        private TextBox cost;
        private Button calcTotal;
        private Button emailInv;
        private Label invLbl;
        private Label stdName;
        private Label labelEmail;
        private TextBox custEmail;
        private RadioButton skirt;
        private RadioButton coat;
        private RadioButton pants;
        private RadioButton dress;
        private RadioButton shirt;
        private RadioButton Silk;
        private RadioButton cotton;
        private RadioButton jean;
        private RadioButton nylon;
        private GroupBox sizeBox;
        private RadioButton large;
        private RadioButton medium;
        private RadioButton small;
        private RadioButton xlarge;
        private GroupBox extraBox;
        private CheckBox restore;
        private Label label1;
        private CheckBox extraCheck;
        private RadioButton sweater;
        private RadioButton leather;
        private RadioButton wool;
        private RadioButton altNone;
        private RadioButton dryNone;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private CheckBox stain;
        private Button calcType;
        private TextBox typeTotal;
        private TextBox materialTotal;
        private Button calcMaterial;
        private TextBox sizeTotal;
        private Button calcSize;
        private TextBox extTotal;
        private Button calcExt;
        private Label alter;
        private Label label2;
        private GroupBox formDeatils;
        private Button invButton;
    }
}