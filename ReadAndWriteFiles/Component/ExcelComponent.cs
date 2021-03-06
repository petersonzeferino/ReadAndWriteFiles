﻿using ClosedXML.Excel;
using ReadAndWriteFiles.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadAndWriteFiles.Component
{
    public static class ExcelComponent
    {
        public static void WriteExcel(IList<FileModel> records, string path = "")
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Person");
                worksheet.Cell(1, 1).Value = "Nome";
                worksheet.Cell(1, 2).Value = "Cpf";
                worksheet.Cell(1, 3).Value = "Telefone";
                worksheet.Cell(1, 4).Value = "Celular";
                worksheet.Cell(1, 5).Value = "Data";

                for (int index = 1; index <= records.Count; index++)
                {
                    worksheet.Cell(index + 1, 1).Value = records[index - 1].Nome;
                    worksheet.Cell(index + 1, 2).Value = records[index - 1].Cpf.ToString();
                    worksheet.Cell(index + 1, 3).Value = records[index - 1].Telefone;
                    worksheet.Cell(index + 1, 4).Value = records[index - 1].Celular;
                    worksheet.Cell(index + 1, 5).Value = records[index - 1].Data;
                }
                workbook.SaveAs(path);
            }
        }
    }
}
