using OfficeOpenXml;
using ReadAndWriteFiles.Domain.Entities.CSV;
using System.Collections.Generic;
using System.Linq;

namespace ReadAndWriteFiles.Domain.Component
{
    public static class ExcelComponent
    {
        public static ExcelWorksheet RemoverLinhasVazias(ExcelWorksheet worksheet)
        {
            while (VerificarUltimaLinha(worksheet))
                worksheet.DeleteRow(worksheet.Dimension.End.Row);

            return worksheet;
        }

        public static bool VerificarUltimaLinha(ExcelWorksheet worksheet)
        {
            var empties = new List<bool>();

            for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
            {
                var rowEmpty = worksheet.Cells[worksheet.Dimension.End.Row, i].Value == null ? true : false;
                empties.Add(rowEmpty);
            }

            return empties.All(e => e);
        }
    }
}
