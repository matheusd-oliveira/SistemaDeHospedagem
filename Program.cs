using System;
using System.Text;
using System.Collections.Generic;
using SistemaDeHospedagem.Entities;
using SistemaDeHospedagem.BackEnd.Entities;
using SistemaDeHospedagem.UI;

namespace SistemaDeHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            Tela tela = new Tela();
            tela.TelaInicial();

            MenuSuite menu = new MenuSuite();
            menu.Menu();

            // Cria a suíte
            Suite suite = new Suite();

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 9);
            reserva.CadastrarSuite(suite);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        }
    }
}
