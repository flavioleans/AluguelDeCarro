using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AluguelCarroTeste
{
    
   public class Enderecos
    {
        [Fact]
        public void Inserir()
        {
            var mock = new Mock<IEnderecoRepositorio>();
            mock.Setup(e => e.Inserir(It.IsAny<Endereco>()));

            Endereco endereco = new Endereco
            {
                EnderecoId = 1,
                Rua = "ABC",
                Numero = 31,
                Bairro = "Rua Brasil",
                Cidade = "São Paulo",
                Estado = "SP"
            };
            mock.Object.Inserir(endereco);
            //verifica se motodo foi executado pelo menos uma vez
            mock.Verify(e => e.Inserir(It.IsAny<Endereco>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Atualizar()
        {
            var mock = new Mock<IEnderecoRepositorio>();
            mock.Setup(e => e.Atualizar(It.IsAny<Endereco>()));

            Endereco endereco = new Endereco
            {
                EnderecoId = 1,
                Rua = "ABC",
                Numero = 31,
                Bairro = "Rua Brasil",
                Cidade = "São Paulo",
                Estado = "SP"
            };
            mock.Object.Atualizar(endereco);
            //verifica se motodo foi chamado uma vez
            mock.Verify(e => e.Atualizar(It.IsAny<Endereco>()), Times.AtLeast(1));
        }

        [Fact]
        public void Excluir()
        {
            var mock = new Mock<IEnderecoRepositorio>();
            mock.Setup(e => e.Excluir(It.IsAny<int>()));
            mock.Object.Excluir(2);
            //verifica se motodo foi executado pelo menos uma vez
            mock.Verify(e => e.Excluir(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void PegarPeloId()
        {
            var mock = new Mock<IEnderecoRepositorio>();
            mock.Setup(e => e.PegarPeloId(It.IsAny<int>()));
            mock.Object.PegarPeloId(1);
            mock.Object.PegarPeloId(2);
            mock.Object.PegarPeloId(3);
            mock.Object.PegarPeloId(4);

            mock.Verify(e => e.PegarPeloId(It.IsAny<int>()), Times.AtLeastOnce);
        }

        [Fact]
        public void PegarTodos()
        {
            var mock = new Mock<IEnderecoRepositorio>();
            mock.Setup(e => e.PegarTodos());
            var enderecos = mock.Object.PegarTodos();
            IQueryable<Endereco> end = null;

            Assert.Equal<Endereco>(end, enderecos);
        }
    }
}
