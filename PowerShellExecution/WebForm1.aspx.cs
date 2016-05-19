using System.Text;
using System.Management.Automation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PowerShellExecution
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnableMimix_Click(object sender, EventArgs e)
        {
            // Initialise PowerShell engine
            var shell = PowerShell.Create();

            // Add the script to the PowerShell Object
            shell.Commands.AddScript("C:\\VITS\\psScripts\\enableAccount.ps1");

            // Execute the script
            shell.Invoke();
        }

        protected void DisableMimix_Click(object sender, EventArgs e)
        {
            // Initialise PowerShell engine
            var shell = PowerShell.Create();

            // Add the script to the PowerShell Object
            shell.Commands.AddScript("C:\\VITS\\psScripts\\disableAccount.ps1");

            // Execute the script
            shell.Invoke();
        }
    }
}