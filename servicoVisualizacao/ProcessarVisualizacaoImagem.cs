using System;
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
            Console.WriteLine("Atualizou mais vistas");
            return;
        }

        private void AtualizarMinhasAvaliacoes(string id)
        {
            Console.WriteLine("Atualizou minha visualizações");
            return;
        }
    }
}