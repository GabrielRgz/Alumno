using System;
using System.Collections.Generic;

    class Alumno
    {
        //  Campos  o   Atributos
        public string nombre;
        public string apellido;
        public string correo;

        public void ImprimeEnConsola()
        {
        Console.WriteLine("Hola yo soy {0} y me apellido {1} envíame un correo a {2}",nombre,apellido,correo);
        }

    }

    class Program
    {
        static void Main()
        {


        Alumno ana = new Alumno();
        ana.nombre = "Ana";
        ana.apellido = "Li";
        ana.correo = "ALi@gmail.com";

        Alumno John = new Alumno();
        John.nombre = "John";
        John.apellido = "Roma";
        John.correo = "JRoma@gmail.com";

        ana.ImprimeEnConsola();
        John.ImprimeEnConsola();

        Console.ReadKey();


        }
    }
