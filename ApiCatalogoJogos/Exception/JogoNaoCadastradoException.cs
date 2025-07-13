namespace ApiCatalogoJogos.Exception
{
    public class JogoNaoCadastradoException : IOException
    {
        public JogoNaoCadastradoException() 
            : base("Não existe jogo cadastrado com o id informado.")
        {
        }
    }   
}
