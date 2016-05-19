using System.Text;
using System.Management.Automation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace PowerShellExecution
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var mimixAccountStatus = PowerShell.Create();
            mimixAccountStatus.Commands.AddScript("C:\\VITS\\psScripts\\mimixAccountStatus.ps1");
            var mimixAccountStatusResult = mimixAccountStatus.Invoke();

            if (mimixAccountStatusResult.Count > 0)
            {
                var builder = new StringBuilder();

                foreach (var psObject in mimixAccountStatusResult)
                {
                    //builder.Append(psObject.BaseObject.ToString() + "\r\n");                  // \r\n can be used when multiple objects are expected to be returned.
                    builder.Append(psObject.BaseObject.ToString());
                }

                if ((builder.ToString()).ToLower() == "true")
                {
                    lbl_MimixAccountStatus.Text = "Enabled";
                }
                else if ((builder.ToString()).ToLower() == "false")
                {
                    lbl_MimixAccountStatus.Text = "Disabled";
                }
                else
                {
                    lbl_MimixAccountStatus.Text = builder.ToString();
                }

            }
            else
            {
                lbl_MimixAccountStatus.Text = "Error finding status";
            }

        }

        protected void EnableMimix_Click(object sender, EventArgs e)
        {
            // Initialise PowerShell engine
            var shell = PowerShell.Create();

            // Add the script to the PowerShell Object
            shell.Commands.AddScript("C:\\VITS\\psScripts\\enableMimixAccount.ps1");

            // Execute the script
            shell.Invoke();

            //Refresh current page
            Response.Redirect(Request.RawUrl);
        }

        protected void DisableMimix_Click(object sender, EventArgs e)
        {
            // Initialise PowerShell engine
            var shell = PowerShell.Create();

            // Add the script to the PowerShell Object
            shell.Commands.AddScript("C:\\VITS\\psScripts\\disableMimixAccount.ps1");

            // Execute the script
            shell.Invoke();

            //Refresh current page
            Response.Redirect(Request.RawUrl);
        }
    }
}