


Menu();


static void Menu()
{

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");


    Console.WriteLine("--------------");
    Console.WriteLine("Selecione uma opção:");
    short res = short.Parse(Console.ReadLine()!);

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        default: Menu(); break;
    }


}



static void Soma()
{

    Console.WriteLine("Primeiro Número: ");
    float n1 = float.Parse(Console.ReadLine()!);


    Console.WriteLine("Segundo Número: ");
    float n2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = n1 + n2;
    Console.WriteLine($"O resultado da soma é {resultado}");
    //Console.WriteLine("O resultado da soma é: " + resultado);
    //Console.WriteLine($"O resultado da soma é: {n1 + n2}");

    Console.ReadKey();
    Menu();

}

static void Subtracao()
{
    Console.WriteLine("Primeiro Número: ");
    float n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Segundo Número: ");
    float n2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = n1 - n2;
    Console.WriteLine($"O resultado da subtração é {resultado}");

    Console.ReadKey();
    Menu(); 



}

static void Divisao()
{
    Console.WriteLine("Primeiro número: ");
    float n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Segundo número: ");
    float n2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = n1 / n2;
    Console.WriteLine($"O resultado da divisão é {resultado}");


    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.WriteLine("Primeiro número: ");
    float n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Segundo número");
    float n2 = float.Parse(Console.ReadLine()!);
    
    Console.WriteLine("");

    float resultado = n1 * n2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
   
    Console.ReadKey();
    Menu();
}
