using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TesteTargetSistemas.Controllers
{
    public class FaturamentoMensal
    {
        static void Main(string[] args)
        {
            var faturamentoEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double faturamentoTotal = faturamentoEstado.Values.Sum();

            foreach (var estado in faturamentoEstado)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                string resultado = PercentualEstado(estado.Key, percentual);
            }
        }

        static string PercentualEstado(string estado, double percentual)
        {
            return $"Estado: {estado}, Percentual: {percentual:F2}%";
        }
    }
}
