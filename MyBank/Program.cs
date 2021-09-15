using System;

namespace MyBankdot
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaTui = new ContaCorrente("Thulio", 1234, 213, 142);
            ContaCorrente contaMila = new ContaCorrente("Camila", 4234, 13, 643);

            Console.WriteLine("o titular é " + contaTui.titular);
            Console.WriteLine("o titular é " + contaMila.titular);

            contaTui.Sacar(100);
            contaMila.Sacar(200);

            Console.WriteLine("o seu saldo é " + contaTui.saldo);
            Console.WriteLine("o seu saldo é " + contaMila.saldo);

            contaTui.Depositar(250);
            contaMila.Depositar(350);

            Console.WriteLine("o seu saldo é " + contaTui.saldo);
            Console.WriteLine("o seu saldo é " + contaMila.saldo);

            contaTui.Transferir(250, contaMila);

            Console.WriteLine("o seu saldo depois da transferência é " + contaMila.saldo);

        }
    }
}