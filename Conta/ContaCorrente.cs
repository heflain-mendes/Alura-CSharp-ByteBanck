using System;
using bytecode.Titular;
using bytecode.Exceptions;

namespace bytecode.Conta
{
    public class ContaCorrente
    {
        public static int Qtd_contas_criadas { get; private set; }
        public static float TaxaOperacao { get; private set; }
        private int? numero_agencia;

        public int? Numero_agencia{
            get{
                return this.numero_agencia;
            }
            init{
                if(value > 0){
                    this.numero_agencia = value;
                }
            }
        }

        // private string? conta;
        public string? Conta { get; init; }

        // private Cliente titular;
        public Cliente Titular { get; set; } = new Cliente();
        private double saldo = 100;

        public void Depositar(double valor){
            this.saldo += valor;
        }

        public bool Sacar(double valor){
            if(valor > this.saldo){
                return false;
                throw new SaldoInsuficiente();
            }else{
                this.saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente conta){
            if(Sacar(valor)){
                conta.Depositar(valor);
                return true;
            }else{
                return false;
            }
        }

        public void SetSaldo(double valor){
            if(valor < 0){
                return;
            }

            this.saldo = valor;
        } 

        public double GetSaldo(){
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            this.Conta = conta;
            this.Numero_agencia = numero_agencia;
            
            if(numero_agencia <= 0){
                throw new ArgumentException("Número da agencia não pode ser zero(0) ou negativo(-)", nameof(numero_agencia));
            }

            ContaCorrente.Qtd_contas_criadas++;
            ContaCorrente.TaxaOperacao = 30 / Qtd_contas_criadas;
        }
    }
}