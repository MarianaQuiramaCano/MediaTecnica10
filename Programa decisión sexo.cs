/******************************************************************************
Autor:       mariana quirama cano
fecha:       2024-05-22
Descripción: programa con decisiones para determinar 
             el sexo de un usuario
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    //variables
    bool sexoMasculino;
    //capturar informacion del usuario
    Console.Write("digite true si es hombre: ");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    //validacón
    if (sexoMasculino == true)
    { 
     Console.WriteLine("felicidades, es hombre"); 
    }
    else{
    Console.WriteLine("felicidades, es mujer"); 
    }
     Console.WriteLine("Finalizada la ejecución"); 
     
  }
}
