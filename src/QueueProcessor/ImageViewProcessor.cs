using System;
using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ImageViewProcessor : IConsumer<ImageViewEvent>
    {
        public Task Consume(ConsumeContext<ImageViewEvent> context)
        {
            AtualizarMinhasAvaliacoes(context.Message.IdImagem);

            AtualizarMaisVistas(context.Message.IdImagem);

            AtualizarRecomendacoes(context.Message.IdImagem);

            EnviarNotificacoes(context.Message.IdImagem);

            return Task.CompletedTask;
        }

        private void AtualizarMaisVistas(string id)
        {
            Console.WriteLine("Atualizou mais vistas:" + id);
            return;
        }

        private void AtualizarMinhasAvaliacoes(string id)
        {
            Console.WriteLine("Atualizou minhas visualizações:" + id);
            return;
        }

          private void AtualizarRecomendacoes(string id)
        {
            Console.WriteLine("Atualizou Recomendacoes:" + id);
            return;
        }

        private void EnviarNotificacoes(string id)
        {
            Console.WriteLine("Enviou Notificacoes:" + id);
            return;
        }
    }
}