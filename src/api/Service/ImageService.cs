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

        public Image GetImage(string id)
        {
            UpdateMostViewed(id);

            UpdateRecommendations(id);

            return new Image
            {
                Name = "image-01",
                Content = "<image-content>"
            };
        }


        private void UpdateMostViewed(string id)
        {
            //Console.WriteLine("UpdateMostViewed" + id);
            return;
        }

        private void UpdateRecommendations(string id)
        {
            //Console.WriteLine("UpdateMostViewed:" + id);
        }

    }
}