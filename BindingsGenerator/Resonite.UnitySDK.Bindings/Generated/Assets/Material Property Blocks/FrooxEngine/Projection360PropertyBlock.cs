
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Projection360PropertyBlock
// Generated on: čtvrtek 26. února 2026 15:07:52
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Projection360PropertyBlock")]
public partial class Projection360PropertyBlock : global::FrooxEngine.MaterialPropertyBlockProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public UnityEngine.Vector2 PerspectiveFieldOfView { get => PerspectiveFieldOfView_Element.Data; set => PerspectiveFieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PerspectiveFieldOfView_Element = new();
public UnityEngine.Vector2 PerspectiveAngleOffset { get => PerspectiveAngleOffset_Element.Data; set => PerspectiveAngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PerspectiveAngleOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("PerspectiveFieldOfView", PerspectiveFieldOfView_Element.ToLinkField(context));
members.Add("PerspectiveAngleOffset", PerspectiveAngleOffset_Element.ToLinkField(context));
}

}
}
