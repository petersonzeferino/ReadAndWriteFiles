using ReadAndWriteFiles.Application;
using ReadAndWriteFiles.Application.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace ReadAndWriteFilesTest.Tests
{
    public class ExcelTest
    {
        [Fact(DisplayName = "Create Excel file")]
        public void CheckWriteExcelWithSuccess()
        {
            bool output = true;
            IExcelService _excelService = new ExcelService();

            Random randomValue = new Random();
            string path = $"{Directory.GetCurrentDirectory()}\\MyFile_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss")}_{randomValue.Next()}.xlsx";

            _excelService.WriteExcel(path);

            if (!File.Exists(path))
                output = false;

            Assert.True(output);
        }
    }
}
