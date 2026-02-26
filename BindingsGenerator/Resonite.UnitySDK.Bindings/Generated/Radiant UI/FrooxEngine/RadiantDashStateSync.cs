
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashStateSync
// Generated on: čtvrtek 26. února 2026 15:09:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashStateSync")]
public partial class RadiantDashStateSync : global::FrooxEngine.Component

{
    public global::System.Boolean IsFreeform { get => IsFreeform_Element.Data; set => IsFreeform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsFreeform_Element = new();
public global::System.Boolean IsOpen { get => IsOpen_Element.Data; set => IsOpen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsOpen_Element = new();
public global::System.Single Curvature { get => Curvature_Element.Data; set => Curvature_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Curvature_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsFreeform", IsFreeform_Element.ToLinkField(context));
members.Add("IsOpen", IsOpen_Element.ToLinkField(context));
members.Add("Curvature", Curvature_Element.ToLinkField(context));
}

}
}
