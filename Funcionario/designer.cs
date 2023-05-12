using System;

namespace bytecode.Funcionarios{
    public class Designer : Funcionario
    {
        public Designer(string Cpf) : base(Cpf, 3000, 0.17)
        {}

        public override void AumentarSalario()
        {
            this.Salario += this.Salario * 0.11;
        }
    }
}