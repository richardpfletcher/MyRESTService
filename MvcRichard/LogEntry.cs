using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRichard.Factory
{
    public class LogEntry
    {

        public void Log(string text)
        {
            //var folder = @"C:\Users\Richard\Google Drive\projects\SlideShow\WebApplication2\App_Data";
            var folder = @"C:\Users\Richard\Google Drive\WebSites\EvolutionDeploy\App_Data";
            var logfilename = $@"{folder}\logs.txt";
            if (System.IO.Directory.Exists(folder))
                System.IO.File.AppendAllText(logfilename, $"{DateTime.Now}\t{text}\r\n");
        }
    }
}