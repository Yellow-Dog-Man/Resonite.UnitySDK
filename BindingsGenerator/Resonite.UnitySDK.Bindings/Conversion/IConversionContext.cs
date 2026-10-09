using FrooxEngine;
using ResoniteLink;
using System.Threading.Tasks;
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
    IWorldElement TryResolveId(string id);

    #endregion

    #region ASSET CONVERSION

    void NotifyOfStaticMesh(UnityEngine.Mesh combinedMesh, int materialStartIndex, UnityEngine.Material[] materials);

    void RunOnConverted(UnityEngine.Component component, System.Action action);

    IAssetProvider<FrooxEngine.Mesh> GetMesh(UnityEngine.Mesh mesh, AssetMessagePostProcessor postProcessor = null);
    IAssetProvider<FrooxEngine.ITexture> GetITexture(UnityEngine.Texture texture, AssetMessagePostProcessor postProcessor = null);
    IAssetProvider<FrooxEngine.ITexture2D> GetITexture2D(UnityEngine.Texture texture, AssetMessagePostProcessor postProcessor = null);
    IAssetProvider<FrooxEngine.Texture2D> GetTexture2D(UnityEngine.Texture2D texture, AssetMessagePostProcessor postProcessor = null);
    IAssetProvider<FrooxEngine.Cubemap> GetCubemap(UnityEngine.Cubemap cubemap, AssetMessagePostProcessor postProcessor = null);
    IAssetProvider<FrooxEngine.AudioClip> GetAudioClip(UnityEngine.AudioClip audioClip, AssetMessagePostProcessor postProcessor = null);

    IAssetProvider<FrooxEngine.Material> GetMaterial(UnityEngine.Material material);

    #endregion

    #region METHOD CALLS

    Task<MethodResult> CallMethod(CallSyncMethod request);
    Task<MethodResult> CallMethod(CallStaticSyncMethod request);

    #endregion
}
