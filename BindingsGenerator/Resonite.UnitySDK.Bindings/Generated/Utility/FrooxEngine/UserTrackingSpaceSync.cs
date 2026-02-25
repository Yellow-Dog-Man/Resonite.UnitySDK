
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserTrackingSpaceSync
// Generated on: středa 25. února 2026 16:14:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserTrackingSpaceSync")]
public partial class UserTrackingSpaceSync : global::FrooxEngine.Component

{
    public global::System.Boolean SeatedMode;
public global::System.Single UserHeight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SeatedMode", SeatedMode.ToResoniteLinkField());
members.Add("UserHeight", UserHeight.ToResoniteLinkField());
}

}
}
