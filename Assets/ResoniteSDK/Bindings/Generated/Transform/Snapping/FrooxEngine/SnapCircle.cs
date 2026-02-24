
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapCircle
// Generated on: úterý 24. února 2026 18:20:16
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapCircle")]
public partial class SnapCircle : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public global::System.Single Radius;
public UnityEngine.Vector3 Normal;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("SnapParent", SnapParent.ToResoniteReference(context));
}

}
}
