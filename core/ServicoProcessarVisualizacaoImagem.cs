using System;
using System.Threading;

namespace core
{
    public class ServicoProcessarVisualizacaoImagem
    {
        public void ProcessarVisualizacaoImagem(VisualicaoImagem evento)
        {
            AtualizarMinhasAvaliacoes(evento.IdImagem);

            AtualizarMaisVistas(evento.IdImagem);
        }

        public void ProcessarVisualizacaoImagemErro(VisualicaoImagem message)
        {
            throw new NotImplementedException();
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