using FibonacciStrings.BL.Interfaces;
using FibonacciStrings.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FibonacciStrings.BL.Managers
{
    public class FileManager : IFileManager
    {
        public string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public void WriteFile (string reverseS)
        {
            File.AppendAllText("result-" + DateTime.Now.ToString("dd.MM.yyyy-HH-mm-ss") + ".txt", reverseS + "\n");
        }
      
    }
}
