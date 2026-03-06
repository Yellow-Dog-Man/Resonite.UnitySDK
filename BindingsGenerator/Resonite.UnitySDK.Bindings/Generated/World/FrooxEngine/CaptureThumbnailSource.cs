
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CaptureThumbnailSource
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CaptureThumbnailSource")]
public abstract partial class CaptureThumbnailSource : global::FrooxEngine.Component, global::FrooxEngine.IWorldSessionThumbnailSource

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Overlay { get => Overlay_Element.Data; set => Overlay_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Overlay_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Overlay", Overlay_Element.ToLinkReference(context));
}

}
}
