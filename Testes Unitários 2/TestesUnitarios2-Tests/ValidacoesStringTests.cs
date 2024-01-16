using TestesUnitarios2.Services;

namespace TestesUnitarios2Tests;

public class ValidacoesStringTests
{
  private ValidacoesString _validacoes = new ValidacoesString();

  [Fact]
  public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
  {
    // arrange 
    var texto = "Matrix";
    var resultadoEsperado = 6;

    // act
    var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

    // assert
    Assert.Equal(resultadoEsperado, resultado);
  }

  [Fact]
  public void DeveConterAPalavraQualquerNoTexto()
  {
    // arrange 
    var texto = "Esse é um texto qualquer";
    var textoProcurado = "qualquer";

    // act
    var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

    // assert
    Assert.True(resultado);
  }

  [Fact]
  public void NaoDeveConterAPalavraTesteNoTexto()
  {
    var texto = "Esse é um texto qualquer";
    var textoProcurado = "teste";

    var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

    Assert.False(resultado);
  }

  [Fact]
  public void TextoDeveTerminarComAPalavraProcurado()
  {
    var texto = "Começo, meio e fim do texto procurado";
    var textoProcurado = "procurado";

    var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

    Assert.True(resultado);
  }
}