using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppDatos;


namespace AppNegocio
{
    public class Negocio
    {
        public double   CalcularY(double x)
        {
           AppDatos.Datos Datos = new AppDatos.Datos();


            double y = 0;

            //y = (a)x^2 + b(x) + c 

            y = ((Datos.a) * (Math.Pow(x, 2))) + (Datos.b * x) + Datos.c;

            return y;
        }
    }
}
