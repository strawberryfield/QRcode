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

using System;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Gnu.Getopt;
using NGettext;

namespace Casasoft.QRcode
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Get infos from assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            string prgName = assembly.GetName().Name;

            // locales management
            string localeName = ConfigurationManager.AppSettings["locale"];
            CultureInfo locale;

            if (string.IsNullOrWhiteSpace(localeName))
                locale = CultureInfo.CurrentCulture;
            else
                locale = new CultureInfo(localeName);

            ICatalog T = new Catalog(prgName, "./locale", locale);

            GeneratorForm generator = new GeneratorForm(T);

            // GNU Getopt options
            LongOpt[] longopts = new LongOpt[6];
            longopts[0] = new LongOpt("forecolor", Argument.Required, new StringBuilder(), 'f');
            longopts[1] = new LongOpt("backcolor", Argument.Required, new StringBuilder(), 'b');
            longopts[2] = new LongOpt("ecclevel", Argument.Required, new StringBuilder(), 'e');
            longopts[3] = new LongOpt("size", Argument.Required, new StringBuilder(), 's');

            Getopt options = new Getopt(prgName, args, "f:b:e:s:", longopts);

            int c;
            while ((c = options.getopt()) != -1)
            {
                switch (c)
                {
                    case ':':
                        throw new ArgumentException(T.GetString("Doh! You need an argument for option '{0}'", (char)options.getopt()));

                    case '?':
                        throw new ArgumentException(T.GetString("The option '{0}' is not valid", options.Argv[options.Optind - 1]));

                    case 's':
                        generator.ElementSize = Convert.ToInt16(options.Optarg);
                        break;

                    case 'e':
                        generator.ErrorCorrectionLevel = options.Optarg[0];
                        break;

                    case 'f':
                        generator.QRForeColor = System.Drawing.ColorTranslator.FromHtml(options.Optarg);
                        break;

                    case 'b':
                        generator.QRBackColor = System.Drawing.ColorTranslator.FromHtml(options.Optarg);
                        break;
                }
            }

            // checks if payload is specified
            if (options.Argv.Length > options.Optind)
                generator.Payload = options.Argv[options.Optind];

            Application.Run(generator);
        }
    }
}
