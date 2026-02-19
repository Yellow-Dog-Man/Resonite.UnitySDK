
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CaptureThumbnailSource
// Generated on: čtvrtek 19. února 2026 8:00:34
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Overlay;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Overlay", Overlay.ToResoniteReference(context));
}

}
}
