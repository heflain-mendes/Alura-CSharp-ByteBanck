using System;

namespace bytecode.Funcionarios{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string Cpf) : base(Cpf, 2000, 0.2)
        {}

        public override void AumentarSalario()
        {
            this.Salario += this.Salario * 0.1;
        }
    }
}