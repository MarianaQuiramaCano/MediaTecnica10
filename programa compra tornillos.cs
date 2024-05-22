/******************************************************************************
Autor:       mariana quirama cano
fecha:       2024-05-22
Descripción:Tony Stark, Iron Man, quiere saber cuánto dinero debe tener para comprar
X tornillos c/u a $300, pero en la tienda le dan descuentos según cantidad de compra:
crear un algoritmo que ayude a calcular si compra:
     1 sin descuentos
     5 descuento del 30%
     
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   //variables
   
   int valorTornillo = 300;
   int cantidadTornillos;
   
   //Petición de dastos
   Console.WriteLine("digite su compra: ");
   valorTornillo = Int32.Parse(Console.ReadLine());
   
    //validacón 
     if(valorTornillo <= 5) {
     Console.WriteLine("debe pagar por la compra: " + (valorTornillo));
     } 
      
    else if (valorTornillo >= 5) {
     Console.WriteLine("debe pagar por la compra: " + (valorTornillo * 0.70 * cantidadTornillos ));
     
     }
    else if (valorTornillo >= 10) {
      Console.WriteLine("debe pagar por la compra: " + (valorTornillo * 0.50 * cantidadTornillos ));   
    }
  
   }
}
