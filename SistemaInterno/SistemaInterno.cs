using System;
using bytecode.Funcionarios;

namespace bytecode.SistemaInterno{
    public class SistemaInterno{
        public void Logar(IAutenticavel funcionario, string login, string senha){
            if(funcionario.Autenticar(login, senha)){
                Console.WriteLine("Autenticado com sucesso");
            }else{
                Console.WriteLine("Senha incorreta");
            }
        }
    }
}