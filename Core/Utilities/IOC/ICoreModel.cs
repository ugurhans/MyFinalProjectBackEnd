using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IOC
{
    public interface ICoreModel
    {
        void Load(IServiceCollection serviceDescriptors);
    }
}
