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

        public GeneratorForm()
        {
            InitializeComponent();
            this.Text = string.Format("{0} {1}", AssemblyTitle, AssemblyVersion);

            // Default values
            ErrorCorrectionLevel = 'Q';
            QRForeColor = System.Drawing.Color.Black;
            QRBackColor = System.Drawing.Color.White;
            ElementSize = 20;
            AddBorder = true;
            Payload = "";

            saveFileDialog.Filter = "Jpeg image|*.jpg;*.jpeg|Bitmap image|*.bmp|PNG image|*.png|GIF image|*.gif|TIFF image|*.tif;*.tiff";

            qrGenerator = new QRCodeGenerator();
            refreshData();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
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

        protected void refreshData()
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
