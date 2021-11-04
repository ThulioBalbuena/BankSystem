using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteCypher = new Gerente()
            {
                Nome = "Cypher Indra",
                CPF = "877.123.749-51",
                Salario = 5000,
                NumeroDeAgencias = 5,
            };

            Vendedor vendedorBruce = new Vendedor()
            {
                Nome = "Bruce",
                CPF = "153.856.724-10",
                Salario = 2000,
                NumeroClientesAtendidos = 5,
            };

            Vendedor vendedorJason = new Vendedor()
            {
                Nome = "Jason",
                CPF = "598.165.232-30",
                Salario = 2000,
                NumeroClientesAtendidos = 3,
            };

            vendedorJason.Bonificacao = vendedorJason.Salario;

            ContaCorrente contaDoThulioBalbuenaDionisio = new ContaCorrente("Thúlio Balbuena Dionísio", 4324, 2000, vendedorJason);
            contaDoThulioBalbuenaDionisio.Conta = 329;
            ContaCorrente contaDaMila = new ContaCorrente("Mila", 1534, 420, vendedorJason);
            contaDaMila.Conta = 659;
            ContaCorrente contaDaKiki = new ContaCorrente("Kiki", 5678, 24050, vendedorBruce);
            contaDaKiki.Conta = 323;

            Console.WriteLine("As contas são:");
            Console.WriteLine("Conta 1:\nNome: " + contaDoThulioBalbuenaDionisio.Titular +
            "\nAgência: " + contaDoThulioBalbuenaDionisio.Agencia +
            "\nSaldo: " + contaDoThulioBalbuenaDionisio.Saldo);

            Console.WriteLine("\nConta 2:\nNome: " + contaDaMila.Titular +
            "\nAgência: " + contaDaMila.Agencia +
            "\nSaldo: " + contaDaMila.Saldo);

            Console.WriteLine("\nConta 3:\nNome: " + contaDaKiki.Titular +
            "\nAgência: " + contaDaKiki.Agencia +
            "\nSaldo: " + contaDaKiki.Saldo);

            Console.WriteLine("\nOs funcinários são:");
            Console.WriteLine("Funcionario 1:\nNome: " + vendedorBruce.Nome +
            "\nCPF: " + vendedorBruce.CPF + "\nSalário: " + vendedorBruce.Salario +
            "\nComissão: " + vendedorBruce.Comissao + "\nBonificação: " + vendedorBruce.Bonificacao +
            "\nDias de férias: " + vendedorBruce.CalcularFerias() +
            "\nRemuneração total: " + vendedorBruce.RemuneracaoTotal(vendedorBruce.Salario));

            Console.WriteLine("\nFuncionario 2:\nNome: " + vendedorJason.Nome +
            "\nCPF: " + vendedorJason.CPF + "\nSalário: " + vendedorJason.Salario +
            "\nComissão: " + vendedorJason.Comissao + "\nBonificação: " + vendedorJason.Bonificacao +
            "\nDias de férias: " + vendedorJason.CalcularFerias() +
            "\nRemuneração total: " + vendedorJason.RemuneracaoTotal(vendedorJason.Salario, vendedorJason.Bonificacao));

            Console.WriteLine("\nGerente:\nNome: " + gerenteCypher.Nome +
            "\nCPF: " + gerenteCypher.CPF + "\nSalário: " + gerenteCypher.Salario +
            "\nComissão: " + gerenteCypher.Comissao + "\nBonificação: " + gerenteCypher.Bonificacao +
            "\nDias de férias: " + gerenteCypher.CalcularFerias() +
            "\nRemuneração total: " + gerenteCypher.RemuneracaoTotal(gerenteCypher.Salario));

            Console.WriteLine("\nSacar R$200,00 da conta da Kiki.");
            contaDaKiki.Sacar(200);
            Console.WriteLine("O saldo da conta da Kiki é: " + contaDaKiki.Saldo);

            Console.WriteLine("\nDepositar R$1000,00 na conta da Mila.");
            contaDaMila.Depositar(1000);
            Console.WriteLine("O saldo da conta da Mila é: " + contaDaMila.Saldo);

            Console.WriteLine("\nTransferir R$650,00 da conta da Kiki para a conta do Thúlio Balbuena Dionísio.");
            contaDaKiki.Transferir(650, contaDoThulioBalbuenaDionisio);
            Console.WriteLine("O saldo da conta da Kiki é: " + contaDaKiki.Saldo);
            Console.WriteLine("O saldo da conta do Thúlio Balbuena Dionísio é: " + contaDoThulioBalbuenaDionisio.Saldo);

            Console.WriteLine("\nO número de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}
