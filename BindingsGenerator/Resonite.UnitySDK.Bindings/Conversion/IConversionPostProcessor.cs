using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public interface IConversionPostProcessor
{
    void PostProcessConversion(IConversionContext context);
}

public interface IComponentConversionPostProcessor
{
    void PostProcessConversion(ResoniteComponent component, IConversionContext context);
}
