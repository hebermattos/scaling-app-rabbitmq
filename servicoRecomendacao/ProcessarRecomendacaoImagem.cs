using System.Threading;
using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarRecomendacaoImagem : IConsumer<VisualicaoImagem>
    {
        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            throw new System.Exception("asdasdasd");

            AtualizarRecomendacoes(context.Message.IdImagem);

            EnviarNotificacoes(context.Message.IdImagem);

            return Task.CompletedTask;
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