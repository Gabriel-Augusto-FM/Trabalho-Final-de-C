using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface IPresencaRepository
    {
        void Adicionar(Presenca presenca);
        void Remover(int idPresenca);
        void Editar(Presenca presenca);
        List<Presenca> Listar();
        Presenca BuscarPorId(int IdEstistica);
    }
}
