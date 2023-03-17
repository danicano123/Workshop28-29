using MadisonBridges;
using TheStrongestBeam;

int option = 5;
while (option != 0)
{
    option = 5;
    Console.WriteLine($"Type an option to interact with a proyect: \n" +
                      $"1. Madison Bridges \n" +
                      $"2. The strongest beam \n" +
                      $"0. Exit");
    try
    {
        option = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("Only numbers please!");
    }
    
    switch (option)
    {
        case 1:
            Console.WriteLine("Type the bridge schema: ");
            Bridges bridge = new(Console.ReadLine());
            if (bridge.IsValid())
            {
                Console.WriteLine("VALIDO");
                break;  
            }
            Console.WriteLine("INVALIDO");
            break;

        case 2:
            Console.WriteLine("Type the Beam schema: ");
            Beam beam = new(Console.ReadLine());
            if (beam.IsValid())
            {
                Console.WriteLine("La viga soporta el peso!");
                break;
            }
            Console.WriteLine("La viga NO soporta el peso!");
            break;

        default:
            Console.WriteLine("Invalid option: Choose one number between 0 to 2");
            break;
    }

}
