using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorR2
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new ElevatorGUI());
            }
            catch(Exception e)
            {
                Console.WriteLine("\nWARNING\n\n" + e + "\n\nEND WARNING\n");
            }
        }
    }
}
