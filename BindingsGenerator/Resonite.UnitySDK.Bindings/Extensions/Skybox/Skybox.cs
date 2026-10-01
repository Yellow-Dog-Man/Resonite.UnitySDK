using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrooxEngine
{
    public partial class Skybox : IComponentConversionPostProcessor
    {
        public void PostProcessConversion(ResoniteComponent container, IConversionContext context)
        {
            if (!container.isActiveAndEnabled)
                return;

            // Wrapper is active, set it as the active skybox
            Task.Run(async () => await SetActive(context)).Wait();
        }
    }
}
