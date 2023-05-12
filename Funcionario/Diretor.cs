namespace bytecode.Funcionarios{
    public class Diretor: FuncionarioAutenticavel{

        public Diretor(string Cpf,string login, string senha): base(Cpf, 5000,0.05, login, senha)
        {}

        public override void AumentarSalario()
        {
            this.Salario += this.Salario * 0.15;
        }
    }
}