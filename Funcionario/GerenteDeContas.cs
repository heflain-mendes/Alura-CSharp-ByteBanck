namespace bytecode.Funcionarios{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string Cpf, string login, string senha) : base(Cpf, 4000, 0.25,login, senha)
        {}

        public override void AumentarSalario()
        {
            this.Salario += this.Salario * 0.05;
        }
    }
}