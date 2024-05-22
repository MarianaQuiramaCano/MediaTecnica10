/******************************************************************************
Autor:       mariana quirama cano
fecha:       2024-05-22
Descripción: programa con decisiones para habilitar 
             votación de personas y descuento matricila estudio
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   //variables
   int edad;
   int valorMatricula;
   
   //Petición de dastos
   Console.WriteLine("digite su edad: ");
   edad = Int32.Parse(Console.ReadLine());
   
  Console.WriteLine("Digite su valor de matrícula: ");
   valorMatricula = Int32.Parse(Console.ReadLine ());
   
    //validacón 
    if(edad >= 18) {
        Console.WriteLine("felicidades, usted puede votar");
        Console.WriteLine("Usted pagará de matricula: " + (valorMatricula * 0.85));
    }
  }
}
