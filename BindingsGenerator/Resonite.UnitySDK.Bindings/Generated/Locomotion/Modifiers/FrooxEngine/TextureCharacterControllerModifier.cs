
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureCharacterControllerModifier
// Generated on: čtvrtek 26. února 2026 15:08:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureCharacterControllerModifier")]
public partial class TextureCharacterControllerModifier : global::FrooxEngine.MeshColliderCharacterControllerModifier

{
    public global::System.Single MinValue { get => MinValue_Element.Data; set => MinValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinValue_Element = new();
public global::System.Single MaxValue { get => MaxValue_Element.Data; set => MaxValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxValue_Element = new();
public global::Elements.Core.ColorChannel Channel { get => Channel_Element.Data; set => Channel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.ColorChannel>, global::Elements.Core.ColorChannel> Channel_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> Texture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinValue", MinValue_Element.ToLinkField(context));
members.Add("MaxValue", MaxValue_Element.ToLinkField(context));
members.Add("Channel", Channel_Element.ToLinkField(context));
members.Add("Texture", Texture_Element.ToLinkReference(context));
}

}
}
