
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralCubemap
// Generated on: pátek 13. února 2026 23:21:34
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralCubemap")]
public abstract partial class ProceduralCubemap : global::FrooxEngine.ProceduralCubemapBase

{
    public global::System.Int32 Size;
public global::System.Boolean Mipmaps;
public global::Renderite.Shared.TextureFormat Format;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Mipmaps", Mipmaps.ToResoniteLinkField());
members.Add("Format", Format.ToResoniteLinkField());
}

}
}
