using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace GerenciamentoVolei._03_Entidades
{
    public class Treinador
    {
        public int IdTreinador { get; set; }
        public string Nome { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }
    }
}