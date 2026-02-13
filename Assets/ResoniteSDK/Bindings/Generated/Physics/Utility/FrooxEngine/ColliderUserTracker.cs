
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColliderUserTracker
// Generated on: pátek 13. února 2026 23:21:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColliderUserTracker")]
public partial class ColliderUserTracker : global::FrooxEngine.CollisionListenerComponent

{
    public global::System.Boolean IsLocalUserInside;
public global::System.Boolean IsAnyUserInside;
public global::System.Int32 NumberOfUsersInside;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsLocalUserInside", IsLocalUserInside.ToResoniteLinkField());
members.Add("IsAnyUserInside", IsAnyUserInside.ToResoniteLinkField());
members.Add("NumberOfUsersInside", NumberOfUsersInside.ToResoniteLinkField());
}

}
}
