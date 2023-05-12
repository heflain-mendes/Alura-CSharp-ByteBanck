using bytecode.SistemaInterno;

namespace bytecode.Parceiro{
    public class ParceiroComercial : Parceiro, IAutenticavel
    {
        public ParceiroComercial (string login, string senha):base(login, senha)
        {}
    }
}