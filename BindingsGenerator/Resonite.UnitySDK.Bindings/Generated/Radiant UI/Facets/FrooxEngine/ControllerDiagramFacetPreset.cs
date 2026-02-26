
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ControllerDiagramFacetPreset
// Generated on: čtvrtek 26. února 2026 10:04:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ControllerDiagramFacetPreset")]
public partial class ControllerDiagramFacetPreset : global::FrooxEngine.FacetPreset

{
    public global::FrooxEngine.StaticTexture2D _texture { get => _texture_Element.Data; set => _texture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _texture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_texture", _texture_Element.Data.ToResoniteReference(context));
}

}
}
