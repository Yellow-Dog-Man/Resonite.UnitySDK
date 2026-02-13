
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GlueVisualizer
// Generated on: pátek 13. února 2026 23:23:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GlueVisualizer")]
public partial class GlueVisualizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.FresnelMaterial Material;
public global::FrooxEngine.Glue Glue;
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale;
public UnityEngine.Vector3 BaseScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("Glue", new ResoniteLink.Reference() { });
members.Add("Scale", new ResoniteLink.Reference() { });
members.Add("BaseScale", BaseScale.ToResoniteLinkField());
}

}
}
