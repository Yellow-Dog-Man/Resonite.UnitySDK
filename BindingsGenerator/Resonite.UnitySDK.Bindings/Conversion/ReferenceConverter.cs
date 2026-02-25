using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResoniteLink;

public static class ReferenceConverter
{
    public static Reference ToResoniteReference<T>(this T target, IConversionContext context)
        where T : class
    {
        var reference = new Reference();

        if (target is ResoniteObject resoniteObject)
            reference.TargetID = context.GetIdOrAllocate(resoniteObject);

        return reference;
    }
}