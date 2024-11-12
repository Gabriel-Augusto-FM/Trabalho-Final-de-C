using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface IJogadorRepository
    {
        void Adicionar(Jogador jogador);
        void Remover(int IdJogador);
        void Editar(Jogador jogador);
        List<Jogador> Listar();
        Jogador BuscarPorId(int IdJogador);
    }
}
