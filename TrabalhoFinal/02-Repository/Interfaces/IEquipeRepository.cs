using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface IEquipeRepository
    {
        void Adicionar(Equipe equipe);
        void Remover(int IdEquipe);
        void Editar(Equipe equipe);
        List<Equipe> Listar();
        Equipe BuscarPorId(int IdEquipe);
    }
}
