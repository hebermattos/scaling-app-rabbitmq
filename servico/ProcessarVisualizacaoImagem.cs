using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarVisualizacaoImagem : IConsumer<VisualicaoImagem>
    {
        private ServicoImagem _servicoImagem;

        public ProcessarVisualizacaoImagem()
        {
            _servicoImagem = new ServicoImagem();
        }

        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            _servicoImagem.ProcessarVisualizacaoImagem(context.Message.IdImagem);

            return Task.CompletedTask;
        }
    }
}