using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Repository;

namespace GerenciamentoVolei._03_Entidades
{
    public class Presenca
    {
        public int IdPresenca { get; set; }
        public int TreinamentoId { get; set; }
        public int JogadorId { get; set; }
        public bool Presente { get; set; }
        public Treinamento Treinamento { get; set; } 
        public Jogador Jogador { get; set; }
    }
}
