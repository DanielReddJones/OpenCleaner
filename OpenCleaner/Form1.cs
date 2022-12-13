/*
 * Author: Daniel Jones
 * Operating system: Windows 10 Pro 10.0.19045
 * Last modified: 12/12/2022
 * IDE/.net: Visual Studio 2022 .net 6.0
 * Purpose: Checks for common optimization configurations and changes upon user request.
 */



using System.Security.Principal;

namespace OpenCleaner
{
    public partial class OpenCleaner : Form
    {
        //counter variable
        int i = 0;
        bool TruFls;
        public OpenCleaner()
        {
            InitializeComponent();
            if (IsAdministrator() == false)
            {
                InstLabel.Text = "Must be run as administrator.";
                button1.Visible = false;
            }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;

            CleanupMethod();
            
        }

        private void CleanupMethod()
        {
            i = i + 1;
            if (i == 1)
            {
                InstLabel.Text = "Do you wish to disable all startup programs? Press yes to disable all startup programs and no to open task manager startup programs tag.";

                if (TruFls == true)
                {
                    InstLabel.Text = "disabling startup programs.";

                }
            }

        }

        //Checks if program is being run as administrator. Returns true/false.
        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TruFls = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TruFls = false;
        }
    }
}