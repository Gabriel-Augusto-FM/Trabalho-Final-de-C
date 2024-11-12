using GerenciamentoVolei._01_Services.Interfaces;
using GerenciamentoVolei._02_Repository.Interfaces;
using GerenciamentoVolei._03_Entidades;
using GerenciamentoVolei._03_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoVolei._01_Services;

public class EquipeService : IEquipeService
{
    public IEquipeRepository repositorio;

    public EquipeService(IEquipeRepository repositorio)
    {
        this.repositorio = repositorio;
    }

    public void Adicionar(Equipe equipe)
    {
        repositorio.Adicionar(equipe);
    }

    public void Remover(int id)
    {
        repositorio.Remover(id);
    }

    public void Editar(Equipe equipe)
    {
        repositorio.Editar(equipe);
    }

    public List<Equipe> Listar()
    {
        return repositorio.Listar();
    }

}

