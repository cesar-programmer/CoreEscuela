﻿using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("juan escutia", 2002, TiposEscuela.Primaria, ciudad:"tijuana", pais:"mexico");
            

            var curso1 = new Curso()
            {
                Nombre="101"
            };

            var curso2 = new Curso()
            {
                Nombre="201"
            };

            var curso3 = new Curso()
            {
                Nombre="301"
            };

            Console.WriteLine(escuela);
           
            System.Console.WriteLine("==========================");
            Console.WriteLine(curso1.Nombre +","+ curso1.UniqueId);
            Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            Console.WriteLine(curso3);

        }
    }
}
