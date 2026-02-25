
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureUnpackingWizard
// Generated on: středa 25. února 2026 16:14:47
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> InputTexture;
public UnityEngine.Vector4Bool Channels;
public global::System.Nullable<UnityEngine.Vector2Int> ResolutionOverride;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> RTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> GTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> BTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> ATexture;
public global::System.Boolean IsProcessing;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InputTexture", InputTexture.ToResoniteReference(context));
members.Add("Channels", Channels.ToResoniteLinkField());
members.Add("ResolutionOverride", ResolutionOverride.ToResoniteLinkField());
members.Add("RTexture", RTexture.ToResoniteReference(context));
members.Add("GTexture", GTexture.ToResoniteReference(context));
members.Add("BTexture", BTexture.ToResoniteReference(context));
members.Add("ATexture", ATexture.ToResoniteReference(context));
members.Add("IsProcessing", IsProcessing.ToResoniteLinkField());
}

}
}
