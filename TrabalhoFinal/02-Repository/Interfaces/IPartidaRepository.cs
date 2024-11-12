using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface IPartidaRepository
    {
        void Adicionar(Partida partida);
        void Remover(int idPartida);
        void Editar(Partida partida);
        List<Partida> Listar();
        Partida BuscarPorId(int IdEstistica);
    }
}
