
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralTexture
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralTexture")]
public abstract partial class ProceduralTexture : global::FrooxEngine.ProceduralTextureBase

{
    public UnityEngine.Vector2Int Size;
public global::System.Boolean Mipmaps;
public global::Renderite.Shared.TextureFormat Format;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Mipmaps", Mipmaps.ToResoniteLinkField());
members.Add("Format", Format.ToResoniteLinkField());
}

}
}
