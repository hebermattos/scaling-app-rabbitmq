﻿using System;
using GreenPipes;
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

                            config.UseCircuitBreaker(cb =>
                            {
                                cb.TrackingPeriod = TimeSpan.FromMinutes(1);
                                cb.TripThreshold = 15;
                                cb.ActiveThreshold = 10;
                                cb.ResetInterval = TimeSpan.FromMinutes(5);
                            });

                            config.ReceiveEndpoint("visualizacao.imagem", e =>
                            {
                                e.UseRetry(r => r.Interval(5, TimeSpan.FromSeconds(1)));
                                e.Consumer<ProcessarVisualizacaoImagem>();
                            });
                        });

            bus.Start();

            Console.WriteLine("servico iniciado");

            Console.ReadLine();
        }
    }
}