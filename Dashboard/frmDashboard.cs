using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            appCheck();
        }

        private void appCheck()
        {
            //Check if apps are installed
            string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            if (Directory.Exists(programFiles + "/Zipperoni"))
            {
                quantumLaunchBtn.Text = "Launch";
                quantumPriceText.Text = "Installed";
                quantumPriceText.Location = new Point(622, 4);
                quantumUninstallBtn.Visible = true;

            }
            else
            {
                quantumLaunchBtn.Text = "Install";
                quantumPriceText.Text = "Free!";
                quantumPriceText.Location = new Point(673, 4);
                quantumUninstallBtn.Visible = false;
            }
        }
        private void quantumLaunchBtn_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "dfshim.dll,ShOpenVerbApplication " + "https://raw.githubusercontent.com/OsRaMoSaO/Quantom-Calculator/master/published/Zipperoni.application");
            appCheck();
        }

        private void quantumUninstallBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implmented, pls uninstall manually", "W.I.P");
            //string deleteQuantum = PowerShellHandler.Command("$applicationName = \"YourApplicationName\"  # Replace with the name of your ClickOnce application\r\n\r\ntry {\r\n    $uninstallKey = \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\*\"\r\n    $uninstallKey64 = \"HKLM:\\Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\*\"\r\n    \r\n    $uninstallEntry = Get-ItemProperty -Path $uninstallKey, $uninstallKey64 | Where-Object { $_.DisplayName -eq $applicationName }\r\n\r\n    if ($uninstallEntry) {\r\n        $uninstallString = $uninstallEntry.UninstallString\r\n        Write-Host \"Uninstalling $applicationName\"\r\n        Start-Process -Wait -NoNewWindow cmd.exe \"/c $uninstallString\"\r\n        Write-Host \"$applicationName has been uninstalled.\"\r\n    } else {\r\n        Write-Host \"$applicationName not found.\"\r\n    }\r\n} catch {\r\n    Write-Host \"An error occurred: $_\"\r\n}\r\n");
        }
    }


}
