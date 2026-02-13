using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConversionContext
{
    string GetUniqueMessageId(string prefix);
    string GetTransformSlotId(Transform transform);
    string GetIdOrAllocate(ResoniteObject o);
    string GetIdOrAllocate(ResoniteObject o, out bool allocated);
}
