using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Gnu.Getopt;

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
            GeneratorForm generator = new GeneratorForm();

            // Get infos from assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            string prgName = assembly.GetName().Name;

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
                        throw new ArgumentException(string.Format("Doh! You need an argument for option '{0}'", (char)options.getopt()));

                    case '?':
                        throw new ArgumentException(string.Format("The option '{0}' is not valid", options.Argv[options.Optind - 1]));

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
