﻿using System;

namespace BancoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioTui = new Funcionario("Tui", "123.123.123-13", "Vendedor", 2300);
            Funcionario funcionarioMila = new Funcionario("Mila", "321.321.321-23", "Vendedor", 2300);
            Funcionario funcionarioKiki = new Funcionario("Kiki", "321.123.321-27", "Vendedor", 2300);


            Contas contaRogerina = new Contas("Tui", 1239, 977, 230, funcionarioTui);
            Contas contaRogerino = new Contas("Mila", 1312, 977, 130, funcionarioMila);
            Contas contaRoger = new Contas("Kiki", 2840, 457, 112, funcionarioKiki);

            Console.WriteLine("O número de conta(s) criada(s) é: " + Contas.ContasCriadas);

            Console.WriteLine("Saldo inicial de Lúcifer é " + contaRogerina.Saldo + ". Conta vendida por " + funcionarioTui.Nome + ", que recebeu comissão de " + funcionarioTui.Comissao);
            Console.WriteLine("Saldo inicial de Maze é " + contaRogerino.Saldo + ". Conta vendida por " + funcionarioMila.Nome + ", que recebeu comissão de " + funcionarioMila.Comissao);
            Console.WriteLine("Saldo inicial de Amenadiel é " + contaRoger.Saldo + ". Conta vendida por " + funcionarioKiki.Nome + ", que recebeu comissão de " + funcionarioKiki.Comissao);

            contaRogerina.Sacar(40);
            contaRogerino.Depositar(80);
            contaRoger.Transferir(60, contaRogerino);

            Console.WriteLine("Saldo de Lucifer após saque é de " + contaRogerina.Saldo);
            Console.WriteLine("Saldo de Amenadiel após transferência para Maze é de " + contaRoger.Saldo);
            Console.WriteLine("Saldo de Maze após depósito e transferência de Amenadiel é de " + contaRogerino.Saldo);
        }
    }
}