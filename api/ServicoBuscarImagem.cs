using System.Threading.Tasks;
using core;
using MassTransit;

namespace api
{
    public class ServicoBuscarImagem
    {
        private IBusControl _busControl;

        public ServicoBuscarImagem(IBusControl busControl)
        {
            _busControl = busControl;
        }

        public async Task<Imagem> BuscarImagemAsync(string id)
        {
            await _busControl.Publish(new VisualicaoImagem
            {
                IdImagem = id,
            });

            return new Imagem
            {
                Nome = "imagem01",
                Conteudo = "saukdfapgsiufwauiryhw985v098q235qf79prysbi34hqf6293gry3vq9byg3947ft9hy39yvtoq"
            };
        }       
    }
}