public class ContaCorrente{
   public string titular;
   public int agencia;
   public int senha;
   public double saldo;

        public ContaCorrente(string t_titular,int a_agencia,int s_senha,double s_saldo)
        {
            titular = t_titular;
            agencia = a_agencia;
            senha = s_senha;
            saldo = s_saldo;
}          
        public bool Sacar(double Valor){
            if(this.saldo < Valor){
                return false;
            }
            else{
                this.saldo -= Valor;
                return true;
            }
        }
        public void Depositar(double Valor){
            this.saldo += Valor;
        }

        public bool Transferir(double Valor,ContaCorrente contaDestino){
            if(this.saldo < Valor){
                return false;
            }
            else{
                this.Sacar(Valor);
                contaDestino.Depositar(Valor);
                return true;
            }
        }
}