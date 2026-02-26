
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralTexture
// Generated on: čtvrtek 26. února 2026 15:07:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralTexture")]
public abstract partial class ProceduralTexture : global::FrooxEngine.ProceduralTextureBase

{
    public UnityEngine.Vector2Int Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Size_Element = new();
public global::System.Boolean Mipmaps { get => Mipmaps_Element.Data; set => Mipmaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Mipmaps_Element = new();
public global::Renderite.Shared.TextureFormat Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFormat>, global::Renderite.Shared.TextureFormat> Format_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("Mipmaps", Mipmaps_Element.ToLinkField(context));
members.Add("Format", Format_Element.ToLinkField(context));
}

}
}
