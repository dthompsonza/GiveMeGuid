using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiveMeGuid
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Clipboard.Clear();
            Clipboard.SetText(Guid.NewGuid().ToString());
        }
    }
}
