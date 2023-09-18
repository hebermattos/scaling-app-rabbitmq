using System.Threading.Tasks;
using Events;
using MassTransit;
using Model;

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
                ImageID = id,
            });

            return new Image
            {
                Name = "image-01",
                Content = "<image-content>"
            };
        }       
    }
}