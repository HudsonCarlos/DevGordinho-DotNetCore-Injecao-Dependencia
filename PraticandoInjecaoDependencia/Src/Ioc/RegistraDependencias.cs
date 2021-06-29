using Microsoft.Extensions.DependencyInjection;

namespace Ioc
{
    public static class RegistraDependencias
    {
        public static void GerenciadorDependencia(this IServiceCollection services)
        {
            _ = new PraticandoID(services);
        }
    }
}
