using FibonacciStrings.BL.Extensions;
using FibonacciStrings.BL.Helpers;
using FibonacciStrings.BL.Interfaces;
using FibonacciStrings.BL.Managers;
using FibonacciStrings.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciStrings.BL.Services
{
    public class FileProcessingService
    {
        private readonly string defaultPath;

        private readonly IFileManager _fileManager;

        public FileProcessingService()
        {
            _fileManager = new FileManager();
            defaultPath = FilePathConfig.GetPathFile();
        }

        public FileProcessingService(string path, IFileManager fileManager)
        {
            _fileManager = fileManager;
            defaultPath = path;
        }

        public void FileProcessing()
        {
            string[] lines = _fileManager.ReadFile(defaultPath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (FibonacciExtension.IsFibonacci(i + 1))
                {
                    _fileManager.WriteFile(lines[i].Reverse());
                }
            }
        }
    }
}
