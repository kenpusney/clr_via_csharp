using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CLR_via_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var query = 
                from pathname in Directory.GetFiles(myDocuments)
                let LastWriteTime = File.GetLastWriteTime(pathname)
                where LastWriteTime > (DateTime.Now - TimeSpan.FromDays(7))
                orderby LastWriteTime
                select new {Path = pathname, LastWriteTime};
            foreach (var file in query)
                Console.WriteLine("{0},{1}",file.LastWriteTime,file.Path);
            Console.Read();
        }
    }
}
