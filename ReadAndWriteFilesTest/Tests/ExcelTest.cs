using ReadAndWriteFiles.Application;
using ReadAndWriteFiles.Application.Services;
using ReadAndWriteFilesTest.Helpers;
using System.IO;
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

            string path = FileHelper.CreateFile("xlsx");
            _excelService.WriteExcel(path);

            if (!File.Exists(path))
                output = false;

            Assert.True(output);
        }
    }
}
