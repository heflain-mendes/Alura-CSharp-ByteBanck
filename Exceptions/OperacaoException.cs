namespace bytecode.Exceptions{
    public class OperacaoException: Exception{
        public OperacaoException(string mensagem, Exception exceptionInterna): base(mensagem, exceptionInterna)
        {}
    }
}