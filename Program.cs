// See https://aka.ms/new-console-template for more information

using System;


namespace CoreEscuela{
    class Escuela{
        // atributtes

        public string nombre;
        public string direccion;
        public int anioFundacion;
        public string ceo;

        // comportamientos

        // metodo void se usa para cuando se 
        //quiere hacer algo pero que no retorne nada

        public void Timbrar(){
            Console.Beep(2000, 3000);
        }

    }

    class Program{
        static void Main(string[] args) {

            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Cr 9 calle 72";
            miEscuela.anioFundacion = 2012;
            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();

            // Console.WriteLine("Hello, World!");
        }
    }
}

