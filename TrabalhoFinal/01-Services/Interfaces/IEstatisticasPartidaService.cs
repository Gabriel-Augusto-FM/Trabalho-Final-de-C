using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services.Interfaces
{
    public interface IEstatisticasPartidaService
    {
        void Adicionar(EstatisticasPartida estatistica);
        void Remover(int id);
        void Editar(EstatisticasPartida estatistica);
        List<EstatisticasPartida> Listar();
        void Editar(Partida e);
    }
}
