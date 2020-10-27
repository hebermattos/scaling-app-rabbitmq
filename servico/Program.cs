using System;
using MassTransit;

namespace servico
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(config =>
                        {
                            config.Host(new Uri($"rabbitmq://localhost"), host =>
                            {
                                host.Username("guest");
                                host.Password("guest");
                            });
                            config.ReceiveEndpoint("visualicaco.imagem", e =>
                            {
                                e.Consumer<ProcessarVisualizacaoImagem>();
                            });
                        });

            bus.Start();

            Console.WriteLine("servico iniciado");

            Console.ReadKey();
        }
    }
}
