using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndWriteFiles.Models
{
    public class FileModel
    {
        public FileModel(string nome, long cpf, string telefone, string celular, string data)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Celular = celular;
            Data = data;
        }

        public FileModel()
        {

        }

        [Index(0)]
        [Name("name")]
        public string Nome { get; set; }

        [Index(1)]
        [Name("document")]
        public long Cpf { get; set; }

        [Index(2)]
        [Name("phone")]
        public string Telefone { get; set; }

        [Index(3)]
        [Name("mobile")]
        public string Celular { get; set; }
                
        [Index(4)]
        [Name("date")]
        public string Data { get; set; }
    }
}
