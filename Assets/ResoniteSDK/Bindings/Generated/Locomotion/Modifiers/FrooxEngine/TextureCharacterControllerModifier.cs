
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureCharacterControllerModifier
// Generated on: čtvrtek 19. února 2026 7:59:00
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureCharacterControllerModifier")]
public partial class TextureCharacterControllerModifier : global::FrooxEngine.MeshColliderCharacterControllerModifier

{
    public global::System.Single MinValue;
public global::System.Single MaxValue;
public global::Elements.Core.ColorChannel Channel;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
members.Add("Channel", Channel.ToResoniteLinkField());
members.Add("Texture", Texture.ToResoniteReference(context));
}

}
}
