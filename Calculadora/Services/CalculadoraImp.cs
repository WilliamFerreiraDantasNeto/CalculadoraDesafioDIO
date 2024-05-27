using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> _historico;
        private string data;

        public CalculadoraImp(string data)
        {
            _historico = [];
            this.data = data;
        }
        public int Somar (int num1, int num2)
        {
            int resultado = num1 + num2;

            _historico.Insert(0, $"{resultado} - data:{data}");
            return resultado;
        }

        public int Subtrair (int num1, int num2)
        {
            int resultado = num1 - num2;
            _historico.Insert(0, $"{resultado} - data:{data}");
            return resultado;
        }

        public int Multiplicar (int num1, int num2)
        {
            int resultado = num1 * num2;
            _historico.Insert(0, $"{resultado} - data:{data}");
            return resultado;
        }

        public int Dividir (int num1, int num2)
        {
            int resultado = num1 / num2;
            _historico.Insert(0, $"{resultado} - data:{data}");
            return resultado;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count-3);
            return _historico;
        }
    }
}