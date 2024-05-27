using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    public CalculadoraImp ConstruirClasse()
    {
        CalculadoraImp _calc = new CalculadoraImp("26/05/2024");

        return _calc;
    }
    
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void SomarTeste(int num1, int num2, int resuldato)
    {
        CalculadoraImp _calc = ConstruirClasse();
        int resuldadoCalc = _calc.Somar(num1, num2);

        Assert.Equal(resuldato,resuldadoCalc);
    }

    [Theory]
    [InlineData (1, 2, -1)]
    [InlineData (5, 4, 1)]
    public void SubtrairTeste(int num1, int num2, int resuldato)
    {
        CalculadoraImp _calc = ConstruirClasse();
        int resuldadoCalc = _calc.Subtrair(num1, num2);

        Assert.Equal(resuldato,resuldadoCalc);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void MultiplicarTeste(int num1, int num2, int resuldato)
    {
        CalculadoraImp _calc = ConstruirClasse();
        int resuldadoCalc = _calc.Multiplicar(num1, num2);

        Assert.Equal(resuldato,resuldadoCalc);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    [InlineData (8, 2, 4)]
    public void DividirTeste(int num1, int num2, float resuldato)
    {
        CalculadoraImp _calc = ConstruirClasse();
        int resuldadoCalc = _calc.Dividir(num1, num2);

        Assert.Equal(resuldato,resuldadoCalc);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraImp _calc = ConstruirClasse();
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void HistoricoTestar()
    {
        CalculadoraImp _calc = ConstruirClasse();
        _calc.Somar(1, 2);
        _calc.Somar(2, 8);
        _calc.Somar(3, 7);
        _calc.Somar(4, 1);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}