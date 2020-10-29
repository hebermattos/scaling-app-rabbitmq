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
            AtualizarMinhasAvaliacoes(context.Message.IdImagem);

            AtualizarMaisVistas(context.Message.IdImagem);

            return Task.CompletedTask;
        }

        private void AtualizarMaisVistas(string id)
        {
            Thread.Sleep(1000);
            return;
        }

        private void AtualizarMinhasAvaliacoes(string id)
        {
            Thread.Sleep(1000);
            return;
        }
    }
}