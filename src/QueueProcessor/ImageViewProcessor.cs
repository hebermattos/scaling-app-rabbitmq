using System;
using System.Threading.Tasks;
using Events;
using MassTransit;

namespace servico
{
    public class ImageViewProcessor : IConsumer<ImageViewEvent>
    {
        public Task Consume(ConsumeContext<ImageViewEvent> context)
        {
            UpdateMostViewed(context.Message.ImageID);

            UpdateRecommendations(context.Message.ImageID);

            return Task.CompletedTask;
        }

        private void UpdateMostViewed(string id)
        {
            Console.WriteLine("UpdateMostViewed: " + id);
            return;
        }

        private void UpdateRecommendations(string id)
        {
            Console.WriteLine("UpdateMostViewed: " + id);
            return;
        }

    }
}