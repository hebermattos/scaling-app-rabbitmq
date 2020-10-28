using System.Threading;
using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarVisualizacaoImagem : IConsumer<VisualicaoImagem>
    {
        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            var id = context.Message.IdImagem;

            AtualizarMinhasVisualizacoes(id);

            AtualizarMaisVistas(id);

            AtualizarRecomendacoes(id);

            EnviarNotificacoes(id);

            return Task.CompletedTask;
        }

        private void AtualizarRecomendacoes(string id)
        {
            Thread.Sleep(1000);
            return;
        }

        private void AtualizarMaisVistas(string id)
        {
            Thread.Sleep(1000);
            return;
        }

        private void AtualizarMinhasVisualizacoes(string id)
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