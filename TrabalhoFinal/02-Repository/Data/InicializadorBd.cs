﻿using System;
using System.Data.SQLite;

namespace GerenciamentoVolei._02_Repository.Data
{
    public static class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Volei.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string commandoSQL = @"
                    CREATE TABLE IF NOT EXISTS Equipes(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Jogadors(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Posicao TEXT NOT NULL,
                        EquipeId INTEGER,
                        FOREIGN KEY (EquipeId) REFERENCES Equipe(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Treinadors(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        EquipeId INTEGER,
                        FOREIGN KEY (EquipeId) REFERENCES Equipe(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Partidas(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Data DATETIME NOT NULL,
                        Equipe1Id INTEGER,
                        Equipe2Id INTEGER,
                        FOREIGN KEY (Equipe1Id) REFERENCES Equipe(Id),
                        FOREIGN KEY (Equipe2Id) REFERENCES Equipe(Id)
                    );

                    CREATE TABLE IF NOT EXISTS EstatisticasPartidas(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        PartidaId INTEGER,
                        JogadorId INTEGER,
                        Pontos INTEGER,
                        Assistencias INTEGER,
                        Receptacoes INTEGER,
                        FOREIGN KEY (PartidaId) REFERENCES Partida(Id),
                        FOREIGN KEY (JogadorId) REFERENCES Jogador(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Treinamentos(
                        IdTreinamento INTEGER PRIMARY KEY AUTOINCREMENT,
                        Data TEXT NOT NULL,
                        Descricao TEXT
                    );

                    CREATE TABLE IF NOT EXISTS Presencas(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        TreinamentoId INTEGER,
                        JogadorId INTEGER,
                        Presente BOOLEAN NOT NULL,
                        FOREIGN KEY (TreinamentoId) REFERENCES Treinamento(Id),
                        FOREIGN KEY (JogadorId) REFERENCES Jogador(Id)
                    );
                ";

                using (var command = new SQLiteCommand(commandoSQL, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
