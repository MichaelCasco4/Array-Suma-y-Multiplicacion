using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    public class TiradaDeDado
    {
        private int[] conteoSumas = new int[11]; //Aqui contamos la suma

        //Simulacion de datos 
        public (int dado1, int dado2, int suma) Tirar()
        {
            Random rand = new Random();
            //Primer dado
            int dado1 = rand.Next(1, 7);
            //Segundo dado
            int dado2 = rand.Next(1, 7);
            //Suma
            int suma = dado1 + dado2;

            conteoSumas[suma - 2]++;
            return (dado1, dado2, suma); // Devuelve el valor de los dados y tambien de la suma
        }

        // Obtenemos la suma after la operacion
        public int[] ObtenerConteoSumas()
        {
            return conteoSumas;
        }
    }
}