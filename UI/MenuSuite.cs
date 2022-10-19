using SistemaDeHospedagem.BackEnd.Entities;
using SistemaDeHospedagem.BackEnd.Entities.Enums;
using SistemaDeHospedagem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem.UI
{
    public class MenuSuite
    {

        public void Menu()
        {
            Console.WriteLine("Por favor, escolha uma suite para os hóspedes se alocarem: ");
            Console.WriteLine("CODIGO  SUITE       CAPACIDADE      PREÇO      ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 -      COMUM     -    2    - R$ 20.00");
            Console.WriteLine("2 -      PREMIUM   -    4     - R$ 40.00");
            Console.WriteLine("3 -      MASTER    -    6     - R$ 60.00");
            Console.WriteLine("------------------------------");


            TiposSuite tipoSuite = Enum.Parse<TiposSuite>(Console.ReadLine());
           
            Console.WriteLine($"Parabéns! Os hóspedes foram designados para a Suíte {tipoSuite}");

           
        }
    }
}
