using System;
using System.Threading;
using core;

namespace servico
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
            Console.WriteLine("Processou erro da visualicao");
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