using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface ITreinadorRepository
    {
        void Adicionar(Treinador treinador);
        void Remover(int idTreinador);
        void Editar(Treinador treinador);
        List<Treinador> Listar();
        Treinador BuscarPorId(int IdEstistica);
    }
}
