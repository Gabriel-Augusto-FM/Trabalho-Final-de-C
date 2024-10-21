﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using GerenciamentoVolei._03_Entidades;

namespace GerenciamentoVolei._03_Repository
{
    public class EquipeRepository
    {
        private readonly string ConnectionString;
        public EquipeRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }

        public void Adicionar(Equipe equipe)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Equipe>(equipe);
        }

        public void Remover(int IdEquipe)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Equipe equipe = BuscarPorId(IdEquipe);
            connection.Delete<Equipe>(equipe);
        }
        public void Editar(Equipe equipe)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Equipe>(equipe);
        }
        public List<Equipe> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Equipe>().ToList();
        }
        public Equipe BuscarPorId(int IdEquipe)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Equipe>(IdEquipe);
        }

    }
}