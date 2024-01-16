using TestesUnitarios2.Services;

namespace TestesUnitarios2Tests;

public class ValidacoesListaTests
{
  private ValidacoesLista _validacoes = new ValidacoesLista();

  [Fact]
  public void DeveRemoverNumerosNegativosDaLista()
  {
    // Arrange
    var lista = new List<int> { 5, -1, -8, 9 };
    var resultadoEsperado = new List<int> { 5, 9 };

    // Act
    var resultado = _validacoes.RemoverNumerosNeativos(lista);

    // Assert
    Assert.Equal(resultadoEsperado, resultado);
  }

  [Fact]
  public void DeveConterONumero9NaLista()
  {
    // Arrange
    var lista = new List<int> { 5, -1, -8, 9};
    var numeroParaProcurar = 9;

    // Act
    var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

    // Assert
    Assert.True(resultado);
  }

  [Fact]
  public void NaoDeveConterONumero10NaLista()
  {
    // arrange
    var lista = new List<int> { 5, -1, -8, 9 };
    var numeroParaProcurar = 10;

    // act
    bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

    // Assert
    Assert.False(resultado);
  }

  [Fact]
  public void DeveMultiplicarOsElementosDaListaPor2()
  {
    // Arrange
    var lista = new List<int> { 5, 7, 8, 9 };
    var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
    var numeroMultiplicacao = 2;

    // Act
    var resultado = _validacoes.MultiplicarNumerosLista(lista, numeroMultiplicacao);

    // Assert
    Assert.Equal(resultadoEsperado, resultado);
  }

  [Fact]
  public void DeveRetornar9ComoMaiorNumeroDaLista()
  {
    // arrange
    var lista = new List<int> { 5, -1, -8, 9 };

    // act
    var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

    // assert
    Assert.Equal(9, resultado);
  }

  [Fact]
  public void DeveRetornarMenos8ComoMenorNumeroDaLista()
  {
    // arrange 
    var lista = new List<int> { 5, -1, -8, 9 };

    // act 
    var resultado = _validacoes.RetornarMenorNumeroLista(lista);

    // assert
    Assert.Equal(-8, resultado);
  }
}