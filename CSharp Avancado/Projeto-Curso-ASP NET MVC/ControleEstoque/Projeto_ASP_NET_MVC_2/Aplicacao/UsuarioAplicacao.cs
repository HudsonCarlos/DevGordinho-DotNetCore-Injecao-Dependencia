using Dominio;
using Dominio.contrato;
using System.Collections.Generic;
using System;

namespace Aplicacao
{
    public class UsuarioAplicacao : IRepositorio<Usuario>
    {
        private readonly IRepositorio<Usuario> repositorio;

        public UsuarioAplicacao(IRepositorio<Usuario> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Usuario aluno)
        {
            repositorio.Salvar(aluno);
        }

        public void Excluir(Usuario aluno)
        {
            repositorio.Excluir(aluno);
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Usuario ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public bool ValidarPorAtor(Usuario usuario)
        {
            return repositorio.ValidarPorAtor(usuario);
        }
    }
}

