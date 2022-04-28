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
    public class Carros
    {
        [Fact]
        public void Inserir()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(e => e.Inserir(It.IsAny<Carro>()));

            Carro carro = new Carro
            {
                CarroId = 1,
                Marca = "ABC",
                Nome = "Carrão",
                Foto = "Rua Brasil",
                PrecoDiaria = 50
            };
            mock.Object.Inserir(carro);
            //verifica se motodo foi executado pelo menos uma vez
            mock.Verify(e => e.Inserir(It.IsAny<Carro>()), Times.AtLeastOnce);
        }

        [Fact]
        public void Atualizar()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(e => e.Atualizar(It.IsAny<Carro>()));

            Carro carro = new Carro
            {
                CarroId = 1,
                Marca = "ABC",
                Nome = "Carrão",
                Foto = "Rua Brasil",
                PrecoDiaria = 50
            };
            mock.Object.Atualizar(carro);
            //verifica se motodo foi chamado uma vez
            mock.Verify(e => e.Atualizar(It.IsAny<Carro>()), Times.AtLeast(1));
        }

        [Fact]
        public void Excluir()
        {
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(e => e.Excluir(It.IsAny<int>()));
            mock.Object.Excluir(2);
            //verifica se motodo foi executado pelo menos uma vez
            mock.Verify(e => e.Excluir(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void PegarPeloId()
        {
            var mock = new Mock<ICarroRepositorio>();
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
            var mock = new Mock<ICarroRepositorio>();
            mock.Setup(e => e.PegarTodos());
            var carros = mock.Object.PegarTodos();
            IQueryable<Carro> c = null;

            Assert.Equal<Carro>(c, carros);
        }

    }
}
