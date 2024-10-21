using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Entidades;
using System.Data.SQLite;
using Dapper.Contrib.Extensions;

namespace GerenciamentoVolei._03_Repository
{
    public class PartidaRepository
    {
        private readonly string ConnectionString;
        public PartidaRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }

        public void Adicionar(Partida partida)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Partida>(partida);
        }

        public void Remover(int IdPartida)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Partida partida = BuscarPorId(IdPartida);
            connection.Delete<Partida> (partida);
        }
        public void Editar(Partida partida)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Partida>(partida);
        }
        public List<Partida> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Partida>().ToList();
        }
        public Partida BuscarPorId(int IdPartida)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Partida>(IdPartida);
        }
    }
}
