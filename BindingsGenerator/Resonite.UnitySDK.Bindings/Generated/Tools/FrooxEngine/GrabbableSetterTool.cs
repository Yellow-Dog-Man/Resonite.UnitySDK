
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableSetterTool
// Generated on: pátek 6. března 2026 14:19:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableSetterTool")]
public partial class GrabbableSetterTool : global::FrooxEngine.BuilderActionTool

{
    public global::System.Boolean SetScalable { get => SetScalable_Element.Data; set => SetScalable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetScalable_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _indicatorColor { get => _indicatorColor_Element.Data; set => _indicatorColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _indicatorColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetScalable", SetScalable_Element.ToLinkField(context));
members.Add("_indicatorColor", _indicatorColor_Element.ToLinkReference(context));
}

}
}
