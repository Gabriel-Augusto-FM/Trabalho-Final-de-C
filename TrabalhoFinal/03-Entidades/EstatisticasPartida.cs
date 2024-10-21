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
    public class EstatisticasPartida
    {
        public int IdEstatistica { get; set; }
        public int PartidaId { get; set; }
        public int JogadorId { get; set; }
        public int Pontos { get; set; }
        public int Assistencias { get; set; }
        public int Recepcoes { get; set; }
        public PartidaRepository Partida { get; set; }
        public JogadorRepository Jogador { get; set; }
    }
}
