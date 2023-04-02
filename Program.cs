using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("--- Cálculo de Troco ---\n");

        Console.Write("Digite o valor da compra: R$ ");
        double valorCompra = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor pago: R$ ");
        double valorPago = double.Parse(Console.ReadLine());

        double troco = valorPago - valorCompra;

        Console.WriteLine("\nO valor do troco é: R$ " + troco.ToString("F2"));
    }
}
