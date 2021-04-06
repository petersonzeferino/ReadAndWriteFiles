using ReadAndWriteFiles.Application;
using ReadAndWriteFiles.Application.Services;
using System;
using System.IO;
using Xunit;

namespace ReadAndWriteFilesTest.Tests
{
    public class CSVTest
    {
        [Fact(DisplayName = "Create CSV file")]
        public void CheckWriteCSVWithSuccess()
        {
            bool output = true;
            ICSVService _csvService = new CSVService();

            Random randomValue = new Random();
            string path = $"{Directory.GetCurrentDirectory()}\\MyFile_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss")}_{randomValue.Next()}.csv";

            _csvService.CreateCSV(path);

            if (!File.Exists(path))
                output = false;

            Assert.True(output);
        }
    }
}
