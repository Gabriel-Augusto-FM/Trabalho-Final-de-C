using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Entidades;
using System.Data.SQLite;
using Dapper.Contrib.Extensions;
using GerenciamentoVolei._02_Repository.Interfaces;
using Microsoft.Extensions.Configuration;

namespace GerenciamentoVolei._03_Repository
{
    public class PresencaRepository : IPresencaRepository
    {
        private readonly string ConnectionString;
        public PresencaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Presenca presenca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Presenca>(presenca);
        }

        public void Remover(int IdPresenca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Presenca presenca = BuscarPorId(IdPresenca);
            connection.Delete<Presenca>(presenca);
        }
        public void Editar(Presenca presenca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Presenca>(presenca);
        }
        public List<Presenca> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Presenca>().ToList();
        }
        public Presenca BuscarPorId(int IdPresenca)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Presenca>(IdPresenca);
        }
    }
}
