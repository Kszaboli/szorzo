using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";
            s += "<html lang='hu'>\n";
            s += "<head>\n";
            s += "<meta charset='utf8'>\n";
            s += "<title>szorzótábla</title>\n";
            s += "<meta name='Generator' content='program'>\n";
            s += "</head>\n";
            s += "<body>\n";
            s += "<table>\n";
            for (int i = 1; i <= 10; i++)
            {
                s += "<tr>\n";
                for (int j = 1; j <= 10; j++)
                {
                    s+="<td> " + i * j +"  </td>\n";
                }
                s+="</tr>\n";
            }
            s += "</table>\n";
            s += "</body>\n";
            s += "</html>\n";

            StreamWriter sw = new StreamWriter(@"C:\Users\kovacssz\Desktop\szorzo.html");
            sw.WriteLine(s);
            sw.Close();
        }
    }
}
