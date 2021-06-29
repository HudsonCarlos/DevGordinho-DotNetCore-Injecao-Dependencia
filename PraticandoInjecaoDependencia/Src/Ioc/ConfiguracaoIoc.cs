using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ioc
{
    public abstract class ConfiguracaoIoc
    {
        protected IServiceCollection _sercices;

        public ConfiguracaoIoc(IServiceCollection services)
        {
            _sercices = services;
            RegistrarDependencias();
        }

        public abstract void RegistrarDependencias();
    }
}
