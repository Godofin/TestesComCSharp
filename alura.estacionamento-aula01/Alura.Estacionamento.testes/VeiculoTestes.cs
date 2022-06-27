using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arrange - Prepara cenario
            var veiculo = new Veiculo();
            //Act -  O que eu quero testar
            veiculo.Acelerar(10);
            //Assert - O resultado do teste
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            var veiculo = new Veiculo();
            veiculo.Frear(10);
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}
