using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using GerenciamentoVolei._03_Repository;

namespace GerenciamentoVolei._03_Entidades
{
    public class Treinamento
    {
        public int IdTreinamento { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public List<PresencaRepository> Presencas { get; set; }
    }
}
