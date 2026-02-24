
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Projection360PropertyBlock
// Generated on: úterý 24. února 2026 18:17:34
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public UnityEngine.Vector2 PerspectiveFieldOfView;
public UnityEngine.Vector2 PerspectiveAngleOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("PerspectiveFieldOfView", PerspectiveFieldOfView.ToResoniteLinkField());
members.Add("PerspectiveAngleOffset", PerspectiveAngleOffset.ToResoniteLinkField());
}

}
}
