namespace ApiCatalogoJogos.Exception
{
    public class JogoJaCadastradoException : IOException
    {
        public JogoJaCadastradoException() 
            : base("Já existe um jogo cadastrado com este nome.")
        {
        }
    }
}
