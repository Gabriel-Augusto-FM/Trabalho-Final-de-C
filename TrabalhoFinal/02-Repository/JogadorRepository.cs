using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.Extensions.Configuration;

namespace GerenciamentoVolei._04_Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly string ConnectionString;
        public JogadorRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Jogador jogador)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Jogador>(jogador);
        }

        public void Remover(int IdJogador)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Jogador jogador = BuscarPorId(IdJogador);
            connection.Delete<Jogador>(jogador);
        }
        public void Editar(Jogador jogador)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Jogador>(jogador);
        }
        public List<Jogador> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Jogador>().ToList();
        }
        public Jogador BuscarPorId(int IdJogador)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Jogador>(IdJogador);
        }
    }
}
