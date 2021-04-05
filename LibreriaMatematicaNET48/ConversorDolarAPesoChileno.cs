using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMatematicaNET48
{
    public static class ConversorDolarAPesoChileno
    {
        private static float valorConversion = 717.12f;
        public static int Convertir(int valorOrigen)
        {
            //float valorOrigenEnFloat = (float) valorOrigen;
            return (int)(valorOrigen * valorConversion); // retorno temporal para evitar error en el compilador
        }
    }
}
