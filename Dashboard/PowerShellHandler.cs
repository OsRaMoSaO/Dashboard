using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard;


public static class PowerShellHandler
{
    private static PowerShell ps = PowerShell.Create();

    public static string Command(string script)
    {
        string errorMsg = string.Empty;
        string output = string.Empty;

        ps.AddScript(script);

        ps.AddCommand("OutputSting");

        PSDataCollection<PSObject> outputCollection = new();
        ps.Streams.Error.DataAdded += (object sender, DataAddedEventArgs e) =>
        {
            errorMsg = ((PSDataCollection<ErrorRecord>)sender)[e.Index].ToString();
        };

        IAsyncResult result = ps.BeginInvoke<PSObject, PSObject>(null, outputCollection);

        //wair for poweshell command/script to finish executing
        ps.EndInvoke(result);

        StringBuilder sb = new();

        foreach (var outputItem in outputCollection)
        {
            sb.AppendLine(outputItem.BaseObject.ToString());
        }

        //Clears the commands
        ps.Commands.Clear();

        //if an error is encountered return it
        if (!string.IsNullOrEmpty(errorMsg))
        {
            return errorMsg;
        }

        return sb.ToString().Trim();
    }
}




