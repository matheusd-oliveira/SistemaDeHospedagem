using SistemaDeHospedagem.BackEnd.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem.BackEnd.Entities
{
     class Suite
    {

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public Suite(int capacidade, decimal valorDiaria)
        {
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
