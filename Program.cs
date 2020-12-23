using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("juan escutia", 2002, TiposEscuela.Primaria, ciudad:"tijuana", pais:"mexico");
            

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
                                {
                                    Nombre="101"
                                };

            var curso2 = new Curso()
            {
                Nombre="201"
            };
            arregloCursos[1] = curso2;


            arregloCursos[2] = new Curso
                                {
                                    Nombre="301"
                                };
// estas son diferentes formas de asignar el objeto al arrray 
            Console.WriteLine(escuela);
            System.Console.WriteLine("==========================");
            ImprimirCursos(arregloCursos);
// para crear metodos de forma efectiva solo escribe la linea del metodo y pulsa control punto y generar metodo
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int counter =0;
           while (counter < arregloCursos.Length)
           {
               Console.WriteLine($"Nombre {arregloCursos[counter].Nombre}, id {arregloCursos[counter].UniqueId}");
               // esta es una manera mas bonita de imprimir datos de un array
               counter += 1;
               //con esta manera de aumentar el contador puedes aumentar el numero como en vez de pober el 1 puedes poner el 2 o el 3 e ira sumando de 2 en 2 o de 3 en 3
           }
        }
    }
}
