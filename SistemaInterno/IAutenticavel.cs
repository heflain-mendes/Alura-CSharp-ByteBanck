using System;
using bytecode.Funcionarios;

namespace bytecode.SistemaInterno{
    public interface IAutenticavel
    {
        public bool Autenticar(string login, string senha);
    }
}