using GerenciamentoVolei._03_Entidades;
using GerenciamentoVolei._03_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei
{
    public class SimuladorBD
    {
        public List<EquipeRepository> Times { get; set; }
        public SimuladorBD()
        {
            Times = new List<EquipeRepository>();

        }
    }
}
