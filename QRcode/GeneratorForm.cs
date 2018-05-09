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

        public GeneratorForm()
        {
            InitializeComponent();
            this.Text = string.Format("{0} {1}", AssemblyTitle, AssemblyVersion);
            cmbECC.SelectedIndex = 2;
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

            }
            else if (tcInput.SelectedTab == tcInput.TabPages["tabEvent"])
            {
                CalendarEvent ce = new CalendarEvent(txtEvent_Name.Text, txtEvent_Description.Text,
                    txtEvent_Location.Text, dtpEvent_Start.Value, dtpEvent_End.Value, chkEvent_AllDay.Checked);
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
        #endregion

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
    }
}
