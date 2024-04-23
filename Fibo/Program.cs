int pos, penultimo = 0, ultimo = 1, atual;

Console.WriteLine("Informe a posição limite: ");
pos = int.Parse(Console.ReadLine());

if (pos == 1)
    Console.WriteLine(penultimo);
else
{
    if (pos == 2)
    {
        Console.WriteLine(penultimo);
        Console.WriteLine(ultimo);
    }
    else
    {
        Console.WriteLine(penultimo);
        Console.WriteLine(ultimo);

        for (int i = 2; i < pos; i++)
        {
            atual = penultimo + ultimo;
            Console.WriteLine(atual);
            penultimo = ultimo;
            ultimo = atual;
        }
    }
}



