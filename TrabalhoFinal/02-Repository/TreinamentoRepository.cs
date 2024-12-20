﻿using System;
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
    public class TreinamentoRepository : ITreinamentoRepository
    {
        private readonly string ConnectionString;
        public TreinamentoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Treinamento treinamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Treinamento>(treinamento);
        }

        public void Remover(int IdTreinamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Treinamento treinamento = BuscarPorId(IdTreinamento);
            connection.Delete<Treinamento>(treinamento);
        }
        public void Editar(Treinamento treinamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Treinamento>(treinamento);
        }
        public List<Treinamento> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Treinamento>().ToList();
        }
        public Treinamento BuscarPorId(int IdTreinamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Treinamento>(IdTreinamento);
        }
    }
}
