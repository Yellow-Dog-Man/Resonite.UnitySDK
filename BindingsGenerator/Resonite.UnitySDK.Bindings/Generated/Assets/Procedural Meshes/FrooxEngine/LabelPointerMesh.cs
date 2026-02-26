
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LabelPointerMesh
// Generated on: čtvrtek 26. února 2026 15:07:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LabelPointerMesh")]
public partial class LabelPointerMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 LabelPoint { get => LabelPoint_Element.Data; set => LabelPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LabelPoint_Element = new();
public UnityEngine.Vector3 TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetPoint_Element = new();
public UnityEngine.Quaternion LabelRotation { get => LabelRotation_Element.Data; set => LabelRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LabelRotation_Element = new();
public global::System.Single LabelWidth { get => LabelWidth_Element.Data; set => LabelWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LabelWidth_Element = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public global::System.Single ExpandLerp { get => ExpandLerp_Element.Data; set => ExpandLerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ExpandLerp_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LabelPoint", LabelPoint_Element.ToLinkField(context));
members.Add("TargetPoint", TargetPoint_Element.ToLinkField(context));
members.Add("LabelRotation", LabelRotation_Element.ToLinkField(context));
members.Add("LabelWidth", LabelWidth_Element.ToLinkField(context));
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("ExpandLerp", ExpandLerp_Element.ToLinkField(context));
members.Add("DualSided", DualSided_Element.ToLinkField(context));
}

}
}
