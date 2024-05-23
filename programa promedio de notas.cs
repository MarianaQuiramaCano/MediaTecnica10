/******************************************************************************
Autor:       mariana quirama cano
fecha:       2024-05-22
DescripciC3n:un docente require de un sistema de notas donde recibe
4 calificaciones generando un promedio y luego 
 determinando si gana o pierde.
Si su promedio es menor a 3 pierde, si es mayor gana
 Si tiene un promedio mayor a 4.5 emitir mensaje: 
"Fekicidades, te has ganado una beca"
*******************************************************************************/
   
  using System;

class ProgramaDescuentos
{
  
static void Main ()
  {
	
	  // variables
	double calificacion1;
    double calificacion2;
	double calificacion3;
	double calificacion4;
	
	// solicitar cantidad Tornillos a Tony Stark
    Console.WriteLine ("digita tu calificacion1: ");
	calificacion1 = double.Parse (Console.ReadLine ());
	
    Console.WriteLine ("digita tu calificacion2:");
    calificacion2 = double.Parse (Console.ReadLine ());
    
   Console.WriteLine ("digita tu calificacion3:");
   calificacion3 = double.Parse (Console.ReadLine ());

	Console.WriteLine ("digita tu calificacion4:");
   calificacion4 = double.Parse (Console.ReadLine ());
	
  double PromedioNotas =calificacion1 + calificacion2 + calificacion3 + calificacion4 / 4;
	
 
	  // validaciC3n
	  
	  //Si su promedio es menor a 3 pierde
	  if (PromedioNotas <= 2){
	Console.WriteLine ("tu promedio no es suficiente, has perdido: " +	((calificacion1 + calificacion2 +	  calificacion3 + calificacion4) / 4));
	 }
	
   // si es a 3 mayor gana
	if (PromedioNotas >= 2){
	if (PromedioNotas <= 4.5){
	Console.WriteLine ("tu promedio es suficiente, has ganado: " +	((calificacion1 + calificacion2 +calificacion3 + calificacion4) / 4));
	  
}
	  
}
  //mayor a 4.5
	  if (PromedioNotas >= 4.5){
	Console.WriteLine ("tu promedio es superior has ganado: " +((calificacion1 + calificacion2 +calificacion3 + calificacion4) / 4));
	Console.WriteLine ("Felicidades, te has ganado una beca");
	  
}
  
 
}

}
