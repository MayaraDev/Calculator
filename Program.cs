using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu(){

        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1- Subtracao");
        Console.WriteLine("2 - Divisao");
        Console.WriteLine("3 - Multiplicacao");
        Console.WriteLine("4 - Soma");
        Console.WriteLine("5- Sair");

        Console.WriteLine("-----------------------------");
        Console.WriteLine("Selecione uma opção:");
        short res = short.Parse(Console.ReadLine());
        
        switch(res) {
            case 1: Subtracao(); break;      
            case 2: Divisao(); break;
            case 3: Multiplicacao(); break;
            case 4: Soma(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;

        }


    }
    
    public static void Subtracao () 
    {
        Console.Clear();
        Console.WriteLine("Ano atual: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ano que você nasceu: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;
        Console.WriteLine("Sua idade é " + resultado);
        Console.ReadKey();

        Menu();
    }

    public static void Divisao()
    {
        Console.Clear();
        
        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1/v2;
        Console.WriteLine("O resultado é " + resultado); 
        Console.ReadKey();

        Menu();

    }

public static void Multiplicacao()
{

    Console.Clear();
    
    Console.WriteLine("Primeiro Valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1*v2;
    Console.WriteLine("O resultado é " + resultado);
    Console.ReadKey();

    Menu();

}

public static void Soma(){

    Console.Clear();
    
    Console.WriteLine("Primeiro Valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;

    Console.WriteLine("O resultado é " + resultado);
    Console.ReadKey();

    Menu();

}
}