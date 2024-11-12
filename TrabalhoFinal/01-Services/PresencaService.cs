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
    public class PresencaService : IPresencaService
    {
        public IPresencaRepository repositorio;

        public PresencaService(IPresencaRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(Presenca presenca)
        {
            repositorio.Adicionar(presenca);
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }

        public void Editar(Presenca presenca)
        {
            repositorio.Editar(presenca);
        }

        public List<Presenca> Listar()
        {
            return repositorio.Listar();
        }
    }
}
