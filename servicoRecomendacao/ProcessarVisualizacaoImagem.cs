using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarVisualizacaoImagem : IConsumer<VisualicaoImagem>
    {
        private ServicoProcessarVisualizacaoImagem _servicoImagem;

        public ProcessarVisualizacaoImagem()
        {
            _servicoImagem = new ServicoProcessarVisualizacaoImagem();
        }

        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            _servicoImagem.ProcessarRecomendacaoImagem(context.Message.IdImagem);

            return Task.CompletedTask;
        }
    }
}