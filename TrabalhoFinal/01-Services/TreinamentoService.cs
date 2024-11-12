using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using GerenciamentoVolei._03_Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services
{
    public class TreinamentoService : ITreinamentoService
    {

        public ITreinamentoRepository repositorio;

        public TreinamentoService(ITreinamentoRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(Treinamento treinamento)
        {
            repositorio.Adicionar(treinamento);
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }

        public void Editar(Treinamento treinamento)
        {
            repositorio.Editar(treinamento);
        }

        public List<Treinamento> Listar()
        {
            return repositorio.Listar();
        }
    }
}
