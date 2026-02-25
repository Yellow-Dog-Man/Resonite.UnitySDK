
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionPermissions+LocomotionFilter
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
    public partial class LocomotionPermissions
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionPermissions+LocomotionFilter")]
public partial class LocomotionFilter : global::FrooxEngine.SyncObject

{
    public System.String LocomotionType;
public global::System.String RequireTag;
public global::System.Boolean EditModeOnly;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocomotionType", LocomotionType.ToResoniteLinkField());
members.Add("RequireTag", RequireTag.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
}

}
            }
}
