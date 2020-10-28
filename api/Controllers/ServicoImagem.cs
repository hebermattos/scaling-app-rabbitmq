using System.Threading;

namespace api.Controllers
{
    public class ServicoImagem
    {
        public Imagem BuscarImagem(string id)
        {
            AtualizarMinhasVisualizacoes(id);

            AtualizarMaisVistas(id);

            AtualizarRecomendacoes(id);

            EnviarNotificacoes(id);

            return new Imagem
            {
                Nome = "imagem01",
                Conteudo = "saukdfapgsiufwauiryhw985v098q235qf79prysbi34hqf6293gry3vq9byg3947ft9hy39yvtoq"
            };
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

        private void AtualizarMinhasVisualizacoes(string id)
        {
            Thread.Sleep(1000);
            return;
        }
    }
}