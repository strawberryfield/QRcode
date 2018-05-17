// copyright (c) 2018 Roberto Ceccarelli - Casasoft
// https://strawberryfield.altervista.org 
// 
// This file is part of Casasoft QRcode
// 
// CasaSoft QRcode is free software: 
// you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CasaSoft QRcode is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CasaSoft QRcode.  
// If not, see <http://www.gnu.org/licenses/>.

using NGettext;
using QRCoder;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace Casasoft.QRcode
{
    public partial class GeneratorForm : Form
    {
        protected QRCodeGenerator qrGenerator;
        protected QRCodeData qrCodeData;
        private ICatalog T; 

        #region public properties
        public int ElementSize
        {
            get => Convert.ToInt16(txtSize.Value);
            set => txtSize.Value = Convert.ToDecimal(value);
        }

        public System.Drawing.Color QRForeColor
        {
            get => txtForeColor.BackColor;
            set => txtForeColor.BackColor = value;
        }

        public System.Drawing.Color QRBackColor
        {
            get => txtBackColor.BackColor;
            set => txtBackColor.BackColor = value;
        }

        public bool AddBorder
        {
            get => chkBorder.Checked;
            set => chkBorder.Checked = value;
        }

        private string eccCodes = "LMQH";
        public char ErrorCorrectionLevel
        {
            get => eccCodes[cmbECC.SelectedIndex];
            set
            {
                int level = eccCodes.IndexOf(value);
                if (level > 0)
                    cmbECC.SelectedIndex = level;
                else
                    throw new ArgumentException("ECC correction level invalid", value.ToString());
            }
        }

        public string Payload
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }
        #endregion

        #region constructors
        public GeneratorForm()
        {
            InitializeComponent();
        }
        
        public GeneratorForm(ICatalog T)
        {
            InitializeComponent();
            this.Text = string.Format("{0} {1}", AssemblyTitle, AssemblyVersion);
            this.T = T;
            translate();

            // Default values
            ErrorCorrectionLevel = 'Q';
            QRForeColor = System.Drawing.Color.Black;
            QRBackColor = System.Drawing.Color.White;
            ElementSize = 20;
            AddBorder = true;
            Payload = "";

            saveFileDialog.Filter = T.GetString("Jpeg image") + "|*.jpg;*.jpeg"
                + "|" + T.GetString("Bitmap image") + "|*.bmp"
                + "|" + T.GetString("PNG image") + "|*.png"
                + "|" + T.GetString("GIF image") + "|*.gif"
                + "|" + T.GetString("TIFF image") + "|*.tif;*.tiff"
                + "|" + T.GetString("SVG image") + "|*.svg";

            qrGenerator = new QRCodeGenerator();
            refreshData();
        }
        #endregion

        #region translations
        private void translate()
        {
            this.btnAbout.Text = T.GetString( "About");
            this.tabImage.Text = T.GetString( "Image");
            this.lblECC.Text = T.GetString( "Error correction level");
            this.chkBorder.Text = T.GetString( "Add empty border");
            this.lblSize.Text = T.GetString( "Element size (px)");
            this.btnBackColor.Text = T.GetString( "Select");
            this.lblBackColor.Text = T.GetString( "Background color");
            this.btnForeColor.Text = T.GetString( "Select");
            this.lblForeColor.Text = T.GetString( "Foreground color");
            this.tabData.Text = T.GetString( "Text");
            this.tabUrl.Text = T.GetString( "URL");
            this.lblURL_url.Text = T.GetString( "URL");
            this.tabContact.Text = T.GetString( "Contact");
            this.lblContact_Lastname.Text = T.GetString( "Lastname");
            this.lblContact_Firstname.Text = T.GetString( "Firstname");
            this.tabContact_Phones.Text = T.GetString( "Phones");
            this.lblContact_WorkPhone.Text = T.GetString( "Work phone");
            this.lblContact_MobilePhone.Text = T.GetString( "Mobile phone");
            this.lblContact_Phone.Text = T.GetString( "Phone");
            this.tabContact_Address.Text = T.GetString( "Address");
            this.lblContact_Zip.Text = T.GetString( "ZIP");
            this.lblContact_State.Text = T.GetString( "State");
            this.lblContact_Number.Text = T.GetString( "No.");
            this.lblContact_City.Text = T.GetString( "City");
            this.lblContact_Address.Text = T.GetString( "Address");
            this.tabContact_Mail.Text = T.GetString( "Mail / Web");
            this.lblContact_Web.Text = T.GetString( "Web site");
            this.lblContact_Mail.Text = T.GetString( "Mail");
            this.tabContact_Other.Text = T.GetString( "Other");
            this.lblContact_Note.Text = T.GetString( "Note");
            this.lblContact_BirthDate.Text = T.GetString( "Birth date");
            this.tabContact_Options.Text = T.GetString( "Options");
            this.tabEvent.Text = T.GetString( "Event");
            this.chkEvent_AllDay.Text = T.GetString( "All day event");
            this.lblEvent_Location.Text = T.GetString( "Location");
            this.lblEvent_Description.Text = T.GetString( "Description");
            this.lblEvent_Name.Text = T.GetString( "Event name");
            this.lblEvent_End.Text = T.GetString( "Event end");
            this.lblEvent_Start.Text = T.GetString( "Event start");
            this.btnUpdate.Text = T.GetString( "Generate");
            this.btnSave.Text = T.GetString( "Save");
            this.btnCopy.Text = T.GetString( "Copy");
            this.btnContact_BirthDateClear.Text = T.GetString( "Clear");
            this.lblContact_Nick.Text = T.GetString( "Nickname");
        }
        #endregion

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox(T);
            ab.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tcInput.SelectedTab == tcInput.TabPages["tabUrl"])
            {
                textBox.Text = txtURL_url.Text;
            }
            else if (tcInput.SelectedTab == tcInput.TabPages["tabContact"])
            {
                ContactData.ContactOutputType outType = ContactData.ContactOutputType.VCard3;
                if (rbContact1.Checked)
                    outType = ContactData.ContactOutputType.VCard21;
                if (rbContact3.Checked)
                    outType = ContactData.ContactOutputType.VCard4;
                if (rbContact4.Checked)
                    outType = ContactData.ContactOutputType.MeCard;

                ContactData cd = new ContactData(outType,
                    txtContact_Firstname.Text, txtContact_Lastname.Text,
                    txtContact_Nick.Text,
                    txtContact_Phone.Text, txtContact_MobilePhone.Text, txtContact_WorkPhone.Text,
                    txtContact_Mail.Text,
                    (dtpContact_BirthDate.CustomFormat.Trim() != "" ? dtpContact_BirthDate.Value.Date : (DateTime?)null),
                    txtContact_Web.Text,
                    txtContact_Address.Text, txtContact_Number.Text,
                    txtContact_City.Text, txtContact_Zip.Text, txtContact_State.Text,
                    txtContact_Note.Text);
                textBox.Text = cd.ToString();
            }
            else if (tcInput.SelectedTab == tcInput.TabPages["tabEvent"])
            {
                CalendarEvent ce = new CalendarEvent(txtEvent_Name.Text, txtEvent_Description.Text,
                    txtEvent_Location.Text,
                    dtpEvent_Start.Value.Date + dtpEvent_StartTime.Value.TimeOfDay,
                    dtpEvent_End.Value.Date + dtpEvent_EndTime.Value.TimeOfDay,
                    chkEvent_AllDay.Checked);
                textBox.Text = ce.ToString();
            }

            refreshData();
        }

        public void refreshData()
        {
            if (qrGenerator == null)
                return;

            qrCodeData = qrGenerator.CreateQrCode(textBox.Text, (QRCodeGenerator.ECCLevel)cmbECC.SelectedIndex);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBox1.Image = qrCode.GetGraphic(
                (int)txtSize.Value, txtForeColor.BackColor, txtBackColor.BackColor, chkBorder.Checked);
        }

        #region Funzioni di accesso attributo assembly

        protected string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        protected string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        #endregion

        #region colors selectors
        private void btnForeColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = txtForeColor.BackColor;
            colorDialog.ShowDialog();
            txtForeColor.BackColor = colorDialog.Color;
            refreshData();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = txtBackColor.BackColor;
            colorDialog.ShowDialog();
            txtBackColor.BackColor = colorDialog.Color;
            refreshData();
        }
        #endregion

        #region triggers
        private void chkBorder_CheckedChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txtSize_ValueChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void cmbECC_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        #endregion

        #region save/copy
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if(saveFileDialog.FileName != "")
            {
                if (saveFileDialog.FilterIndex <= 5)
                {


                    FileStream fs = (FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;

                        case 4:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                            break;

                        case 5:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
                            break;
                    }

                    fs.Close();
                }
                else
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                         case 6:
                            SvgQRCode qrCode = new SvgQRCode(qrCodeData);
                            string qrCodeAsSvg = qrCode.GetGraphic(20);
                            File.WriteAllText(saveFileDialog.FileName, qrCodeAsSvg);
                            break;
                    }
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (tcResult.SelectedTab == tcResult.TabPages["tabImage"])
                Clipboard.SetImage(pictureBox1.Image);
            else
                Clipboard.SetText(textBox.Text);
        }
        #endregion

        #region event tab triggers
        private void dtpEvent_Start_ValueChanged(object sender, EventArgs e)
        {
            dtpEvent_End.Value = dtpEvent_Start.Value.Date;
        }

        private void dtpEvent_StartTime_ValueChanged(object sender, EventArgs e)
        {
            dtpEvent_EndTime.Value = dtpEvent_StartTime.Value.AddHours(2);
        }
        #endregion

        #region contact tab triggers
        private void dtpContact_BirthDate_ValueChanged(object sender, EventArgs e)
        {
            dtpContact_BirthDate.CustomFormat = "dd MMM yyyy";
        }

        private void btnContact_BirthDateClear_Click(object sender, EventArgs e)
        {
            dtpContact_BirthDate.CustomFormat = " ";
        }
        #endregion
    }
}
