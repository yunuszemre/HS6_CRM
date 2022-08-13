using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HS6_CRM.WinUI.Helper
{
    public static class UIHelper
    {
        public const string appName = "CRM";
        public static DialogResult ErrorMessage(string message)
        {
            return MessageBox.Show(message,appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
