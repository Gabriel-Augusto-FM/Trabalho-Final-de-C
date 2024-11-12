using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface IEstatisticasPartidaRepository
    {
        void Adicionar(EstatisticasPartida estatistica);
        void Remover(int IdEstistica);
        void Editar(EstatisticasPartida estatistica);
        List<EstatisticasPartida> Listar();
    }
}
