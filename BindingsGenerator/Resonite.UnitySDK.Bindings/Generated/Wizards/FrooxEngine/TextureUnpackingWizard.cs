
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureUnpackingWizard
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureUnpackingWizard")]
public partial class TextureUnpackingWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> InputTexture { get => InputTexture_Element.Data; set => InputTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> InputTexture_Element = new();
public UnityEngine.Vector4Bool Channels { get => Channels_Element.Data; set => Channels_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector4Bool>, UnityEngine.Vector4Bool> Channels_Element = new();
public global::System.Nullable<UnityEngine.Vector2Int> ResolutionOverride { get => ResolutionOverride_Element.Data; set => ResolutionOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2Int>>, global::System.Nullable<UnityEngine.Vector2Int>> ResolutionOverride_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> RTexture { get => RTexture_Element.Data; set => RTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> RTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> GTexture { get => GTexture_Element.Data; set => GTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> GTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BTexture { get => BTexture_Element.Data; set => BTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> BTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ATexture { get => ATexture_Element.Data; set => ATexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> ATexture_Element = new();
public global::System.Boolean IsProcessing { get => IsProcessing_Element.Data; set => IsProcessing_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsProcessing_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InputTexture", InputTexture_Element.ToLinkReference(context));
members.Add("Channels", Channels_Element.ToLinkField(context));
members.Add("ResolutionOverride", ResolutionOverride_Element.ToLinkField(context));
members.Add("RTexture", RTexture_Element.ToLinkReference(context));
members.Add("GTexture", GTexture_Element.ToLinkReference(context));
members.Add("BTexture", BTexture_Element.ToLinkReference(context));
members.Add("ATexture", ATexture_Element.ToLinkReference(context));
members.Add("IsProcessing", IsProcessing_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task UnpackTextures(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
        __message.MethodName = "UnpackTextures";
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
}


}
}
