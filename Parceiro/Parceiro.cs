using bytecode.SistemaInterno;

namespace bytecode.Parceiro{
    public abstract class Parceiro : IAutenticavel
    {
        public string Login { get; init;}
        public string Senha { get; init;}

        public Parceiro(string login, string senha){
            this.Login = login;
            this.Senha = senha;
        }

        public bool Autenticar(string login, string senha){
            return this.Login == login && this.Senha == senha;
        }
    }
}