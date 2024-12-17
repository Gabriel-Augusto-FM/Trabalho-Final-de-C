using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using GerenciamentoVolei._03_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services
{
    public class TreinadorService : ITreinadorService
    {
        public ITreinadorRepository repositorio;

        public TreinadorService(ITreinadorRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(Treinador treinador)
        {
            repositorio.Adicionar(treinador);
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }

        public void Editar(Treinador treinador)
        {
            repositorio.Editar(treinador);
        }

        public List<Treinador> Listar()
        {
            return repositorio.Listar();
        }

        
    }
}
