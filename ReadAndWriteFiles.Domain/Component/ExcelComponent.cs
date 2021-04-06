using ClosedXML.Excel;
using ReadAndWriteFiles.Domain.Entities.CSV;
using System.Collections.Generic;
using System.Linq;

namespace ReadAndWriteFiles.Domain.Component
{
    public static class ExcelComponent
    {
        //public static void WriteExcel(IList<RequestEntity> records, string path = "")
        //{
        //    using (var workbook = new XLWorkbook())
        //    {
        //        var worksheet = workbook.Worksheets.Add("Person");
        //        worksheet.Cell(1, 1).Value = "Nome";
        //        worksheet.Cell(1, 2).Value = "Cpf";
        //        worksheet.Cell(1, 3).Value = "Telefone";
        //        worksheet.Cell(1, 4).Value = "Celular";
        //        worksheet.Cell(1, 5).Value = "Data";

        //        for (int index = 1; index <= records.Count; index++)
        //        {
        //            worksheet.Cell(index + 1, 1).Value = records[index - 1].Nome;
        //            worksheet.Cell(index + 1, 2).Value = records[index - 1].Cpf.ToString();
        //            worksheet.Cell(index + 1, 3).Value = records[index - 1].Telefone;
        //            worksheet.Cell(index + 1, 4).Value = records[index - 1].Celular;
        //            worksheet.Cell(index + 1, 5).Value = records[index - 1].Data;
        //        }
        //        workbook.SaveAs(path);
        //    }
        //}

        //ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
        //ExcelWorksheet worksheet2 = RemoverLinhasVazias(worksheet);

        //public ExcelWorksheet RemoverLinhasVazias(ExcelWorksheet worksheet)
        //{
        //    while (VerificarUltimaLinha(worksheet))
        //        worksheet.DeleteRow(worksheet.Dimension.End.Row);

        //    return worksheet;
        //}

        //public static bool VerificarUltimaLinha(ExcelWorksheet worksheet)
        //{
        //    var empties = new List<bool>();

        //    for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
        //    {
        //        var rowEmpty = worksheet.Cells[worksheet.Dimension.End.Row, i].Value == null ? true : false;
        //        empties.Add(rowEmpty);
        //    }

        //    return empties.All(e => e);
        //}
    }
}
