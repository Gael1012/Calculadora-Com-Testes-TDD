using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculadoras
    {
        private List<string> listaHistorico;

        public Calculadoras()
        {
            listaHistorico = new List<string>();
        }
        public int somar(int a, int b)
        {
            int res = a+b;
            listaHistorico.Insert(0, "Res "+res);
            return res;
        }
        public int subtrair(int a, int b)
        {
            int res = a-b;
            listaHistorico.Insert(0, "Res "+res);
            return res;
        }
        public int dividir(int a, int b)
        {
            int res = a/b;
            listaHistorico.Insert(0, "Res "+res);
            return res;
        }
        public int multiplicar(int a, int b)
        {
            int res = a*b;
            listaHistorico.Insert(0, "Res "+res);
            return res;
        }
        public List<string> historico()
        {
           
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
                return listaHistorico;
        }
    }
}