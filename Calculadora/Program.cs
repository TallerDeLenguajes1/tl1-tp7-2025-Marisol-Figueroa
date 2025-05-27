using EspacioCalculadora;

Calculadora Calc = new Calculadora();

bool continuar = true;
while (continuar)
{

    Console.WriteLine("Seleccione una opción");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");

    string? opcion = Console.ReadLine();


    switch (opcion)
    {
      case "1":
      Calc.Sumar(8);
      Console.WriteLine(Calc.Resultado.ToString());
      break;
      case "2":
      Calc.Restar(7);
      Console.WriteLine(Calc.Resultado.ToString());
      break;
      case "3":
      Calc.Multiplicar(56);
      Console.WriteLine(Calc.Resultado.ToString());
      break;
      case "4":
      Calc.Dividir(2);
      Console.WriteLine(Calc.Resultado.ToString());
      break;
      default:
        Console.WriteLine("Opción inválida.");
        break;
    }
            
  Console.Write("\n¿Desea realizar otra operación? (s/n): ");
  string? respuesta = Console.ReadLine();
  if (respuesta?.ToLower() != "s")
  {
    continuar = false;
  }
}




