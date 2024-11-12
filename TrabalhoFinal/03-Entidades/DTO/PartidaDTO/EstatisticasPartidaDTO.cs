using GerenciamentoVolei._03_Repository;
using GerenciamentoVolei._04_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._03_Entidades.DTO
{
    public class EstatisticasPartidaDTO
    {
        public int Pontos { get; set; }
        public JogadorRepository Jogador { get; set; }
        public PartidaRepository Partida { get; set; }
    }
}
