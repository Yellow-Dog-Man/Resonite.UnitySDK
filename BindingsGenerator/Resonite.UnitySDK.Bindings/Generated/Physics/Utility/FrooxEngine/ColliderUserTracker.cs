
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColliderUserTracker
// Generated on: čtvrtek 26. února 2026 15:08:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColliderUserTracker")]
public partial class ColliderUserTracker : global::FrooxEngine.CollisionListenerComponent

{
    public global::System.Boolean IsLocalUserInside { get => IsLocalUserInside_Element.Data; set => IsLocalUserInside_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLocalUserInside_Element = new();
public global::System.Boolean IsAnyUserInside { get => IsAnyUserInside_Element.Data; set => IsAnyUserInside_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsAnyUserInside_Element = new();
public global::System.Int32 NumberOfUsersInside { get => NumberOfUsersInside_Element.Data; set => NumberOfUsersInside_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> NumberOfUsersInside_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLocalUserInside", IsLocalUserInside_Element.ToLinkField(context));
members.Add("IsAnyUserInside", IsAnyUserInside_Element.ToLinkField(context));
members.Add("NumberOfUsersInside", NumberOfUsersInside_Element.ToLinkField(context));
}

}
}
