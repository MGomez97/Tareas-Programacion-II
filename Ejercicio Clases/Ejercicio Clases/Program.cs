using System;

class Program
{
    static void Main()
    {
        // Crear instancias de SuperPoder
        SuperPoder poder1 = new SuperPoder("Super Fuerza", "Capacidad sobrehumana de fuerza física", 5);
        SuperPoder poder2 = new SuperPoder("Visión de Rayos X", "Capacidad de ver a través de objetos sólidos", 4);
        SuperPoder poder3 = new SuperPoder("Control Mental", "Habilidad para controlar mentes de otros", 5);

        // Crear instancias de SuperHeroe
        SuperHeroe heroe1 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, poder1);
        SuperHeroe heroe2 = new SuperHeroe("Wonder Woman", "Diana Prince", "Themyscira", true, poder2);
        SuperHeroe heroe3 = new SuperHeroe("Professor X", "Charles Xavier", "New York", false, poder3);

        // Mostrar la información
        Console.WriteLine("Información de Superhéroes:");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Superhéroe 1:");
        Console.WriteLine(heroe1);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Superhéroe 2:");
        Console.WriteLine(heroe2);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Superhéroe 3:");
        Console.WriteLine(heroe3);

        Console.ReadLine();
    }
}
