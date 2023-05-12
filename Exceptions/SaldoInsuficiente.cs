using System;

namespace bytecode.Exceptions{
    public class SaldoInsuficiente : Exception{
        public SaldoInsuficiente():base(){}
        public SaldoInsuficiente(string mensagem): base(mensagem){}
    }
}