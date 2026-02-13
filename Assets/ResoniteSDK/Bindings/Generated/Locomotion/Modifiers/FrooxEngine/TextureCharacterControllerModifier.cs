
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureCharacterControllerModifier
// Generated on: pátek 13. února 2026 5:51:14
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureCharacterControllerModifier")]
public partial class TextureCharacterControllerModifier : global::FrooxEngine.MeshColliderCharacterControllerModifier

{
    public global::System.Single MinValue;
public global::System.Single MaxValue;
public global::Elements.Core.ColorChannel Channel;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
members.Add("Channel", Channel.ToResoniteLinkField());
members.Add("Texture", new ResoniteLink.Reference() { });
}

}
}
