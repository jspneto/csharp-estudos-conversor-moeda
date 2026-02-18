namespace Projeto.Src;

static class Conversor
{
    public static double ImpostoIOF = 6.00;

    public static double ConverterParaReal(double cotacao, double dolar)
    {
        return cotacao * dolar;
    }

    public static double CalcularValorFinal(double real)
    {
        real += real * (ImpostoIOF / 100.0);
        return real;
    }
}