using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litclassic.Models.ProxyModels
{
    public class ParticleParamsProxy : IParticleParamsProxy
    {
        private readonly ILogger<ParticleParamsProxy> _logger;

        public ParticleParamsProxy(ILogger<ParticleParamsProxy> logger)
        {
            _logger = logger;
        }
    }
}
