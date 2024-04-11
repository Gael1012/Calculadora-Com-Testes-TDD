using Calc;

namespace test;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(7, 3, 10)]
    public void testeSomar(int a, int b, int resultado)
    {
        Calculadoras calcu= new Calculadoras();

        int resultadoCalculadora = calcu.somar(a, b);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(7, 3, 4)]
    public void testeSubtrair(int a, int b, int resultado)
    {
        Calculadoras calcu= new Calculadoras();

        int resultadoCalculadora = calcu.subtrair(a, b);

        Assert.Equal(resultadoCalculadora, resultado);
    }
    [Theory]
    [InlineData(3, 5, 15)]
    [InlineData(7, 3, 21)]
    public void testeMultiplicar(int a, int b, int resultado)
    {
        Calculadoras calcu= new Calculadoras();

        int resultadoCalculadora = calcu.multiplicar(a, b);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData(10, 5, 2)]
    [InlineData(8, 2, 4)]
    public void testeDividir(int a, int b, int resultado)
    {
        Calculadoras calcu= new Calculadoras();

        int resultadoCalculadora = calcu.dividir(a, b);

        Assert.Equal(resultadoCalculadora, resultado);
    }
    
    [Fact]
    public void TesteHistorico()
    {
        Calculadoras calcu= new Calculadoras();
        calcu.somar(3, 6);
        calcu.somar(2, 6);
        calcu.somar(1, 6);
        
        var lista = calcu.historico();

        Assert.NotEmpty(calcu.historico());
        Assert.Equal(3, lista.Count());
    }
}