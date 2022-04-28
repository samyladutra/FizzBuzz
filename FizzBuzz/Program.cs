using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[100];
            for (int i = 0; i < 100; i++)
                array[i] = i + 1;

            var valores = FizzBuzz(array);
            foreach (var valor in valores)
                Console.WriteLine(valor);
        }


        private static List<string> FizzBuzz(int[] listaInteiros)
        {
            List<string> valores = new List<string>();

            for (int i = 0; i < listaInteiros.Length; i++)
            {
                valores.Add(new DivisibilidadePor3().VerificaDivisibilidade(listaInteiros[i]));
                valores.Add(new DivisibilidadePor5().VerificaDivisibilidade(listaInteiros[i]));
                valores.Add(new DivisibilidadePor3E5().VerificaDivisibilidade(listaInteiros[i]));
                valores.Add(new DivisibilidadePor7().VerificaDivisibilidade(listaInteiros[i]));
            }

            return valores.Distinct().ToList();
        }

        public class DivisibilidadePor3 : IDivisibilidade
        {
            public string VerificaDivisibilidade(int valor)
            {
                if (valor % 3 == 0)
                    return valor + " - fizz";
                else
                    return valor.ToString();
            }
        }

        public class DivisibilidadePor5 : IDivisibilidade
        {
            public string VerificaDivisibilidade(int valor)
            {
                if (valor % 5 == 0)
                    return valor + " - buzz";
                else
                    return valor.ToString();
            }
        }

        public class DivisibilidadePor3E5 : IDivisibilidade
        {
            public string VerificaDivisibilidade(int valor)
            {
                if (valor % 3 == 0 && valor % 5 == 0)
                    return valor + " - fizz buzz";
                else
                    return valor.ToString();
            }
        }

        public class DivisibilidadePor7 : IDivisibilidade
        {
            public string VerificaDivisibilidade(int valor)
            {
                if (valor % 7 == 0)
                    return valor + " - Samyla";
                else
                    return valor.ToString();
            }
        }

        public interface IDivisibilidade
        {
            string VerificaDivisibilidade(int valor);
        }
    }
}
