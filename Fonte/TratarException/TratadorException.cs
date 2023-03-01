namespace TratarException
{
    public static class TratadorException
    {
        private static string MensagemPadraoStackVazia = "Sem definições de stack.";

        public static string LancarException(Exception e)
        {
            if (e.InnerException != null)
                return e.InnerException.Message;
            else
                return e.Message;
        }

        public static string LancarException(string mensagemPadrao, Exception e)
        {
            string mensagemErro = mensagemPadrao;

            if (e.InnerException != null)
                mensagemErro += e.InnerException.Message;
            else
                mensagemErro += e.Message;

            return mensagemErro;
        }

        public static void LancarException(Exception e, out string mensagem)
        {
            if(e.InnerException != null)
                mensagem = e.InnerException.Message;
            else
                mensagem = e.Message;            
        }

        public static void LancarException(Exception e, out string mensagem, out string stack)
        {
            if(e.InnerException != null)
            {
                mensagem = e.InnerException.Message;
                stack = e.InnerException.StackTrace != null? e.InnerException.StackTrace: MensagemPadraoStackVazia;
            }
            else
            {
                mensagem = e.Message;
                stack = e.StackTrace != null? e.StackTrace: MensagemPadraoStackVazia;
            }
        }
    }
}