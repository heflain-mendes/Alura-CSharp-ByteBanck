using System;
using bytecode.Funcionarios;

namespace bytecode.Bonificacao{
    public class GerenciaBonificacao{
        public double TotalBonificacao {get; private set;}
        public void Registrar(IBonificacao bonificacao){
            TotalBonificacao += bonificacao.calcular();
        }
    }
}