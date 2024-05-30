/******************************************************************************
Autor:       Mariana Quirama cano
fecha:       2024-05-30
Descripción: Dada la nota determinar
*******************************************************************************/

using System;
class  Program {
static void Main() {
    Console.WriteLine("Digite su nota: ");
    int opcion = Int32.Parse(Console.ReadLine());
    switch(opcion) 
    {
        case 1:
             Console.WriteLine("pierde");
             break;
        case 2:
             Console.WriteLine("pierde");  
             break;
        case 3:
            Console.WriteLine("gana");
            break;
        case 4:
            Console.WriteLine("alto");
            break;
        case 5:
            Console.WriteLine("superior");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            Console.WriteLine("Saliendo del programa");
            break;
     
        } 
    }
}
