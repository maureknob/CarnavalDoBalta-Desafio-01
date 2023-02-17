
ConsoleKey key;
do
{
    Console.Clear();
    Console.WriteLine("\t Carnaval do Balta - Desafio 1 \n");
    Console.Write("Digite um texto no console: ");

    var input = Console.ReadLine();
    (int wordsCount, int charCount) = (input.Split(" ").Length, input.Length);

    Console.WriteLine($"O Texto possui {wordsCount} palavras e {charCount} caracteres \n");
    Console.WriteLine("Pressione qualquer tecla para digitar um novo texto.");
    Console.WriteLine("Pressione ESC para terminar o programa.");

    key = Console.ReadKey().Key;
} while (!key.Equals(ConsoleKey.Escape));

