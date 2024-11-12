using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services.Interfaces
{
    public interface IEquipeService
    {
        void Adicionar(Equipe equipe);
        void Remover(int id);
        void Editar(Equipe equipe);
        List<Equipe> Listar();
    }
}
