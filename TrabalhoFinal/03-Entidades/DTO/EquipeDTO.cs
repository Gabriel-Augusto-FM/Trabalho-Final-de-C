using GerenciamentoVolei._03_Repository;
using GerenciamentoVolei._04_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._03_Entidades.DTO
{
    public class EquipeDTO
    {
        public string Nome { get; set; }
        public List<JogadorRepository> Jogadores { get; set; }
        public TreinadorRepository Treinador { get; set; }
    }
}
