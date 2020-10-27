using System.Threading;

namespace core
{
    public class ServicoProcessarVisualizacaoImagem
    {
        public void ProcessarVisualizacaoImagem(string id)
        {
            AtualizarMinhasAvaliacoes(id);

            AtualizarMaisVistas(id);
        }

        public void ProcessarRecomendacaoImagem(string id)
        {
            AtualizarRecomendacoes(id);

            EnviarNotificacoes(id);
        }

        private void EnviarNotificacoes(string id)
        {
            Thread.Sleep(1000);
            return;
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

        private void AtualizarMinhasAvaliacoes(string id)
        {
            Thread.Sleep(1000);
            return;
        }
    }
}