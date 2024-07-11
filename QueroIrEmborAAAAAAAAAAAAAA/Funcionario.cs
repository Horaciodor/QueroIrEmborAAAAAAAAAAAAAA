using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueroIrEmborAAAAAAAAAAAAAA
{
    public class Funcionario:Pessoa
    {
        private int Matricula { get; set; }
        private string PlacaVeiculo { get; set; }

        public int ValorMatricula()
        {
            int matricula = Matricula;
            return matricula;
        }

        public Boolean VerificarVeiculo(Automovel automovel)
        {
            if (automovel.Placa.Length ==  7)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
            return false;
        }
    }
}
