using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace FaturamentoDistribuidora
{
    class Program
    {
        class Faturamento
        {
            public int Dia { get; set; }
            public double Valor { get; set; }
        }

        static void Main(string[] args)
        {
            // Carregando o JSON de um arquivo externo
            string filePath = "faturamento.json"; // Substitua pelo caminho correto do arquivo
            string json = File.ReadAllText(filePath);

            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

           
            var diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

            double menorValor = diasComFaturamento.Min(f => f.Valor);
            double maiorValor = diasComFaturamento.Max(f => f.Valor);

            double mediaMensal = diasComFaturamento.Average(f => f.Valor);

            int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

            string resultadoMenor = ObterResultadoMenor(menorValor);
            string resultadoMaior = ObterResultadoMaior(maiorValor);
            string resultadoDias = ObterResultadoDias(diasAcimaDaMedia);

        }

        static string ObterResultadoMenor(double menorValor)
        {
            return $"Menor valor de faturamento: {menorValor:F2}";
        }

        static string ObterResultadoMaior(double maiorValor)
        {
            return $"Maior valor de faturamento: {maiorValor:F2}";
        }

        static string ObterResultadoDias(int diasAcimaDaMedia)
        {
            return $"Número de dias com faturamento acima da média: {diasAcimaDaMedia}";
        }
    }
}
