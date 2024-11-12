using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using GerenciamentoVolei._03_Repository;
using GerenciamentoVolei._04_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services
{
    public class PartidaService : IPartidaService
    {
        public IPartidaRepository repositorio;

        public PartidaService(IPartidaRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(Partida partida)
        {
            repositorio.Adicionar(partida);
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }

        public void Editar(Partida partida)
        {
            repositorio.Editar(partida);
        }

        public List<Partida> Listar()
        {
            return repositorio.Listar();
        }
    }
}
