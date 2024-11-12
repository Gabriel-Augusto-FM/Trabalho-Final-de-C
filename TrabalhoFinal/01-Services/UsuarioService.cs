using Core._03_Entidades.DTO.Usuario;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services
{
    public class UsuarioService
    {
        public readonly IUsuarioRepository repository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            repository = usuarioRepository;
        }
        public void Adicionar(Usuario usuario)
        {
            repository.Adicionar(usuario);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Usuario> Listar()
        {
            return repository.Listar();
        }
        public Usuario BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Usuario editPessoa)
        {
            repository.Editar(editPessoa);
        }
        public Usuario FazerLogin(UsuarioLoginDTO usuarioLogin)
        {
            List<Usuario> listUsuario = Listar();
            foreach (Usuario usuario in listUsuario)
            {
                if (usuario.NomeUsuario == usuarioLogin.Username
                    && usuario.SenhaUsuario == usuarioLogin.Senha)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
