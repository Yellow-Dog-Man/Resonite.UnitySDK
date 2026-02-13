
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDashStateSync
// Generated on: pátek 13. února 2026 23:23:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDashStateSync")]
public partial class RadiantDashStateSync : global::FrooxEngine.Component

{
    public global::System.Boolean IsFreeform;
public global::System.Boolean IsOpen;
public global::System.Single Curvature;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsFreeform", IsFreeform.ToResoniteLinkField());
members.Add("IsOpen", IsOpen.ToResoniteLinkField());
members.Add("Curvature", Curvature.ToResoniteLinkField());
}

}
}
