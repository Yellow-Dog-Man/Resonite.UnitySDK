
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurvePoint
// Generated on: středa 25. února 2026 16:14:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurvePoint")]
public partial class CurvePoint : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot LeftTangentSource;
public global::FrooxEngine.Slot RightTangentSource;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftTangentSource", LeftTangentSource.ToResoniteReference(context));
members.Add("RightTangentSource", RightTangentSource.ToResoniteReference(context));
}

}
}
