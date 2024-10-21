using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Repository;
using GerenciamentoVolei._04_Repositories;

namespace GerenciamentoVolei._03_Entidades
{
    public class Equipe
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public List<JogadorRepository> Jogadores{ get; set; }
        public TreinadorRepository Treinador { get; set; }
    }   
}
