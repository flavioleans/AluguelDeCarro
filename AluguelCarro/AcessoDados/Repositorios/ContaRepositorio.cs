using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.AcessoDados.Repositorios
{
    public class ContaRepositorio : RepositorioGenerico<Conta>, IContaRepositorio
    {
        private readonly Contexto _contexto;
        public ContaRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public int PegarSaldoPeloId(string id)
        {
            return _contexto.Contas.FirstOrDefault(c => c.UsuarioId == id).Saldo;
        }

        public async Task<Conta> PegarSaldoPeloUsuarioId(string id)
        {
            return await _contexto.Contas.FirstOrDefaultAsync(c => c.UsuarioId == id);
        }

        public new async Task<IEnumerable<Conta>> PegarTodos()
        {
            return await _contexto.Contas.Include(c => c.Usuario).ToListAsync();
        }

    }
}
