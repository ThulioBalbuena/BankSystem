using System;

namespace MyBankdot
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaTui = new ContaCorrente();
            contaTui.titular = "Thulio";
            contaTui.agencia = 1452;
            contaTui.senha = 113;
            contaTui.saldo = 100.50;

            ContaCorrente contaMila = new ContaCorrente();

            contaMila.titular = "Mila";
            contaMila.agencia = 532;
            contaMila.senha = 412;
            contaMila.saldo = 430;

            Console.WriteLine("o titular é " + contaTui.titular);
            Console.WriteLine("o titular é " + contaMila.titular);
        }
    }
}