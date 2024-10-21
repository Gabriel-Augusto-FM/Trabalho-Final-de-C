using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Entidades;
using System.Data.SQLite;
using Dapper.Contrib.Extensions;

namespace GerenciamentoVolei._03_Repository
{
    public class EstatisticasPartidaRepository
    {
        private readonly string ConnectionString;
        public EstatisticasPartidaRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }

        public void Adicionar(EstatisticasPartida estatistica)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<EstatisticasPartida>(estatistica);
        }

        public void Remover(int IdEstistica)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            EstatisticasPartida estatistica = BuscarPorId(IdEstistica);
            connection.Delete<EstatisticasPartida>(estatistica);
        }
        public void Editar(EstatisticasPartida estatistica)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<EstatisticasPartida>(estatistica);
        }
        public List<EstatisticasPartida> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<EstatisticasPartida>().ToList();
        }
        public EstatisticasPartida BuscarPorId(int IdEstistica)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<EstatisticasPartida>(IdEstistica);
        }
    }
}
