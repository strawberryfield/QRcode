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
            this.tabEvent = new System.Windows.Forms.TabPage();
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
            this.tcResult.SuspendLayout();
            this.tabImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabData.SuspendLayout();
            this.tcInput.SuspendLayout();
            this.tabUrl.SuspendLayout();
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
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(514, 200);
            this.tabContact.TabIndex = 1;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // tabEvent
            // 
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
            // chkEvent_AllDay
            // 
            this.chkEvent_AllDay.AutoSize = true;
            this.chkEvent_AllDay.Location = new System.Drawing.Point(392, 174);
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
            this.dtpEvent_End.CustomFormat = "dd MMM yyyy   hh:mm:ss";
            this.dtpEvent_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent_End.Location = new System.Drawing.Point(203, 172);
            this.dtpEvent_End.Name = "dtpEvent_End";
            this.dtpEvent_End.Size = new System.Drawing.Size(166, 20);
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
            this.dtpEvent_Start.CustomFormat = "dd MMM yyyy   hh:mm:ss";
            this.dtpEvent_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent_Start.Location = new System.Drawing.Point(9, 172);
            this.dtpEvent_Start.Name = "dtpEvent_Start";
            this.dtpEvent_Start.Size = new System.Drawing.Size(166, 20);
            this.dtpEvent_Start.TabIndex = 0;
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
    }
}

