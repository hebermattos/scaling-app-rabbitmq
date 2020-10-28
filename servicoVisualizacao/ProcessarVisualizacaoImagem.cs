using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarVisualizacaoImagem : IConsumer<VisualicaoImagem>, IConsumer<Fault<VisualicaoImagem>>
    {
        private ServicoProcessarVisualizacaoImagem _servicoImagem;

        public ProcessarVisualizacaoImagem()
        {
            _servicoImagem = new ServicoProcessarVisualizacaoImagem();
        }

        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            _servicoImagem.ProcessarVisualizacaoImagem(context.Message);

            return Task.CompletedTask;
        }

        public Task Consume(ConsumeContext<Fault<VisualicaoImagem>> context)
        {
            _servicoImagem.ProcessarVisualizacaoImagemErro(context.Message.Message);

            return Task.CompletedTask;
        }
    }
}