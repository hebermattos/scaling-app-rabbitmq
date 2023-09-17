using System.Threading.Tasks;
using core;
using MassTransit;

namespace api
{
    public class ImageService
    {
        private IBusControl _busControl;

        public ImageService(IBusControl busControl)
        {
            _busControl = busControl;
        }

        public async Task<Image> GetImage(string id)
        {
            await _busControl.Publish(new ImageViewEvent
            {
                IdImagem = id,
            });

            return new Image
            {
                Name = "imagem01",
                Content = "saukdfapgsiufwauiryhw985v098q235qf79prysbi34hqf6293gry3vq9byg3947ft9hy39yvtoq"
            };
        }       
    }
}