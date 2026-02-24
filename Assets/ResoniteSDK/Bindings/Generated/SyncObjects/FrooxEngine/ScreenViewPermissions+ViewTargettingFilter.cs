
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenViewPermissions+ViewTargettingFilter
// Generated on: úterý 24. února 2026 18:17:53
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
    public partial class ScreenViewPermissions
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenViewPermissions+ViewTargettingFilter")]
public partial class ViewTargettingFilter : global::FrooxEngine.SyncObject

{
    public System.String ViewTargettingType;
public global::System.String RequireTag;
public global::System.Boolean EditModeOnly;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViewTargettingType", ViewTargettingType.ToResoniteLinkField());
members.Add("RequireTag", RequireTag.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
}

}
            }
}
