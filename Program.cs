using System;
using bytecode.Conta;

namespace bytecode{
    public class Program{
        public static void Main(){
            try{
                new Conta.ContaCorrente(-1, "Teste");
            }catch(ArgumentException ex){
                System.Console.WriteLine(ex.ParamName);
                System.Console.WriteLine($"Error identificado: {ex.Message}");
            }
        }
    }
}