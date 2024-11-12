using Dapper.Contrib.Extensions;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string ConnectionString;
        public UsuarioRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Usuario usuario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Usuario>(usuario);
        }

        public void Remover(int IdUsuario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Usuario usuario = BuscarPorId(IdUsuario);
            connection.Delete<Usuario>(usuario);
        }
        public void Editar(Usuario usuario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Usuario>(usuario);
        }
        public List<Usuario> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Usuario>().ToList();
        }
        public Usuario BuscarPorId(int IdUsuario)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Usuario>(IdUsuario);
        }
    }
}
