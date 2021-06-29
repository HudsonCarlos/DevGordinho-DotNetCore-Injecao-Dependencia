using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc
{
    public class PraticandoID : ConfiguracaoIoc
    {
        public PraticandoID(IServiceCollection services) : base(services) { }

        public override void RegistrarDependencias()
        {
            
        }
    }
}
