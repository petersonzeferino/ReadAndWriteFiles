using System;
using System.IO;

namespace ReadAndWriteFilesTest.Helpers
{
    public static class FileHelper
    {
        public static string CreateFile(string extension)
        {
            Random randomValue = new Random();
            return $"{Directory.GetCurrentDirectory()}\\MyFile_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss")}_{randomValue.Next()}.{extension}";
        }
    }
}
