using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._03_Entidades.DTO.PartidaDTO
{
    public class PartidaDTO
    {
        public DateTime Data { get; set; }
        public Equipe Equipe1 { get; set; }
        public Equipe Equipe2 { get; set; }
    }
}
