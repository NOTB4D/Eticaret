﻿using Core.Utilities.Ioc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            //services.AddMemoryCache();
           // services.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddSingleton<Stopwatch>();
        }
    }
}