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
    public class Partida
    {
        public int IdPartida { get; set; }
        public DateTime Data { get; set; }
        public int Equipe1Id { get; set; }
        public int Equipe2Id { get; set; }
        public Equipe Equipe1 { get; set; }
        public Equipe Equipe2 { get; set; }
        public List<EstatisticasPartidaRepository> Estatisticas { get; set; }
    }
}
