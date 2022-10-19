using SistemaDeHospedagem.BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem.Entities
{
     class Reserva
    {

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;
            else
                throw new Exception("Suite não comporta essa quantidade de hóspedes!");
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valor = valor - (valor * 10) / 100 ;

            return valor;

        }


    }
}
