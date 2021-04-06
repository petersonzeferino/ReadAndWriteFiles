using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;

namespace ReadAndWriteFiles.Domain.Entities.CSV
{
    public class RequestEntity
    {
        public RequestEntity() { }

        public RequestEntity(string nome, long cpf, string telefone, string celular, string data)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Celular = celular;
            Data = data;
        }

        public List<RequestEntity> FactoryRequestEntity()
        {
            List<RequestEntity> list = new List<RequestEntity>();

            RequestEntity fileModelOne = new RequestEntity()
            {
                Nome = "Test One",
                Cpf = 12345678900,
                Telefone = "11234567",
                Celular = "912345678",
                Data = DateTime.Today.ToString()
            };

            RequestEntity fileModelTwo = new RequestEntity()
            {
                Nome = "Test Two",
                Cpf = 22345678900,
                Telefone = "21234567",
                Celular = "922345678",
                Data = DateTime.Today.ToString()
            };

            RequestEntity fileModelThree = new RequestEntity()
            {
                Nome = "Test Three",
                Cpf = 32345678900,
                Telefone = "31234567",
                Celular = "932345678",
                Data = DateTime.Today.ToString()
            };

            list.Add(fileModelOne);
            list.Add(fileModelTwo);
            list.Add(fileModelThree);

            return list;
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
