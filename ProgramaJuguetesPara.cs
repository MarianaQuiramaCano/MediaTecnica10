/******************************************************************************
Autor: Mariana Quirama Cano
Fecha: 2024-06-05
Desccripcion:Toy Story
     Los juguetes de Andy están 
     jugando a las escondidas. Pide al 
     usuario las ubicaciones donde buscar 
     y usa estructuras "si" para determinar 
     si los juguetes están en la ubicación 
     correcta o no. Reportar la cantidad 
     total de juguetes que fueron encontrados 
     al finalizar 4 rondas.
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    // variables
    int ubicacion;
    int cantidaddejuguetes = 0;
    // estructura repetitiva o ciclicla
    for (int i = 0; i <4; i++) {
      
       // preguntar ubicaciones al usuario
        Console.WriteLine("donde vas a buscar al juguete: ");
        Console.WriteLine("1. habitacion");
        Console.WriteLine("2. cocina");
        Console.WriteLine("3. baño");
        Console.WriteLine("4. caja de juguetes");
        Console.WriteLine("5. sala");
        Console.WriteLine("6. techo");
        Console.WriteLine("7. patio");
        Console.WriteLine("8. debajo de la cama");
        
        Console.Write("encuentra al juguete de andy, donde buscaras: ");
        ubicacion = Int32.Parse(Console.ReadLine());
         switch(ubicacion) 
         
        // validar ubicaciones con estructura IF
    {    
        case 1:
            Console.WriteLine("encontraste a Sheriff Woody");
            cantidaddejuguetes = cantidaddejuguetes + 1;
             break;
        case 4:
             Console.WriteLine("encontraste a Buzz Lightyear"); 
            cantidaddejuguetes = cantidaddejuguetes + 1;
             break;
        case 8:
            Console.WriteLine("encontraste a  Rex");
            cantidaddejuguetes = cantidaddejuguetes + 1;
            break;
        case 3:
            Console.WriteLine("encontraste a Slinky");
            cantidaddejuguetes = cantidaddejuguetes + 1;
            break;

        default:
            Console.WriteLine("no encontraste ningun juguete");
            break;
         
         // acumular juguetes encontrados    
    }     
         
    }
    
    Console.WriteLine("el total de juguetes que encontraste son : " + cantidaddejuguetes );   
 
  }
}
