using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroducaoAPI.Context;
using IntroducaoAPI.Entities;

namespace IntroducaoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost] // método pra enviar informações
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        // endpoint obter por ID -> SELECT
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
                return NotFound();

            return Ok(contato);
        }
        // incrementar o get -> OBTER todos os contatos
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains{ nome});
            return Ok(contatos);
        }

        // endpoint de UPDATE
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, ContatoController contato)
        {
            var contatoBanco = _context.Contatos.Finf(id);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        // endpoint de DELETE
        [HttpDelete("{id}")]
        public IActionResult Deletar(ind id)
        {
            var contatoBanco = _context.Contatos.Find(id)

            if (contatoBanco == null)
                return NotFund();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return NoContenet();
        }
    }
}