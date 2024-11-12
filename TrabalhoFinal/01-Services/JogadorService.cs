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
    public class JogadorService : IJogadorService
    {
        public IJogadorRepository repositorio;

        public JogadorService(IJogadorRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(Jogador jogador)
        {
            repositorio.Adicionar(jogador);
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }

        public void Editar(Jogador jogador)
        {
            repositorio.Editar(jogador);
        }

        public List<Jogador> Listar()
        {
            return repositorio.Listar();
        }
    }
}
