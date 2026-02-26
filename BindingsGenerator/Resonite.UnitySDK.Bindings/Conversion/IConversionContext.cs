using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConversionContext
{
    string GetUniqueMessageId(string prefix);

    #region ID MANAGEMENT

    string GetTransformSlotId(Transform transform);
    string GetId(IWorldElement o);
    string GetIdOrAllocate(IWorldElement o);
    string GetIdOrAllocate(IWorldElement o, out bool allocated);
    void RemoveId(IWorldElement o);

    #endregion

    #region ASSET CONVERSION

    IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh);
    IAssetProvider<FrooxEngine.ITexture> GetITexture(UnityEngine.Texture texture);
    IAssetProvider<FrooxEngine.ITexture2D> GetITexture2D(UnityEngine.Texture texture);
    IAssetProvider<FrooxEngine.Texture2D> GetTexture2D(UnityEngine.Texture2D texture);
    IAssetProvider<FrooxEngine.Cubemap> GetCubemap(UnityEngine.Cubemap cubemap);
    IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material);
    IAssetProvider<FrooxEngine.AudioClip> GetAudioClip(UnityEngine.AudioClip audioClip);

    #endregion
}
 