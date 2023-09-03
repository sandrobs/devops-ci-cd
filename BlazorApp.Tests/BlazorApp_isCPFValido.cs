using BlazorApp;
using NUnit.Framework;

namespace BlazorApp.Tests.Services
{
    [TestFixture]
    public class ValidacoesTests
    {
        private BlazorApp.Validacoes _validacoes;

        [SetUp]
        public void SetUp()
        {
            _validacoes = new Validacoes();
        }

        [Test]
        public void ValidaCPF_CPFValido_RetornaTrue()
        {
            // Arrangedot
            string cpf = "12345678909";

            // Act
            bool result = BlazorApp.Validacoes.ValidaCPF(cpf);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidaCPF_CPFInvalido_RetornaFalse()
        {
            // Arrange
            string cpf = "12345678901";

            // Act
            bool result = BlazorApp.Validacoes.ValidaCPF(cpf);

            // Assert
            Assert.IsFalse(result);
        }
    }
}