namespace Casasoft.QRcode
{
    partial class GeneratorForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.btnAbout = new System.Windows.Forms.Button();
            this.tcResult = new System.Windows.Forms.TabControl();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.lblECC = new System.Windows.Forms.Label();
            this.cmbECC = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.NumericUpDown();
            this.chkBorder = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.txtBackColor = new System.Windows.Forms.TextBox();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.lblForeColor = new System.Windows.Forms.Label();
            this.txtForeColor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabData = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tcInput = new System.Windows.Forms.TabControl();
            this.tabUrl = new System.Windows.Forms.TabPage();
            this.lblURL_url = new System.Windows.Forms.Label();
            this.txtURL_url = new System.Windows.Forms.TextBox();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.lblContact_Lastname = new System.Windows.Forms.Label();
            this.lblContact_Firstname = new System.Windows.Forms.Label();
            this.txtContact_Lastname = new System.Windows.Forms.TextBox();
            this.txtContact_Firstname = new System.Windows.Forms.TextBox();
            this.tcContact = new System.Windows.Forms.TabControl();
            this.tabContact_Phones = new System.Windows.Forms.TabPage();
            this.lblContact_WorkPhone = new System.Windows.Forms.Label();
            this.txtContact_WorkPhone = new System.Windows.Forms.TextBox();
            this.lblContact_MobilePhone = new System.Windows.Forms.Label();
            this.txtContact_MobilePhone = new System.Windows.Forms.TextBox();
            this.lblContact_Phone = new System.Windows.Forms.Label();
            this.txtContact_Phone = new System.Windows.Forms.TextBox();
            this.tabContact_Address = new System.Windows.Forms.TabPage();
            this.lblContact_Zip = new System.Windows.Forms.Label();
            this.txtContact_Zip = new System.Windows.Forms.TextBox();
            this.lblContact_State = new System.Windows.Forms.Label();
            this.txtContact_State = new System.Windows.Forms.TextBox();
            this.lblContact_Number = new System.Windows.Forms.Label();
            this.txtContact_Number = new System.Windows.Forms.TextBox();
            this.lblContact_City = new System.Windows.Forms.Label();
            this.txtContact_City = new System.Windows.Forms.TextBox();
            this.lblContact_Address = new System.Windows.Forms.Label();
            this.txtContact_Address = new System.Windows.Forms.TextBox();
            this.tabContact_Mail = new System.Windows.Forms.TabPage();
            this.lblContact_Web = new System.Windows.Forms.Label();
            this.txtContact_Web = new System.Windows.Forms.TextBox();
            this.lblContact_Mail = new System.Windows.Forms.Label();
            this.txtContact_Mail = new System.Windows.Forms.TextBox();
            this.tabContact_Other = new System.Windows.Forms.TabPage();
            this.lblContact_Note = new System.Windows.Forms.Label();
            this.txtContact_Note = new System.Windows.Forms.TextBox();
            this.lblContact_BirthDate = new System.Windows.Forms.Label();
            this.dtpContact_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.tabContact_Options = new System.Windows.Forms.TabPage();
            this.tabEvent = new System.Windows.Forms.TabPage();
            this.dtpEvent_EndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEvent_StartTime = new System.Windows.Forms.DateTimePicker();
            this.chkEvent_AllDay = new System.Windows.Forms.CheckBox();
            this.lblEvent_Location = new System.Windows.Forms.Label();
            this.txtEvent_Location = new System.Windows.Forms.TextBox();
            this.lblEvent_Description = new System.Windows.Forms.Label();
            this.txtEvent_Description = new System.Windows.Forms.TextBox();
            this.lblEvent_Name = new System.Windows.Forms.Label();
            this.txtEvent_Name = new System.Windows.Forms.TextBox();
            this.lblEvent_End = new System.Windows.Forms.Label();
            this.dtpEvent_End = new System.Windows.Forms.DateTimePicker();
            this.lblEvent_Start = new System.Windows.Forms.Label();
            this.dtpEvent_Start = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnContact_BirthDateClear = new System.Windows.Forms.Button();
            this.lblContact_Nick = new System.Windows.Forms.Label();
            this.txtContact_Nick = new System.Windows.Forms.TextBox();
            this.tcResult.SuspendLayout();
            this.tabImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabData.SuspendLayout();
            this.tcInput.SuspendLayout();
            this.tabUrl.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.tcContact.SuspendLayout();
            this.tabContact_Phones.SuspendLayout();
            this.tabContact_Address.SuspendLayout();
            this.tabContact_Mail.SuspendLayout();
            this.tabContact_Other.SuspendLayout();
            this.tabEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(12, 504);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(111, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tcResult
            // 
            this.tcResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcResult.Controls.Add(this.tabImage);
            this.tcResult.Controls.Add(this.tabData);
            this.tcResult.Location = new System.Drawing.Point(13, 13);
            this.tcResult.Name = "tcResult";
            this.tcResult.SelectedIndex = 0;
            this.tcResult.Size = new System.Drawing.Size(522, 253);
            this.tcResult.TabIndex = 1;
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.lblECC);
            this.tabImage.Controls.Add(this.cmbECC);
            this.tabImage.Controls.Add(this.txtSize);
            this.tabImage.Controls.Add(this.chkBorder);
            this.tabImage.Controls.Add(this.lblSize);
            this.tabImage.Controls.Add(this.btnBackColor);
            this.tabImage.Controls.Add(this.lblBackColor);
            this.tabImage.Controls.Add(this.txtBackColor);
            this.tabImage.Controls.Add(this.btnForeColor);
            this.tabImage.Controls.Add(this.lblForeColor);
            this.tabImage.Controls.Add(this.txtForeColor);
            this.tabImage.Controls.Add(this.pictureBox1);
            this.tabImage.Location = new System.Drawing.Point(4, 22);
            this.tabImage.Name = "tabImage";
            this.tabImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabImage.Size = new System.Drawing.Size(514, 227);
            this.tabImage.TabIndex = 0;
            this.tabImage.Text = "Image";
            this.tabImage.UseVisualStyleBackColor = true;
            // 
            // lblECC
            // 
            this.lblECC.AutoSize = true;
            this.lblECC.Location = new System.Drawing.Point(6, 162);
            this.lblECC.Name = "lblECC";
            this.lblECC.Size = new System.Drawing.Size(104, 13);
            this.lblECC.TabIndex = 12;
            this.lblECC.Text = "Error correction level";
            // 
            // cmbECC
            // 
            this.cmbECC.FormattingEnabled = true;
            this.cmbECC.Items.AddRange(new object[] {
            "L  (7%)",
            "M  (15%)",
            "Q  (25%)",
            "H  (30%)"});
            this.cmbECC.Location = new System.Drawing.Point(9, 178);
            this.cmbECC.Name = "cmbECC";
            this.cmbECC.Size = new System.Drawing.Size(110, 21);
            this.cmbECC.TabIndex = 11;
            this.cmbECC.SelectedIndexChanged += new System.EventHandler(this.cmbECC_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(9, 128);
            this.txtSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(110, 20);
            this.txtSize.TabIndex = 10;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtSize.ValueChanged += new System.EventHandler(this.txtSize_ValueChanged);
            // 
            // chkBorder
            // 
            this.chkBorder.AutoSize = true;
            this.chkBorder.Checked = true;
            this.chkBorder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBorder.Location = new System.Drawing.Point(127, 129);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.Size = new System.Drawing.Size(109, 17);
            this.chkBorder.TabIndex = 9;
            this.chkBorder.Text = "Add empty border";
            this.chkBorder.UseVisualStyleBackColor = true;
            this.chkBorder.CheckedChanged += new System.EventHandler(this.chkBorder_CheckedChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 112);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(86, 13);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Element size (px)";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(125, 75);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 20);
            this.btnBackColor.TabIndex = 6;
            this.btnBackColor.Text = "Select";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(6, 59);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(91, 13);
            this.lblBackColor.TabIndex = 5;
            this.lblBackColor.Text = "Background color";
            // 
            // txtBackColor
            // 
            this.txtBackColor.BackColor = System.Drawing.Color.White;
            this.txtBackColor.Location = new System.Drawing.Point(9, 75);
            this.txtBackColor.Name = "txtBackColor";
            this.txtBackColor.ReadOnly = true;
            this.txtBackColor.Size = new System.Drawing.Size(110, 20);
            this.txtBackColor.TabIndex = 4;
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(125, 27);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(75, 20);
            this.btnForeColor.TabIndex = 3;
            this.btnForeColor.Text = "Select";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // lblForeColor
            // 
            this.lblForeColor.AutoSize = true;
            this.lblForeColor.Location = new System.Drawing.Point(6, 11);
            this.lblForeColor.Name = "lblForeColor";
            this.lblForeColor.Size = new System.Drawing.Size(87, 13);
            this.lblForeColor.TabIndex = 2;
            this.lblForeColor.Text = "Foreground color";
            // 
            // txtForeColor
            // 
            this.txtForeColor.BackColor = System.Drawing.Color.Black;
            this.txtForeColor.Location = new System.Drawing.Point(9, 27);
            this.txtForeColor.Name = "txtForeColor";
            this.txtForeColor.ReadOnly = true;
            this.txtForeColor.Size = new System.Drawing.Size(110, 20);
            this.txtForeColor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(242, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.textBox);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(514, 227);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Text";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(508, 221);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tcInput
            // 
            this.tcInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcInput.Controls.Add(this.tabUrl);
            this.tcInput.Controls.Add(this.tabContact);
            this.tcInput.Controls.Add(this.tabEvent);
            this.tcInput.Location = new System.Drawing.Point(13, 272);
            this.tcInput.Name = "tcInput";
            this.tcInput.SelectedIndex = 0;
            this.tcInput.Size = new System.Drawing.Size(522, 226);
            this.tcInput.TabIndex = 2;
            // 
            // tabUrl
            // 
            this.tabUrl.Controls.Add(this.lblURL_url);
            this.tabUrl.Controls.Add(this.txtURL_url);
            this.tabUrl.Location = new System.Drawing.Point(4, 22);
            this.tabUrl.Name = "tabUrl";
            this.tabUrl.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrl.Size = new System.Drawing.Size(514, 200);
            this.tabUrl.TabIndex = 0;
            this.tabUrl.Text = "URL";
            this.tabUrl.UseVisualStyleBackColor = true;
            // 
            // lblURL_url
            // 
            this.lblURL_url.AutoSize = true;
            this.lblURL_url.Location = new System.Drawing.Point(6, 11);
            this.lblURL_url.Name = "lblURL_url";
            this.lblURL_url.Size = new System.Drawing.Size(29, 13);
            this.lblURL_url.TabIndex = 1;
            this.lblURL_url.Text = "URL";
            // 
            // txtURL_url
            // 
            this.txtURL_url.AllowDrop = true;
            this.txtURL_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL_url.Location = new System.Drawing.Point(6, 27);
            this.txtURL_url.Name = "txtURL_url";
            this.txtURL_url.Size = new System.Drawing.Size(502, 20);
            this.txtURL_url.TabIndex = 0;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.lblContact_Lastname);
            this.tabContact.Controls.Add(this.lblContact_Firstname);
            this.tabContact.Controls.Add(this.txtContact_Lastname);
            this.tabContact.Controls.Add(this.txtContact_Firstname);
            this.tabContact.Controls.Add(this.tcContact);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(514, 200);
            this.tabContact.TabIndex = 1;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // lblContact_Lastname
            // 
            this.lblContact_Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact_Lastname.AutoSize = true;
            this.lblContact_Lastname.Location = new System.Drawing.Point(261, 7);
            this.lblContact_Lastname.Name = "lblContact_Lastname";
            this.lblContact_Lastname.Size = new System.Drawing.Size(53, 13);
            this.lblContact_Lastname.TabIndex = 14;
            this.lblContact_Lastname.Text = "Lastname";
            // 
            // lblContact_Firstname
            // 
            this.lblContact_Firstname.AutoSize = true;
            this.lblContact_Firstname.Location = new System.Drawing.Point(6, 7);
            this.lblContact_Firstname.Name = "lblContact_Firstname";
            this.lblContact_Firstname.Size = new System.Drawing.Size(52, 13);
            this.lblContact_Firstname.TabIndex = 13;
            this.lblContact_Firstname.Text = "Firstname";
            // 
            // txtContact_Lastname
            // 
            this.txtContact_Lastname.AllowDrop = true;
            this.txtContact_Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Lastname.Location = new System.Drawing.Point(261, 23);
            this.txtContact_Lastname.Name = "txtContact_Lastname";
            this.txtContact_Lastname.Size = new System.Drawing.Size(246, 20);
            this.txtContact_Lastname.TabIndex = 2;
            // 
            // txtContact_Firstname
            // 
            this.txtContact_Firstname.AllowDrop = true;
            this.txtContact_Firstname.Location = new System.Drawing.Point(6, 23);
            this.txtContact_Firstname.Name = "txtContact_Firstname";
            this.txtContact_Firstname.Size = new System.Drawing.Size(249, 20);
            this.txtContact_Firstname.TabIndex = 1;
            // 
            // tcContact
            // 
            this.tcContact.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcContact.Controls.Add(this.tabContact_Phones);
            this.tcContact.Controls.Add(this.tabContact_Address);
            this.tcContact.Controls.Add(this.tabContact_Mail);
            this.tcContact.Controls.Add(this.tabContact_Other);
            this.tcContact.Controls.Add(this.tabContact_Options);
            this.tcContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcContact.Location = new System.Drawing.Point(3, 49);
            this.tcContact.Name = "tcContact";
            this.tcContact.SelectedIndex = 0;
            this.tcContact.Size = new System.Drawing.Size(508, 148);
            this.tcContact.TabIndex = 0;
            // 
            // tabContact_Phones
            // 
            this.tabContact_Phones.BackColor = System.Drawing.Color.White;
            this.tabContact_Phones.Controls.Add(this.lblContact_WorkPhone);
            this.tabContact_Phones.Controls.Add(this.txtContact_WorkPhone);
            this.tabContact_Phones.Controls.Add(this.lblContact_MobilePhone);
            this.tabContact_Phones.Controls.Add(this.txtContact_MobilePhone);
            this.tabContact_Phones.Controls.Add(this.lblContact_Phone);
            this.tabContact_Phones.Controls.Add(this.txtContact_Phone);
            this.tabContact_Phones.Location = new System.Drawing.Point(4, 4);
            this.tabContact_Phones.Name = "tabContact_Phones";
            this.tabContact_Phones.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact_Phones.Size = new System.Drawing.Size(500, 122);
            this.tabContact_Phones.TabIndex = 0;
            this.tabContact_Phones.Text = "Phones";
            // 
            // lblContact_WorkPhone
            // 
            this.lblContact_WorkPhone.AutoSize = true;
            this.lblContact_WorkPhone.Location = new System.Drawing.Point(6, 81);
            this.lblContact_WorkPhone.Name = "lblContact_WorkPhone";
            this.lblContact_WorkPhone.Size = new System.Drawing.Size(66, 13);
            this.lblContact_WorkPhone.TabIndex = 19;
            this.lblContact_WorkPhone.Text = "Work phone";
            // 
            // txtContact_WorkPhone
            // 
            this.txtContact_WorkPhone.AllowDrop = true;
            this.txtContact_WorkPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_WorkPhone.Location = new System.Drawing.Point(6, 97);
            this.txtContact_WorkPhone.Name = "txtContact_WorkPhone";
            this.txtContact_WorkPhone.Size = new System.Drawing.Size(488, 20);
            this.txtContact_WorkPhone.TabIndex = 18;
            // 
            // lblContact_MobilePhone
            // 
            this.lblContact_MobilePhone.AutoSize = true;
            this.lblContact_MobilePhone.Location = new System.Drawing.Point(6, 42);
            this.lblContact_MobilePhone.Name = "lblContact_MobilePhone";
            this.lblContact_MobilePhone.Size = new System.Drawing.Size(71, 13);
            this.lblContact_MobilePhone.TabIndex = 17;
            this.lblContact_MobilePhone.Text = "Mobile phone";
            // 
            // txtContact_MobilePhone
            // 
            this.txtContact_MobilePhone.AllowDrop = true;
            this.txtContact_MobilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_MobilePhone.Location = new System.Drawing.Point(6, 58);
            this.txtContact_MobilePhone.Name = "txtContact_MobilePhone";
            this.txtContact_MobilePhone.Size = new System.Drawing.Size(488, 20);
            this.txtContact_MobilePhone.TabIndex = 16;
            // 
            // lblContact_Phone
            // 
            this.lblContact_Phone.AutoSize = true;
            this.lblContact_Phone.Location = new System.Drawing.Point(6, 3);
            this.lblContact_Phone.Name = "lblContact_Phone";
            this.lblContact_Phone.Size = new System.Drawing.Size(38, 13);
            this.lblContact_Phone.TabIndex = 15;
            this.lblContact_Phone.Text = "Phone";
            // 
            // txtContact_Phone
            // 
            this.txtContact_Phone.AllowDrop = true;
            this.txtContact_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Phone.Location = new System.Drawing.Point(6, 19);
            this.txtContact_Phone.Name = "txtContact_Phone";
            this.txtContact_Phone.Size = new System.Drawing.Size(488, 20);
            this.txtContact_Phone.TabIndex = 14;
            // 
            // tabContact_Address
            // 
            this.tabContact_Address.Controls.Add(this.lblContact_Zip);
            this.tabContact_Address.Controls.Add(this.txtContact_Zip);
            this.tabContact_Address.Controls.Add(this.lblContact_State);
            this.tabContact_Address.Controls.Add(this.txtContact_State);
            this.tabContact_Address.Controls.Add(this.lblContact_Number);
            this.tabContact_Address.Controls.Add(this.txtContact_Number);
            this.tabContact_Address.Controls.Add(this.lblContact_City);
            this.tabContact_Address.Controls.Add(this.txtContact_City);
            this.tabContact_Address.Controls.Add(this.lblContact_Address);
            this.tabContact_Address.Controls.Add(this.txtContact_Address);
            this.tabContact_Address.Location = new System.Drawing.Point(4, 4);
            this.tabContact_Address.Name = "tabContact_Address";
            this.tabContact_Address.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact_Address.Size = new System.Drawing.Size(500, 122);
            this.tabContact_Address.TabIndex = 1;
            this.tabContact_Address.Text = "Address";
            this.tabContact_Address.UseVisualStyleBackColor = true;
            // 
            // lblContact_Zip
            // 
            this.lblContact_Zip.AutoSize = true;
            this.lblContact_Zip.Location = new System.Drawing.Point(3, 45);
            this.lblContact_Zip.Name = "lblContact_Zip";
            this.lblContact_Zip.Size = new System.Drawing.Size(24, 13);
            this.lblContact_Zip.TabIndex = 31;
            this.lblContact_Zip.Text = "ZIP";
            // 
            // txtContact_Zip
            // 
            this.txtContact_Zip.Location = new System.Drawing.Point(6, 61);
            this.txtContact_Zip.Name = "txtContact_Zip";
            this.txtContact_Zip.Size = new System.Drawing.Size(56, 20);
            this.txtContact_Zip.TabIndex = 30;
            // 
            // lblContact_State
            // 
            this.lblContact_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact_State.AutoSize = true;
            this.lblContact_State.Location = new System.Drawing.Point(446, 45);
            this.lblContact_State.Name = "lblContact_State";
            this.lblContact_State.Size = new System.Drawing.Size(32, 13);
            this.lblContact_State.TabIndex = 29;
            this.lblContact_State.Text = "State";
            // 
            // txtContact_State
            // 
            this.txtContact_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_State.Location = new System.Drawing.Point(449, 61);
            this.txtContact_State.Name = "txtContact_State";
            this.txtContact_State.Size = new System.Drawing.Size(45, 20);
            this.txtContact_State.TabIndex = 28;
            // 
            // lblContact_Number
            // 
            this.lblContact_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact_Number.AutoSize = true;
            this.lblContact_Number.Location = new System.Drawing.Point(446, 6);
            this.lblContact_Number.Name = "lblContact_Number";
            this.lblContact_Number.Size = new System.Drawing.Size(45, 13);
            this.lblContact_Number.TabIndex = 27;
            this.lblContact_Number.Text = "Address";
            // 
            // txtContact_Number
            // 
            this.txtContact_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Number.Location = new System.Drawing.Point(449, 22);
            this.txtContact_Number.Name = "txtContact_Number";
            this.txtContact_Number.Size = new System.Drawing.Size(45, 20);
            this.txtContact_Number.TabIndex = 26;
            // 
            // lblContact_City
            // 
            this.lblContact_City.AutoSize = true;
            this.lblContact_City.Location = new System.Drawing.Point(66, 45);
            this.lblContact_City.Name = "lblContact_City";
            this.lblContact_City.Size = new System.Drawing.Size(24, 13);
            this.lblContact_City.TabIndex = 25;
            this.lblContact_City.Text = "City";
            // 
            // txtContact_City
            // 
            this.txtContact_City.AllowDrop = true;
            this.txtContact_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_City.Location = new System.Drawing.Point(68, 61);
            this.txtContact_City.Name = "txtContact_City";
            this.txtContact_City.Size = new System.Drawing.Size(375, 20);
            this.txtContact_City.TabIndex = 24;
            // 
            // lblContact_Address
            // 
            this.lblContact_Address.AutoSize = true;
            this.lblContact_Address.Location = new System.Drawing.Point(6, 6);
            this.lblContact_Address.Name = "lblContact_Address";
            this.lblContact_Address.Size = new System.Drawing.Size(45, 13);
            this.lblContact_Address.TabIndex = 23;
            this.lblContact_Address.Text = "Address";
            // 
            // txtContact_Address
            // 
            this.txtContact_Address.AllowDrop = true;
            this.txtContact_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Address.Location = new System.Drawing.Point(6, 22);
            this.txtContact_Address.Name = "txtContact_Address";
            this.txtContact_Address.Size = new System.Drawing.Size(437, 20);
            this.txtContact_Address.TabIndex = 22;
            // 
            // tabContact_Mail
            // 
            this.tabContact_Mail.Controls.Add(this.lblContact_Web);
            this.tabContact_Mail.Controls.Add(this.txtContact_Web);
            this.tabContact_Mail.Controls.Add(this.lblContact_Mail);
            this.tabContact_Mail.Controls.Add(this.txtContact_Mail);
            this.tabContact_Mail.Location = new System.Drawing.Point(4, 4);
            this.tabContact_Mail.Name = "tabContact_Mail";
            this.tabContact_Mail.Size = new System.Drawing.Size(500, 122);
            this.tabContact_Mail.TabIndex = 2;
            this.tabContact_Mail.Text = "Mail / Web";
            this.tabContact_Mail.UseVisualStyleBackColor = true;
            // 
            // lblContact_Web
            // 
            this.lblContact_Web.AutoSize = true;
            this.lblContact_Web.Location = new System.Drawing.Point(6, 45);
            this.lblContact_Web.Name = "lblContact_Web";
            this.lblContact_Web.Size = new System.Drawing.Size(49, 13);
            this.lblContact_Web.TabIndex = 21;
            this.lblContact_Web.Text = "Web site";
            // 
            // txtContact_Web
            // 
            this.txtContact_Web.AllowDrop = true;
            this.txtContact_Web.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Web.Location = new System.Drawing.Point(6, 61);
            this.txtContact_Web.Name = "txtContact_Web";
            this.txtContact_Web.Size = new System.Drawing.Size(488, 20);
            this.txtContact_Web.TabIndex = 20;
            // 
            // lblContact_Mail
            // 
            this.lblContact_Mail.AutoSize = true;
            this.lblContact_Mail.Location = new System.Drawing.Point(6, 6);
            this.lblContact_Mail.Name = "lblContact_Mail";
            this.lblContact_Mail.Size = new System.Drawing.Size(26, 13);
            this.lblContact_Mail.TabIndex = 19;
            this.lblContact_Mail.Text = "Mail";
            // 
            // txtContact_Mail
            // 
            this.txtContact_Mail.AllowDrop = true;
            this.txtContact_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Mail.Location = new System.Drawing.Point(6, 22);
            this.txtContact_Mail.Name = "txtContact_Mail";
            this.txtContact_Mail.Size = new System.Drawing.Size(488, 20);
            this.txtContact_Mail.TabIndex = 18;
            // 
            // tabContact_Other
            // 
            this.tabContact_Other.Controls.Add(this.lblContact_Nick);
            this.tabContact_Other.Controls.Add(this.txtContact_Nick);
            this.tabContact_Other.Controls.Add(this.btnContact_BirthDateClear);
            this.tabContact_Other.Controls.Add(this.lblContact_Note);
            this.tabContact_Other.Controls.Add(this.txtContact_Note);
            this.tabContact_Other.Controls.Add(this.lblContact_BirthDate);
            this.tabContact_Other.Controls.Add(this.dtpContact_BirthDate);
            this.tabContact_Other.Location = new System.Drawing.Point(4, 4);
            this.tabContact_Other.Name = "tabContact_Other";
            this.tabContact_Other.Size = new System.Drawing.Size(500, 122);
            this.tabContact_Other.TabIndex = 3;
            this.tabContact_Other.Text = "Other";
            this.tabContact_Other.UseVisualStyleBackColor = true;
            // 
            // lblContact_Note
            // 
            this.lblContact_Note.AutoSize = true;
            this.lblContact_Note.Location = new System.Drawing.Point(6, 81);
            this.lblContact_Note.Name = "lblContact_Note";
            this.lblContact_Note.Size = new System.Drawing.Size(30, 13);
            this.lblContact_Note.TabIndex = 21;
            this.lblContact_Note.Text = "Note";
            // 
            // txtContact_Note
            // 
            this.txtContact_Note.AllowDrop = true;
            this.txtContact_Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Note.Location = new System.Drawing.Point(6, 97);
            this.txtContact_Note.Name = "txtContact_Note";
            this.txtContact_Note.Size = new System.Drawing.Size(488, 20);
            this.txtContact_Note.TabIndex = 20;
            // 
            // lblContact_BirthDate
            // 
            this.lblContact_BirthDate.AutoSize = true;
            this.lblContact_BirthDate.Location = new System.Drawing.Point(4, 41);
            this.lblContact_BirthDate.Name = "lblContact_BirthDate";
            this.lblContact_BirthDate.Size = new System.Drawing.Size(52, 13);
            this.lblContact_BirthDate.TabIndex = 3;
            this.lblContact_BirthDate.Text = "Birth date";
            // 
            // dtpContact_BirthDate
            // 
            this.dtpContact_BirthDate.Checked = false;
            this.dtpContact_BirthDate.CustomFormat = " ";
            this.dtpContact_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContact_BirthDate.Location = new System.Drawing.Point(7, 57);
            this.dtpContact_BirthDate.Name = "dtpContact_BirthDate";
            this.dtpContact_BirthDate.Size = new System.Drawing.Size(110, 20);
            this.dtpContact_BirthDate.TabIndex = 2;
            this.dtpContact_BirthDate.ValueChanged += new System.EventHandler(this.dtpContact_BirthDate_ValueChanged);
            // 
            // tabContact_Options
            // 
            this.tabContact_Options.Location = new System.Drawing.Point(4, 4);
            this.tabContact_Options.Name = "tabContact_Options";
            this.tabContact_Options.Size = new System.Drawing.Size(500, 122);
            this.tabContact_Options.TabIndex = 4;
            this.tabContact_Options.Text = "Options";
            this.tabContact_Options.UseVisualStyleBackColor = true;
            // 
            // tabEvent
            // 
            this.tabEvent.Controls.Add(this.dtpEvent_EndTime);
            this.tabEvent.Controls.Add(this.dtpEvent_StartTime);
            this.tabEvent.Controls.Add(this.chkEvent_AllDay);
            this.tabEvent.Controls.Add(this.lblEvent_Location);
            this.tabEvent.Controls.Add(this.txtEvent_Location);
            this.tabEvent.Controls.Add(this.lblEvent_Description);
            this.tabEvent.Controls.Add(this.txtEvent_Description);
            this.tabEvent.Controls.Add(this.lblEvent_Name);
            this.tabEvent.Controls.Add(this.txtEvent_Name);
            this.tabEvent.Controls.Add(this.lblEvent_End);
            this.tabEvent.Controls.Add(this.dtpEvent_End);
            this.tabEvent.Controls.Add(this.lblEvent_Start);
            this.tabEvent.Controls.Add(this.dtpEvent_Start);
            this.tabEvent.Location = new System.Drawing.Point(4, 22);
            this.tabEvent.Name = "tabEvent";
            this.tabEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvent.Size = new System.Drawing.Size(514, 200);
            this.tabEvent.TabIndex = 2;
            this.tabEvent.Text = "Event";
            this.tabEvent.UseVisualStyleBackColor = true;
            // 
            // dtpEvent_EndTime
            // 
            this.dtpEvent_EndTime.CustomFormat = "HH:mm";
            this.dtpEvent_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent_EndTime.Location = new System.Drawing.Point(319, 172);
            this.dtpEvent_EndTime.Name = "dtpEvent_EndTime";
            this.dtpEvent_EndTime.ShowUpDown = true;
            this.dtpEvent_EndTime.Size = new System.Drawing.Size(59, 20);
            this.dtpEvent_EndTime.TabIndex = 12;
            // 
            // dtpEvent_StartTime
            // 
            this.dtpEvent_StartTime.CustomFormat = "HH:mm";
            this.dtpEvent_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent_StartTime.Location = new System.Drawing.Point(125, 172);
            this.dtpEvent_StartTime.Name = "dtpEvent_StartTime";
            this.dtpEvent_StartTime.ShowUpDown = true;
            this.dtpEvent_StartTime.Size = new System.Drawing.Size(59, 20);
            this.dtpEvent_StartTime.TabIndex = 11;
            this.dtpEvent_StartTime.ValueChanged += new System.EventHandler(this.dtpEvent_StartTime_ValueChanged);
            // 
            // chkEvent_AllDay
            // 
            this.chkEvent_AllDay.AutoSize = true;
            this.chkEvent_AllDay.Location = new System.Drawing.Point(418, 174);
            this.chkEvent_AllDay.Name = "chkEvent_AllDay";
            this.chkEvent_AllDay.Size = new System.Drawing.Size(87, 17);
            this.chkEvent_AllDay.TabIndex = 10;
            this.chkEvent_AllDay.Text = "All day event";
            this.chkEvent_AllDay.UseVisualStyleBackColor = true;
            // 
            // lblEvent_Location
            // 
            this.lblEvent_Location.AutoSize = true;
            this.lblEvent_Location.Location = new System.Drawing.Point(6, 107);
            this.lblEvent_Location.Name = "lblEvent_Location";
            this.lblEvent_Location.Size = new System.Drawing.Size(48, 13);
            this.lblEvent_Location.TabIndex = 9;
            this.lblEvent_Location.Text = "Location";
            // 
            // txtEvent_Location
            // 
            this.txtEvent_Location.AllowDrop = true;
            this.txtEvent_Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvent_Location.Location = new System.Drawing.Point(6, 123);
            this.txtEvent_Location.Name = "txtEvent_Location";
            this.txtEvent_Location.Size = new System.Drawing.Size(502, 20);
            this.txtEvent_Location.TabIndex = 8;
            // 
            // lblEvent_Description
            // 
            this.lblEvent_Description.AutoSize = true;
            this.lblEvent_Description.Location = new System.Drawing.Point(6, 58);
            this.lblEvent_Description.Name = "lblEvent_Description";
            this.lblEvent_Description.Size = new System.Drawing.Size(60, 13);
            this.lblEvent_Description.TabIndex = 7;
            this.lblEvent_Description.Text = "Description";
            // 
            // txtEvent_Description
            // 
            this.txtEvent_Description.AllowDrop = true;
            this.txtEvent_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvent_Description.Location = new System.Drawing.Point(6, 74);
            this.txtEvent_Description.Name = "txtEvent_Description";
            this.txtEvent_Description.Size = new System.Drawing.Size(502, 20);
            this.txtEvent_Description.TabIndex = 6;
            // 
            // lblEvent_Name
            // 
            this.lblEvent_Name.AutoSize = true;
            this.lblEvent_Name.Location = new System.Drawing.Point(6, 10);
            this.lblEvent_Name.Name = "lblEvent_Name";
            this.lblEvent_Name.Size = new System.Drawing.Size(64, 13);
            this.lblEvent_Name.TabIndex = 5;
            this.lblEvent_Name.Text = "Event name";
            // 
            // txtEvent_Name
            // 
            this.txtEvent_Name.AllowDrop = true;
            this.txtEvent_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvent_Name.Location = new System.Drawing.Point(6, 26);
            this.txtEvent_Name.Name = "txtEvent_Name";
            this.txtEvent_Name.Size = new System.Drawing.Size(502, 20);
            this.txtEvent_Name.TabIndex = 4;
            // 
            // lblEvent_End
            // 
            this.lblEvent_End.AutoSize = true;
            this.lblEvent_End.Location = new System.Drawing.Point(200, 156);
            this.lblEvent_End.Name = "lblEvent_End";
            this.lblEvent_End.Size = new System.Drawing.Size(56, 13);
            this.lblEvent_End.TabIndex = 3;
            this.lblEvent_End.Text = "Event end";
            // 
            // dtpEvent_End
            // 
            this.dtpEvent_End.CustomFormat = "dd MMM yyyy";
            this.dtpEvent_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent_End.Location = new System.Drawing.Point(203, 172);
            this.dtpEvent_End.Name = "dtpEvent_End";
            this.dtpEvent_End.Size = new System.Drawing.Size(110, 20);
            this.dtpEvent_End.TabIndex = 2;
            // 
            // lblEvent_Start
            // 
            this.lblEvent_Start.AutoSize = true;
            this.lblEvent_Start.Location = new System.Drawing.Point(6, 156);
            this.lblEvent_Start.Name = "lblEvent_Start";
            this.lblEvent_Start.Size = new System.Drawing.Size(58, 13);
            this.lblEvent_Start.TabIndex = 1;
            this.lblEvent_Start.Text = "Event start";
            // 
            // dtpEvent_Start
            // 
            this.dtpEvent_Start.CustomFormat = "dd MMM yyyy";
            this.dtpEvent_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent_Start.Location = new System.Drawing.Point(9, 172);
            this.dtpEvent_Start.Name = "dtpEvent_Start";
            this.dtpEvent_Start.Size = new System.Drawing.Size(110, 20);
            this.dtpEvent_Start.TabIndex = 0;
            this.dtpEvent_Start.ValueChanged += new System.EventHandler(this.dtpEvent_Start_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(424, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Generate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(307, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Image";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(190, 504);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(111, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnContact_BirthDateClear
            // 
            this.btnContact_BirthDateClear.Location = new System.Drawing.Point(125, 57);
            this.btnContact_BirthDateClear.Name = "btnContact_BirthDateClear";
            this.btnContact_BirthDateClear.Size = new System.Drawing.Size(75, 20);
            this.btnContact_BirthDateClear.TabIndex = 22;
            this.btnContact_BirthDateClear.Text = "Clear";
            this.btnContact_BirthDateClear.UseVisualStyleBackColor = true;
            this.btnContact_BirthDateClear.Click += new System.EventHandler(this.btnContact_BirthDateClear_Click);
            // 
            // lblContact_Nick
            // 
            this.lblContact_Nick.AutoSize = true;
            this.lblContact_Nick.Location = new System.Drawing.Point(6, 2);
            this.lblContact_Nick.Name = "lblContact_Nick";
            this.lblContact_Nick.Size = new System.Drawing.Size(55, 13);
            this.lblContact_Nick.TabIndex = 24;
            this.lblContact_Nick.Text = "Nickname";
            // 
            // txtContact_Nick
            // 
            this.txtContact_Nick.AllowDrop = true;
            this.txtContact_Nick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact_Nick.Location = new System.Drawing.Point(6, 18);
            this.txtContact_Nick.Name = "txtContact_Nick";
            this.txtContact_Nick.Size = new System.Drawing.Size(488, 20);
            this.txtContact_Nick.TabIndex = 23;
            // 
            // GeneratorForm
            // 
            this.ClientSize = new System.Drawing.Size(547, 539);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tcInput);
            this.Controls.Add(this.tcResult);
            this.Controls.Add(this.btnAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorForm";
            this.tcResult.ResumeLayout(false);
            this.tabImage.ResumeLayout(false);
            this.tabImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tcInput.ResumeLayout(false);
            this.tabUrl.ResumeLayout(false);
            this.tabUrl.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.tabContact.PerformLayout();
            this.tcContact.ResumeLayout(false);
            this.tabContact_Phones.ResumeLayout(false);
            this.tabContact_Phones.PerformLayout();
            this.tabContact_Address.ResumeLayout(false);
            this.tabContact_Address.PerformLayout();
            this.tabContact_Mail.ResumeLayout(false);
            this.tabContact_Mail.PerformLayout();
            this.tabContact_Other.ResumeLayout(false);
            this.tabContact_Other.PerformLayout();
            this.tabEvent.ResumeLayout(false);
            this.tabEvent.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TabControl tcResult;
        private System.Windows.Forms.TabPage tabImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TabControl tcInput;
        private System.Windows.Forms.TabPage tabUrl;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TextBox txtURL_url;
        private System.Windows.Forms.TabPage tabEvent;
        private System.Windows.Forms.Label lblURL_url;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label lblForeColor;
        private System.Windows.Forms.TextBox txtForeColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.TextBox txtBackColor;
        private System.Windows.Forms.CheckBox chkBorder;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblEvent_End;
        private System.Windows.Forms.DateTimePicker dtpEvent_End;
        private System.Windows.Forms.Label lblEvent_Start;
        private System.Windows.Forms.DateTimePicker dtpEvent_Start;
        private System.Windows.Forms.Label lblEvent_Name;
        private System.Windows.Forms.TextBox txtEvent_Name;
        private System.Windows.Forms.CheckBox chkEvent_AllDay;
        private System.Windows.Forms.Label lblEvent_Location;
        private System.Windows.Forms.TextBox txtEvent_Location;
        private System.Windows.Forms.Label lblEvent_Description;
        private System.Windows.Forms.TextBox txtEvent_Description;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown txtSize;
        private System.Windows.Forms.Label lblECC;
        private System.Windows.Forms.ComboBox cmbECC;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.DateTimePicker dtpEvent_EndTime;
        private System.Windows.Forms.DateTimePicker dtpEvent_StartTime;
        private System.Windows.Forms.TextBox txtContact_Firstname;
        private System.Windows.Forms.TabControl tcContact;
        private System.Windows.Forms.TabPage tabContact_Phones;
        private System.Windows.Forms.TabPage tabContact_Address;
        private System.Windows.Forms.TabPage tabContact_Mail;
        private System.Windows.Forms.TabPage tabContact_Other;
        private System.Windows.Forms.TabPage tabContact_Options;
        private System.Windows.Forms.Label lblContact_Lastname;
        private System.Windows.Forms.Label lblContact_Firstname;
        private System.Windows.Forms.TextBox txtContact_Lastname;
        private System.Windows.Forms.Label lblContact_Phone;
        private System.Windows.Forms.TextBox txtContact_Phone;
        private System.Windows.Forms.Label lblContact_WorkPhone;
        private System.Windows.Forms.TextBox txtContact_WorkPhone;
        private System.Windows.Forms.Label lblContact_MobilePhone;
        private System.Windows.Forms.TextBox txtContact_MobilePhone;
        private System.Windows.Forms.Label lblContact_Web;
        private System.Windows.Forms.TextBox txtContact_Web;
        private System.Windows.Forms.Label lblContact_Mail;
        private System.Windows.Forms.TextBox txtContact_Mail;
        private System.Windows.Forms.Label lblContact_Note;
        private System.Windows.Forms.TextBox txtContact_Note;
        private System.Windows.Forms.Label lblContact_BirthDate;
        private System.Windows.Forms.DateTimePicker dtpContact_BirthDate;
        private System.Windows.Forms.Label lblContact_State;
        private System.Windows.Forms.TextBox txtContact_State;
        private System.Windows.Forms.Label lblContact_Number;
        private System.Windows.Forms.TextBox txtContact_Number;
        private System.Windows.Forms.Label lblContact_City;
        private System.Windows.Forms.TextBox txtContact_City;
        private System.Windows.Forms.Label lblContact_Address;
        private System.Windows.Forms.TextBox txtContact_Address;
        private System.Windows.Forms.Label lblContact_Zip;
        private System.Windows.Forms.TextBox txtContact_Zip;
        private System.Windows.Forms.Button btnContact_BirthDateClear;
        private System.Windows.Forms.Label lblContact_Nick;
        private System.Windows.Forms.TextBox txtContact_Nick;
    }
}

