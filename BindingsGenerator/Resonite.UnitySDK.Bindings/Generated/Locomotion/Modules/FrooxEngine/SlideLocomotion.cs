
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlideLocomotion
// Generated on: středa 25. února 2026 16:13:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlideLocomotion")]
public partial class SlideLocomotion : global::FrooxEngine.NoclipLocomotion

{
    public global::System.Single MaxSnapDistance;
public global::System.Single SnapCheckOffset;
public global::System.Single SnapMinObjectSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSnapDistance", MaxSnapDistance.ToResoniteLinkField());
members.Add("SnapCheckOffset", SnapCheckOffset.ToResoniteLinkField());
members.Add("SnapMinObjectSize", SnapMinObjectSize.ToResoniteLinkField());
}

}
}
