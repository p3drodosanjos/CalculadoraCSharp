


Divisao();


static void Soma()
{

    Console.WriteLine("Primeiro Número: ");
    float n1 = float.Parse(Console.ReadLine()!);


    Console.WriteLine("Segundo Número: ");
    float n2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = n1 + n2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    //Console.WriteLine("O resultado da soma é: " + resultado);
    //Console.WriteLine($"O resultado da soma é: {n1 + n2}");

    Console.ReadKey();

}

static void Subtracao()
{
    Console.WriteLine("Primeiro Número: ");
    float n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Segundo Número: ");
    float n2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = n1 - n2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");

    Console.ReadKey();

 


}

static void Divisao()
{
    Console.WriteLine("Primeiro número: ");
    float n1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("Segundo número: ");
    float n2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = n1 / n2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");


    Console.ReadKey();

}

static void Multiplicacao()
{
    
}
