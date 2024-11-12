using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services.Interfaces
{
    public interface IPresencaService
    {
        void Adicionar(Presenca presenca);
        void Remover(int id);
        void Editar(Presenca presenca);
        List<Presenca> Listar();
    }
}
