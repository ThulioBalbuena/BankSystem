using System;



namespace myBank

{

    class Program

    {

        static void Main(string[] args)

        {
            ContaCorrente contaDaMila = new ContaCorrente("Mila", 1234, 100);

            contaDaMila.Conta = 789;



            ContaCorrente contaDoTui = new ContaCorrente("Tui", 1234, 120);

            ContaCorrente contaDaKiki = new ContaCorrente("Kiki", 1234, 150);

            contaDoTui.Conta = 302;




            contaDaMila.Sacar (100);

           

            Console.WriteLine("O número da conta da Mila é: " + contaDaMila.Conta);

            Console.WriteLine("O saldo da conta da Mila é: " + contaDaMila.Saldo);

            Console.WriteLine("O número da conta do Tui é: " + contaDoTui.Conta);

            Console.WriteLine("O saldo da conta do Tui é: " + contaDoTui.Saldo);

        }

    }

}