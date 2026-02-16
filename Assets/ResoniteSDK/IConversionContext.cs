using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConversionContext
{
    string GetUniqueMessageId(string prefix);

    #region ID MANAGEMENT

    string GetTransformSlotId(Transform transform);
    string GetId(ResoniteObject o);
    string GetIdOrAllocate(ResoniteObject o);
    string GetIdOrAllocate(ResoniteObject o, out bool allocated);
    void RemoveId(ResoniteObject o);

    #endregion

    #region ASSET CONVERSION

    IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh);
    IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material);

    #endregion
}
 