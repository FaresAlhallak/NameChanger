using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = "C:/Users/fares/source/repos/NameChanger/NameChanger/Downloads/";
            string[] files = Directory.GetFiles(dir);
            List<string> ss = new();
            foreach (var s in files)
            {
                ss.Add(s);
            }
            //
            List<FileInfo> filesInfos = new();
            foreach (string file in ss)
            {
                FileInfo fi = new FileInfo(file);
                filesInfos.Add(fi);
            }
            var orderedFiles = filesInfos.OrderBy(c => c.CreationTime);

            int num = 0;
            foreach (var i in orderedFiles)
            {
                    try 
                    {
                        i.MoveTo($"C:/Users/fares/source/repos/NameChanger/NameChanger/Downloads/{num}.png");
                        num++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
            }
            Console.ReadKey();
        }
    } 
}
