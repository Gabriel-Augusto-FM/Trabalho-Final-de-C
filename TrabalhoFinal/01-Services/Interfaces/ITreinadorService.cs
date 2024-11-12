using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services.Interfaces
{
    public interface ITreinadorService
    {
        void Adicionar(Treinador treinador);
        void Remover(int id);
        void Editar(Treinador treinador);
        List<Treinador> Listar();
    }
}
