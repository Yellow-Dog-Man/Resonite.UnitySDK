
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurvePoint
// Generated on: pátek 6. března 2026 14:19:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurvePoint")]
public partial class CurvePoint : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot LeftTangentSource { get => LeftTangentSource_Element.Data; set => LeftTangentSource_Element.Data = value; }
public Reference<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> LeftTangentSource_Element = new();
public global::FrooxEngine.Slot RightTangentSource { get => RightTangentSource_Element.Data; set => RightTangentSource_Element.Data = value; }
public Reference<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> RightTangentSource_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftTangentSource", LeftTangentSource_Element.ToLinkReference(context));
members.Add("RightTangentSource", RightTangentSource_Element.ToLinkReference(context));
}

}
}
