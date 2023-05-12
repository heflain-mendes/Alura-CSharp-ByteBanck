using bytecode.Bonificacao;

namespace bytecode.Funcionarios{
    public abstract class Funcionario: IBonificacao{
        public static int QtdFuncionario {get; private set;} = 0;

        public string? Nome { get; set; }
        public string? Cpf { get; private set; }
        public double? Salario { get; protected set; }
        public double TaxaBonificacao { get; set;}

        public abstract void AumentarSalario();
        public double calcular(){
            return Convert.ToDouble(this.Salario) * this.TaxaBonificacao;
        }

        public Funcionario(string Cpf, double Salario, double taxaBonificacao)
        {
            this.Cpf = Cpf;
            this.Salario = Salario;
            this.TaxaBonificacao = taxaBonificacao;
            Funcionario.QtdFuncionario++;
        }
    }
}