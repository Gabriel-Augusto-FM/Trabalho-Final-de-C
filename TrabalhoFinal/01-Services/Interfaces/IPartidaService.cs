using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services.Interfaces
{
    public interface IPartidaService
    {
        void Adicionar(Partida partida);
        void Remover(int id);
        void Editar(Partida partida);
        List<Partida> Listar();
    }
}
