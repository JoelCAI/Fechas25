using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fechas25
{
    public class Validador
    {
        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }


        public static int PedirInt(string mensaje)
        {
            /* la salida de esta funcion estará en la variable long valor */
            string mensError = "\n\n Por favor ingrese el valor solicitado" +
                               "\n Debe ingresar un valor que no sea vacio y que ese valor sea un numero. ";

            int valor;
            Console.WriteLine(mensaje);

            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Clear();
                Console.WriteLine(mensError);
                return PedirInt(mensaje);
            }
            else
                return valor;
        }

        public static void FechaConstructor(int numeroUno, int numeroDos, int numeroTres)
        {
            string año = Convert.ToString(numeroUno);
            string mes = Convert.ToString(numeroDos);
            string dia = Convert.ToString(numeroTres);

            string fecha = "" + numeroUno + "/" + numeroDos + "/" + numeroTres + "";

            bool ingresoCorrecto;
            DateTime fechaValida;

            ingresoCorrecto = DateTime.TryParse(fecha, out fechaValida);

            if (!ingresoCorrecto)
            {
                Console.Clear();
                Console.WriteLine("\n Usted ingreso una fecha inválida");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n Usted ingreso una fecha correcta que es: *" + fechaValida + "*.");
            }

        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }
    }
}
