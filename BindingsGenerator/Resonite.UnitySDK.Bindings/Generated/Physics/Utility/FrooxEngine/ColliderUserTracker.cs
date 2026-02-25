
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColliderUserTracker
// Generated on: středa 25. února 2026 16:13:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColliderUserTracker")]
public partial class ColliderUserTracker : global::FrooxEngine.CollisionListenerComponent

{
    public global::System.Boolean IsLocalUserInside;
public global::System.Boolean IsAnyUserInside;
public global::System.Int32 NumberOfUsersInside;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLocalUserInside", IsLocalUserInside.ToResoniteLinkField());
members.Add("IsAnyUserInside", IsAnyUserInside.ToResoniteLinkField());
members.Add("NumberOfUsersInside", NumberOfUsersInside.ToResoniteLinkField());
}

}
}
