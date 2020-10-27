using System.Threading;

namespace core
{
    public class ServicoImagem
    {
        public Imagem BuscarImagem(string id)
        {
            return new Imagem
            {
                Nome = "imagem01",
                Conteudo = "saukdfapgsiufwauiryhw985v098q235qf79prysbi34hqf6293gry3vq9byg3947ft9hy39yvtoq"
            };
        }

        public void ProcessarVisualizacaoImagem(string id)
        {
            AtualizarMinhasAvaliacoes(id);

            AtualizarMaisVistas(id);

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