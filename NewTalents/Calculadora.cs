using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int val1, int val2)
        {
            listaHistorico.Insert(0, $"{ val1 + val2 }");
            return val1 + val2 ;
        }

        public int Diminuir(int val1, int val2)
        {
            listaHistorico.Insert(0, $"{val1 - val2}");
            return val1 - val2;
        }

        public int Multplicar(int val1, int val2)
        {
            listaHistorico.Insert(0, $"{val1 * val2}");
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            listaHistorico.Insert(0, $"{val1 / val2}");
            return val1 / val2;
        }

        public List<string> Historico()
        {
            
            listaHistorico.RemoveRange(3, listaHistorico.Count -3 );
            return listaHistorico;
        }
    }
}
