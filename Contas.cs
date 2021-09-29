public class Contas{
    public string Titular {get; set;}
    public int Agencia {get; set;}
    public int Senha {get; set;}
    public static int ContasCriadas {get; set;}
    public static double Comissao {get; set;}
    private double _saldo;
    public double Saldo { get{
        return this._saldo;
    }
    set{
        if(value >= 0){
            this._saldo = value;
        }
     } 
    }

    public Contas(string contatitular, int contaagencia, int contasenha, double contasaldo, Funcionario funcionario)
    { 
        Titular = contatitular;
        Agencia = contaagencia;
        Senha = contasenha;
        Saldo = contasaldo;
        ContasCriadas ++;
        Comissao += contasaldo * 0.01;
        funcionario.Comissao += contasaldo * 0.01;
    }

    public bool Sacar (double valor){
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public bool Transferir(double valor, Contas contaDestino){
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }

    public double ConsultaSaldo(){
        return this.Saldo;
    }
}