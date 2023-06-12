using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicos
{
    [ApiController]
    public class AgendaController : ControllerBase
    {

        List<Contato> contatos = new List<Contato>();

        public AgendaController()
        {
            contatos.Add(new Contato { Id = 1, Email = "contatinho@gmail.com", Nome = "Contatinho", NumeroTelefone = "(12) 21121-2313" });
        }

        [HttpGet]
        [Route("obterTodosContatos")]
        public List<Contato> ObterTodosContatos()
        {
            return contatos;
        }

        [HttpPost]
        [Route("adicionarContato")]
        public List<Contato> AdicionarContato(Contato contato)
        {
            contatos.Add(contato);

            return contatos;
        }

        [HttpPut]
        [Route("atualizarContato")]
        public List<Contato> AtualizarContato(int id, Contato contatoAtualizado)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);
            if (contato != null)
            {
                contato.Nome = contatoAtualizado.Nome;
                contato.NumeroTelefone = contatoAtualizado.NumeroTelefone;
                contato.Email = contatoAtualizado.Email;
            }

            return contatos;
        }

        [HttpPatch]
        [Route("atualizarParcialmenteContato")]
        public List<Contato> AtualizarParcialmenteContato(int id, Contato contatoAtualizado)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);
            if (contato != null)
            {
                if (!string.IsNullOrEmpty(contatoAtualizado.Nome))
                {
                    contato.Nome = contatoAtualizado.Nome;
                }

                if (!string.IsNullOrEmpty(contatoAtualizado.NumeroTelefone))
                {
                    contato.NumeroTelefone = contatoAtualizado.NumeroTelefone;
                }

                if (!string.IsNullOrEmpty(contatoAtualizado.Email))
                {
                    contato.Email = contatoAtualizado.Email;
                }
            }

            return contatos;
        }

        [HttpDelete]
        [Route("excluirContato")]
        public List<Contato> ExcluirContato(int id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);
            if (contato != null)
            {
                contatos.Remove(contato);
            }

            return contatos;
        }
    }

    public class Contato
    {
        public int Id { set; get; }

        public String Nome { set; get; }

        public String Email { set; get; }

        public String NumeroTelefone { set; get; }
    }
}
