using EjercicioClase;
using System;

SuperHeroe superHeroe = new SuperHeroe();
superHeroe.Nombre = "Superman";
superHeroe.IdentidadSecreta = "Clark Kent";
superHeroe.PuedeVolar = "Metropolis";
superHeroe.SuperPoder = "true";

Console.WriteLine($"Nombre: {superHeroe.Nombre}");
Console.WriteLine($"IdentidadSecreta: {superHeroe.IdentidadSecreta}");
Console.WriteLine($"PuedeVolar: {superHeroe.PuedeVolar}");
Console.WriteLine($"SuperPoder: {superHeroe.SuperPoder}");

SuperPoder superPoder = new SuperPoder();
superPoder.Nombre = "Super Fuerza";
superPoder.Describcion = "Capacida de levantar objeto pesados";
superPoder.Nivel = "9";
Console.WriteLine($"Nombre: {superPoder.Nombre}");
Console.WriteLine($"Describcion: {superPoder.Describcion}");
Console.WriteLine($"Nivel: {superPoder.Nivel}");