using System;
using System.Threading;

namespace core
{
    public class ServicoProcessarRecomendacaoImagem
    {
        public void ProcessarRecomendacaoImagem(VisualicaoImagem evento)
        {
            AtualizarRecomendacoes(evento.IdImagem);

            EnviarNotificacoes(evento.IdImagem);
        }

        public void ProcessarRecomendacaoImagemErro(VisualicaoImagem message)
        {
            throw new NotImplementedException();
        }

        private void AtualizarRecomendacoes(string id)
        {
            Thread.Sleep(1000);
            return;
        }

        private void EnviarNotificacoes(string id)
        {
            Thread.Sleep(1000);
            return;
        }
        
    }
}