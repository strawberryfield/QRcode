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
using System.Windows.Forms;
using static Casasoft.QRcode.AssemblyInfo;

namespace Casasoft.QRcode
{
    partial class AboutBox : Form
    {
        public AboutBox() { InitializeComponent(); }

        public AboutBox(ICatalog T)
        {
            InitializeComponent();
            this.Text = T.GetString("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = T.GetString("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

    }
}
