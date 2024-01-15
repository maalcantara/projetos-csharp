using calculadora.services;

namespace calculadora_testes

public class calculadora_testes
{
  private CalculadoraImp _calc;

  public calculadora_testes()
  {
    _calc = new CalculadoraImp();
  }

  [Fact]
  public void Somar5com10eRetornar15()
  {
    // Arrange 
    int num1 = 5;
    int num2 = 10;

    // Act
    int resutado = _calc.Somar(num1, num2);

    // Assert
    Assert.Equal(15, resultado);
  }

  [Fact]
  public void Somar10com10eRetonar20()
  {
    // Arrange 
    int num1 = 10;
    int num2 = 10;

    // Act
    int resultado = _calc.Somar(num1, num2);

    // Assert
    Assert.Equal(20, resultado);
  }
}