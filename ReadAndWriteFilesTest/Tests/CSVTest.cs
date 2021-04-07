using ReadAndWriteFiles.Application;
using ReadAndWriteFiles.Application.Services;
using ReadAndWriteFilesTest.Helpers;
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

            string path = FileHelper.CreateFile("csv");
            _csvService.CreateCSV(path);

            if (!File.Exists(path))
                output = false;

            Assert.True(output);
        }
    }
}
