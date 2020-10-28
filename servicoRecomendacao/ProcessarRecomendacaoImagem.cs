using System.Threading.Tasks;
using core;
using MassTransit;

namespace servico
{
    public class ProcessarRecomendacaoImagem : IConsumer<VisualicaoImagem>, IConsumer<Fault<VisualicaoImagem>>
    {
        private ServicoProcessarRecomendacaoImagem _servicoImagem;

        public ProcessarRecomendacaoImagem()
        {
            _servicoImagem = new ServicoProcessarRecomendacaoImagem();
        }

        public Task Consume(ConsumeContext<VisualicaoImagem> context)
        {
            _servicoImagem.ProcessarRecomendacaoImagem(context.Message);

            return Task.CompletedTask;
        }

        public Task Consume(ConsumeContext<Fault<VisualicaoImagem>> context)
        {
            _servicoImagem.ProcessarRecomendacaoImagemErro(context.Message.Message);

            return Task.CompletedTask;
        }
    }
}