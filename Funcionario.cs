public class Funcionario{
    public string Nome {get; set;}
    public string CPF {get; set;}
    public string Cargo {get; set;}
    public double Salario {get; set;}
    public double Comissao {get; set;}

    public Funcionario(string funcionarioNome, string funcionarioCPF, string funcionarioCargo, double funcionarioSalario)
    { 
        Nome = funcionarioNome;
        CPF = funcionarioCPF;
        Cargo = funcionarioCargo;
        Salario = funcionarioSalario;
    }
}