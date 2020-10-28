using System;
using System.Threading;
using core;

namespace servico
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
            Console.WriteLine("Processou erro da recomendacao");
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