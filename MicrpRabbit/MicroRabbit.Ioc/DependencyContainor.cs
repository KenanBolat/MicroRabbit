using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Ioc
{
    public class DependencyContainor 
    {
        public static void RegisterServices(IServiceCollection services)
        
        {
            //DomainBus 
            services.AddTransient<IEventBus, RabbitMQBus>();
        }

    }
}
