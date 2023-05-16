using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientacaoAObjetos.Dia1;

namespace OrientacaoAObjetos.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Boca de 09";
            p1.Idade = 18;
            p1.Mensalidade = 1000;
            p1.Socio = true;
            p1.Interesse = "Conhecendo Novos Modelos";

            Console.WriteLine($"Nosso maior investidor:{p1.Nome.ToUpper()}");
            Console.WriteLine(p1.VerificarSociedade() ? "é nosso sócio" : "não é sócio");
            Console.ReadKey();
        }
    }
}
