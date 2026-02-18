using System.Globalization;
using Projeto.Src;

namespace Projeto;

static class ProgramExamples
{
    public static void SolucaoProblema()
    {
        Console.Write("Entre com a cotação do dólar: R$ ");
        double cotacao = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Entre com o valor em dólar: U$ ");
        double valorDolar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double valorReal = Conversor.ConverterParaReal(cotacao, valorDolar);
        double valorFinal = Conversor.CalcularValorFinal(valorReal);

        Console.WriteLine();
        Console.WriteLine($"Conversão: R$ {valorReal.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor Compra: R$ {valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}