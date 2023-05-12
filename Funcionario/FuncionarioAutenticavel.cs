using bytecode.SistemaInterno;

namespace bytecode.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Login { get; protected set; }
        public string Senha { get; protected set; }

        protected FuncionarioAutenticavel(string Cpf, double Salario, double taxaBonificacao, string login, string senha) 
        : base(Cpf, Salario, taxaBonificacao)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}