using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface ITreinamentoRepository
    {
        void Adicionar(Treinamento treinamento);
        void Remover(int idTreinamento);
        void Editar(Treinamento treinamento);
        List<Treinamento> Listar();
        Treinamento BuscarPorId(int IdEstistica);
    }
}
