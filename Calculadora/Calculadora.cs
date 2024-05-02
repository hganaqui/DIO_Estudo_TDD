using System.Collections.Generic;

namespace Calc
{
    public class Calculadora
    {

        public List<string> listaHistorico { get; set; }

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int somar(int x, int y)
        {
            var somar = x + y;
            insertHistorico(somar);
            return somar;
        }

        public int subtrair(int x, int y)
        {
            var subtrair = x - y;
            insertHistorico(subtrair);
            return subtrair;
        }

        public int dividir(int x, int y)
        {
            var dividir = x/ y;
            insertHistorico(dividir);
            return dividir;
        }

        public int multiplicar(int x, int y)
        {
            var multiplicar = x * y;
            insertHistorico(multiplicar);
            return multiplicar;
        }

        public List<string> historico()
        {
            return listaHistorico;
        }

        public void insertHistorico(int valor)
        {
            listaHistorico.Insert(0,valor.ToString());
        }
    }
}
