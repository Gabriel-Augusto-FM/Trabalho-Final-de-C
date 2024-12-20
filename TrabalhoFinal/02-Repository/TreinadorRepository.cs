﻿using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Entidades;
using System.Data.SQLite;
using Dapper.Contrib.Extensions;
using GerenciamentoVolei._02_Repository.Interfaces;
using Microsoft.Extensions.Configuration;

namespace GerenciamentoVolei._03_Repository
{
        public class TreinadorRepository : ITreinadorRepository
        {
            private readonly string ConnectionString;
            public TreinadorRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

            public void Adicionar(Treinador treinador)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<Treinador>(treinador);
            }

            public void Remover(int IdTreinador)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                Treinador treinador = BuscarPorId(IdTreinador);
                connection.Delete<Treinador>(treinador);
            }
            public void Editar(Treinador treinador)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<Treinador>(treinador);
            }
            public List<Treinador> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<Treinador>().ToList();
            }
            public Treinador BuscarPorId(int IdTreinador)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<Treinador>(IdTreinador);
            }
        }
}