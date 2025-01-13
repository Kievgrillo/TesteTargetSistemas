using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TesteTargetSistemas.Controllers
{
    public class InversaoString
    {
        static void Main(string[] args)
        {
            string texto = "Exemplo de inversão de string";
            string textoInvertido = InverterString(texto);
        }

        static string InverterString(string texto)
        {
            char[] caracteres = new char[texto.Length];
            for (int i = 0, j = texto.Length - 1; i < texto.Length; i++, j--)
            {
                caracteres[i] = texto[j];
            }
            return new string(caracteres);
        }
    }
}
