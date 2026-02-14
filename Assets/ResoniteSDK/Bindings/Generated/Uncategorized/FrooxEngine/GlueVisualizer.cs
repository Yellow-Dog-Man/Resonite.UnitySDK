
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GlueVisualizer
// Generated on: sobota 14. února 2026 8:58:44
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GlueVisualizer")]
public partial class GlueVisualizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.FresnelMaterial Material;
public global::FrooxEngine.Glue Glue;
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale;
public UnityEngine.Vector3 BaseScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Glue", Glue.ToResoniteReference(context));
members.Add("Scale", Scale.ToResoniteReference(context));
members.Add("BaseScale", BaseScale.ToResoniteLinkField());
}

}
}
