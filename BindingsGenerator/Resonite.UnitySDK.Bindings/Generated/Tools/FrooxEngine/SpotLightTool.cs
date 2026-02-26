
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpotLightTool
// Generated on: čtvrtek 26. února 2026 15:09:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpotLightTool")]
public partial class SpotLightTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.PBS_Metallic Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_Metallic>, global::FrooxEngine.PBS_Metallic> Material_Element = new();
public global::FrooxEngine.Light Light { get => Light_Element.Data; set => Light_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> Light_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Light", Light_Element.ToLinkReference(context));
}

}
}
