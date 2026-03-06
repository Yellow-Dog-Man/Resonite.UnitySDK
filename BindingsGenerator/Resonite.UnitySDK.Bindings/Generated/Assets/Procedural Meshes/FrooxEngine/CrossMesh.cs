
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CrossMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CrossMesh")]
public partial class CrossMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Size_Element = new();
public global::System.Single BarRatio { get => BarRatio_Element.Data; set => BarRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BarRatio_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkField(context));
members.Add("BarRatio", BarRatio_Element.ToLinkField(context));
}

}
}
