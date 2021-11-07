using System;

namespace CS_BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteDexStarr = new Gerente()
            {
                Nome = "Dex-Starr",
                CPF = "425.238.556-34",
                Salario = 10000,
                NumeroDeAgencias = 2,
            };

            Vendedor vendedorCamila = new Vendedor()
            {
                Nome = "Camila Ellen",
                CPF = "123.556.139-12",
                Salario = 2000,
                NumeroClientesAtendidos = 3,
            };

            Vendedor vendedorKiara = new Vendedor()
            {
                Nome = "Kiara",
                CPF = "109.876.543-11",
                Salario = 3000,
                NumeroClientesAtendidos = 8,
            };

            Vendedor vendedorVorus = new Vendedor()
            {
                Nome = "Vorus",
                CPF = "591.643.22-11",
                Salario = 4000,
                NumeroClientesAtendidos = 12,
            };

            vendedorKiara.Bonificacao = vendedorKiara.Salario;
            vendedorCamila.Bonificacao = vendedorCamila.Salario;
            gerenteDexStarr.Bonificacao = gerenteDexStarr.Salario;
            vendedorVorus.Bonificacao = vendedorVorus.Salario;

            ContaCorrente contaThulio = new ContaCorrente("Thulio Balbuena Dionisio", 4421, 15000, vendedorVorus);
            contaThulio.Conta = 789;
            ContaCorrente contaVeiga = new ContaCorrente("Veiga", 4248, 12000, vendedorKiara);
            contaVeiga.Conta = 789;
            ContaCorrente contaMiucha = new ContaCorrente("Miucha", 0562, 20000, vendedorCamila);
            contaMiucha.Conta = 123;

            Console.WriteLine("Contas:\n");
            Console.WriteLine("Conta 1:\nNome: " + contaThulio.Titular +
            "\nAgência: " + contaThulio.Agencia +
            "\nSaldo: " + contaThulio.Saldo);

            Console.WriteLine("\nConta 2:\nNome: " + contaVeiga.Titular +
            "\nAgência: " + contaVeiga.Agencia +
            "\nSaldo: " + contaVeiga.Saldo);

            Console.WriteLine("\nConta 3:\nNome: " + contaMiucha.Titular +
            "\nAgência: " + contaMiucha.Agencia +
            "\nSaldo: " + contaMiucha.Saldo);

            Console.WriteLine("\n---------------------\nFuncinários:\n");
            Console.WriteLine("Vendedor 1:\nNome: " + vendedorCamila.Nome +
            "\nCPF: " + vendedorCamila.CPF + "\nSalário: " + vendedorCamila.Salario +
            "\nBonificação: " + vendedorCamila.Bonificacao +
            "\nDias de férias: " + vendedorCamila.CalcularFerias() +
            "\nRemuneração total: " + vendedorCamila.RemuneracaoTotal(vendedorCamila.Salario, vendedorCamila.Bonificacao));

            Console.WriteLine("\nVendedor 2:\nNome: " + vendedorKiara.Nome +
            "\nCPF: " + vendedorKiara.CPF + "\nSalário: " + vendedorKiara.Salario +
            "\nBonificação: " + vendedorKiara.Bonificacao +
            "\nDias de férias: " + vendedorKiara.CalcularFerias() +
            "\nRemuneração total: " + vendedorKiara.RemuneracaoTotal(vendedorKiara.Salario, vendedorKiara.Bonificacao));

            Console.WriteLine("\nVendedor 3:\nNome: " + vendedorVorus.Nome +
            "\nCPF: " + vendedorVorus.CPF + "\nSalário: " + vendedorVorus.Salario +
            "\nBonificação: " + vendedorVorus.Bonificacao +
            "\nDias de férias: " + vendedorVorus.CalcularFerias() +
            "\nRemuneração total: " + vendedorVorus.RemuneracaoTotal(vendedorVorus.Salario, vendedorVorus.Bonificacao));

            Console.WriteLine("\nGerente:\nNome: " + gerenteDexStarr.Nome +
            "\nCPF: " + gerenteDexStarr.CPF + "\nSalário: " + gerenteDexStarr.Salario +
            "\nBonificação: " + gerenteDexStarr.Bonificacao +
            "\nDias de férias: " + gerenteDexStarr.CalcularFerias() +
            "\nRemuneração total: " + gerenteDexStarr.RemuneracaoTotal(gerenteDexStarr.Salario));

            Console.WriteLine("\nContas criadas: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}
