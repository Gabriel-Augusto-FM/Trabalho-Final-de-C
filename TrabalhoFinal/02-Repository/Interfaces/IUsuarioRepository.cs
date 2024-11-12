using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._02_Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Remover(int IdUsuario);
        void Editar(Usuario usuario);
        List<Usuario> Listar();
        Usuario BuscarPorId(int IdUsuario);
    }
}
