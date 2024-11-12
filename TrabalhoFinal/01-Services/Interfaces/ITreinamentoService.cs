using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services.Interfaces
{
    public interface ITreinamentoService
    {
        void Adicionar(Treinamento treinamento);
        void Remover(int id);
        void Editar(Treinamento treinamento);
        List<Treinamento> Listar();
    }
}
