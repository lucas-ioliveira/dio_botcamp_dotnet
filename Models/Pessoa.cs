using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_botcamp_dotnet.Models
{
    public class Pessoa
    {
        public string nomePessoa { get; set; }
        public 	int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nomePessoa} e tenho {Idade} anos.");
        }

    }
}