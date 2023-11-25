using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Class
{
    class SqlConnectionClass
    {
        public static string Constr()
        {
             // return (@"Data Source=DESKTOP-SRFLLT9\SQLSERVER1;Initial Catalog=LibraryDB;Integrated Security=True");
            // return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("LibraryDB.mdf") + "; Integrated Security=True;Connect Timeout=30");
            // return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.AppDomain.CurrentDomain.BaseDirectory + " \\1LibraryDB.mdf; Integrated Security=True;Connect Timeout=30");
            return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database\LibraryDB.mdf'; Integrated Security=True;Connect Timeout=30");
        }
    }
}
