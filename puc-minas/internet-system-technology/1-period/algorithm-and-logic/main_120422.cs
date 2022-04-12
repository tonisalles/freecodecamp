 
using System;

class MainClass {
    public static void Main (string[] args) {
        // Declaração de variáveis
        int n1, n2, n3, n4, n5, Soma;
        Double Media;
        
        // Entrada de dados
        Console.Write("Digite o primeiro numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro numero: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite o quarto numero: ");
        n4 = int.Parse(Console.ReadLine());
        Console.Write("Digite o quinto numero: ");
        n5 = int.Parse(Console.ReadLine());
        
        // Cálculo e processamento
        Soma = n1 + n2 + n3 + n4 + n5;
        Media = Soma / 5.0;
        
        // Saída de dados
        Console.WriteLine($"Soma = {Soma}");
        Console.WriteLine($"Media = {Media}");
    }
}
