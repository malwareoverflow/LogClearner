using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogClearner
{
  public static  class Library
    {
        public static void writetoLog(Exception ex)
        {
         
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Logfile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" + ex.ToString().Trim() + ";" + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {

               
            }
        }
    }
}
