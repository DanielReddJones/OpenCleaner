/*
 * Author: Daniel Jones
 * Operating system: Windows 10 Pro 10.0.19045
 * Last modified: 12/12/2022 7:52 PM
 * IDE/.net: Visual Studio 2022 .net 6.0
 * Purpose: Checks for common optimization configurations and changes upon user request.
 */



using System.Diagnostics;
using System.Security.Principal;

namespace OpenCleaner
{
    public partial class OpenCleaner : Form
    {
        //counter variable
        int i = 0;
  
        public OpenCleaner()
        {
            InitializeComponent();
            if (IsAdministrator() == false)
            {
                InstLabel.Text = "Must be run as administrator.";
                contButton.Visible = false;
            }
            
            }

        private void contButton_Click(object sender, EventArgs e)
        {
            switch (i) {
                case 0:
                    contButton.Visible = false;
                    contButton.Text = "continue";
                    CleanupMethod();
                    break;
                case 1:
                    i = i + 1;
                    InstLabel.Text = "disable unneeded visual effects?";
                    contButton.Visible = false;
                    YesTask.Visible = true;
                    NoTask.Visible = true;
                    break;
            }
        }


        //list of tasks to clean up PC
        private void CleanupMethod()
        {
            i = i + 1;
            if (i == 1)
            {
                InstLabel.Text = "Disable startup programs? Pressing no will open task manager and let you disable programs manually.";
                YesTask.Visible = true;
                NoTask.Visible = true;
            }
 
        }

        //Checks if program is being run as administrator. Returns true/false.
        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void YesTask_Click(object sender, EventArgs e)
        {
            switch(i)
            {
                case 1:
                    InstLabel.Text = "erased startup programs.";
                    
                    break;
                case 2:
                    InstLabel.Text = "opening visual effects";
                    break;
                    
            }
        }

        private void NoTask_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:  InstLabel.Text = "Opening Task Manager. Click \"more details\" at the bottom and select the startup tasks tab. Disable what you do not need." +
                        "When you are done, press continue.";
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C taskmgr.exe";
                    process.StartInfo = startInfo;
                    process.Start();
                    YesTask.Visible = false;
                    NoTask.Visible = false;
                    contButton.Visible = true;
                    
                    break;
            }
        }
    }
}