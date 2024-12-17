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
    public class EstatisticasPartidaService : IEstatisticasPartidaService
    {

        public IEstatisticasPartidaRepository repositorio;

        public EstatisticasPartidaService(IEstatisticasPartidaRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(EstatisticasPartida estatistica)
        {
            repositorio.Adicionar(estatistica);
        }

        public void Remover(int id)
        {
            repositorio.Remover(id);
        }
        public void Editar(EstatisticasPartida estatistica)
        {
            repositorio.Editar(estatistica);
        }

        public List<EstatisticasPartida> Listar()
        {
            return repositorio.Listar();
        }

        public void Editar(Partida e)
        {
            throw new NotImplementedException();
        }
    }
}
