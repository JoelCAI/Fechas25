using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas25
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");

            int numeroUno = Validador.PedirInt("\n Ingrese el primer número que será el año" +
                                               "\n Utilize el formato *aaaa*");
            Console.Clear();
            int numeroDos = Validador.PedirInt("\n Ingrese el primer número que será el mes" +
                                               "\n Utilize el formato *mm*");
            Console.Clear();
            int numeroTres = Validador.PedirInt("\n Ingrese el primer número que será el día" +
                                                "\n Utilize el formato *dd*");
            Console.Clear();
            Validador.FechaConstructor(numeroUno, numeroDos, numeroTres);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }


    }
}