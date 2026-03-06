
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProceduralTexture3D
// Generated on: pátek 6. března 2026 14:18:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProceduralTexture3D")]
public abstract partial class ProceduralTexture3D : global::FrooxEngine.ProceduralTexture3DBase

{
    public UnityEngine.Vector3Int Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3Int>, UnityEngine.Vector3Int> Size_Element = new();
public global::Renderite.Shared.TextureFormat Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFormat>, global::Renderite.Shared.TextureFormat> Format_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("Format", Format_Element.ToLinkField(context));
}

}
}
