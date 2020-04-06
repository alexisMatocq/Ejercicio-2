using System;

class MainClass {
  public static void Main (string[] args) {
  int NUM1, NUM2;
    string linea;
    Console.Write("INGRESAR PRIMER NÚMERO :");
    linea = Console.ReadLine();
    NUM1 = int.Parse(linea);
    Console.Write("INGRESAR SEGUNDO NÚMERO :");
    linea = Console.ReadLine();
    NUM2 = int.Parse(linea);
    Console.WriteLine("Primer numero:"+NUM1);
    Console.WriteLine("Segundo numero:"+NUM2);
    Console.WriteLine("La suma es:"+(NUM1+NUM2));
    Console.WriteLine("La resta es:"+(NUM1-NUM2));
    Console.WriteLine("La multiplicacion es:"+(NUM1*NUM2));
    Console.WriteLine("La division es:"+(NUM1/NUM2));

  }
}